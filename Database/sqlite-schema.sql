-- ============================================================================
-- Car Rental Management System - SQLite schema
-- Converted from SQL Server (T-SQL) to SQLite.
-- How to build the database file:
--   sqlite3 CarRental.db < sqlite-schema.sql
--   (then optionally load the data with sqlite-seed-data.sql)
-- ============================================================================

PRAGMA foreign_keys = OFF;

DROP VIEW IF EXISTS vw_ActiveBookings;
DROP TABLE IF EXISTS RentalTransaction;
DROP TABLE IF EXISTS VehicleReturns;
DROP TABLE IF EXISTS RentalBooking;
DROP TABLE IF EXISTS VehicleMaintenanceHistory;
DROP TABLE IF EXISTS VehicleMaintenance;
DROP TABLE IF EXISTS Vehicles;
DROP TABLE IF EXISTS Car_Details;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Makes;
DROP TABLE IF EXISTS Models;
DROP TABLE IF EXISTS FuelTypes;
DROP TABLE IF EXISTS VehicleCategories;
DROP TABLE IF EXISTS Years;
DROP TABLE IF EXISTS Users;

-- Lookup tables --------------------------------------------------------------
CREATE TABLE Users (
    UserID   INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT,
    Password TEXT,
    Role     TEXT
);

CREATE TABLE Makes (
    MakeID   INTEGER PRIMARY KEY AUTOINCREMENT,
    MakeName TEXT NOT NULL
);

CREATE TABLE Models (
    ModelID   INTEGER PRIMARY KEY AUTOINCREMENT,
    ModelName TEXT
);

CREATE TABLE FuelTypes (
    FuelTypeID   INTEGER PRIMARY KEY AUTOINCREMENT,
    FuelTypeName TEXT
);

CREATE TABLE VehicleCategories (
    CategoryID   INTEGER PRIMARY KEY AUTOINCREMENT,
    CategoryName TEXT NOT NULL
);

CREATE TABLE Years (
    YearID    INTEGER PRIMARY KEY AUTOINCREMENT,
    YearValue INTEGER NOT NULL
);

-- Large make/model/year catalogue (used by the vehicle dropdowns).
-- The extra "rn" column exists in the original seed data, so it is kept here.
CREATE TABLE Car_Details (
    ymm_id              TEXT,
    MakeID              INTEGER,
    ModelID             INTEGER,
    FuelTypeID          INTEGER,
    CategoryID          INTEGER,
    ModelName           TEXT,
    Year                INTEGER,
    Trim                TEXT,
    Submodel            TEXT,
    Body                TEXT,
    Cylinder_Type_Name  TEXT,
    Vehicle_Display_Name TEXT,
    Drive_Type          TEXT,
    Engine              TEXT,
    Engine_Block_Type   TEXT,
    Engine_CC           INTEGER,
    Engine_CID          INTEGER,
    Engine_Cylinders    INTEGER,
    Engine_Liter_Display REAL,
    Aspiration          TEXT,
    KBB_MODEL           TEXT,
    NumDoors            INTEGER,
    Parts_Model         TEXT,
    Region              TEXT,
    rn                  INTEGER
);

-- Core tables ----------------------------------------------------------------
CREATE TABLE Customer (
    CustomerID          INTEGER PRIMARY KEY AUTOINCREMENT,
    Name                TEXT NOT NULL,
    ContactInformation  TEXT,
    DriverLicenseNumber TEXT,
    ImagePath           TEXT
);

CREATE TABLE Vehicles (
    VehicleID          INTEGER PRIMARY KEY AUTOINCREMENT,
    Year               INTEGER,
    Mileage            INTEGER NOT NULL DEFAULT 0,
    PlateNumber        TEXT,
    CategoryID         INTEGER NOT NULL REFERENCES VehicleCategories (CategoryID),
    RentalPricePerDay  REAL NOT NULL DEFAULT 0.00,
    IsAvailableForRent INTEGER NOT NULL DEFAULT 1,
    MakeID             INTEGER NOT NULL REFERENCES Makes (MakeID),
    ModelID            INTEGER NOT NULL REFERENCES Models (ModelID),
    ImagePath          TEXT,
    FuelTypeID         INTEGER NOT NULL REFERENCES FuelTypes (FuelTypeID)
);

CREATE TABLE RentalBooking (
    BookingID             INTEGER PRIMARY KEY AUTOINCREMENT,
    CustomerID            INTEGER REFERENCES Customer (CustomerID),
    VehicleID             INTEGER REFERENCES Vehicles (VehicleID),
    RentalStartDate       TEXT,
    RentalEndDate         TEXT,
    PickupLocation        TEXT,
    DropoffLocation       TEXT,
    InitialRentalDays     INTEGER,
    RentalPricePerDay     REAL,
    InitialTotalDueAmount REAL,
    InitialCheckNotes     TEXT,
    StartMileage          INTEGER
);

CREATE TABLE VehicleReturns (
    ReturnID             INTEGER PRIMARY KEY AUTOINCREMENT,
    BookingID            INTEGER REFERENCES RentalBooking (BookingID),
    ActualReturnDate      TEXT,
    ActualRentalDays      INTEGER,
    Mileage              INTEGER,
    ConsumedMileage      INTEGER,
    FinalCheckNotes      TEXT,
    AdditionalCharges    REAL,
    ActualTotalDueAmount REAL
);

-- RemainingAmount / RefundAmount were computed columns in SQL Server.
-- SQLite (>= 3.31) supports the same idea via GENERATED ALWAYS AS columns.
CREATE TABLE RentalTransaction (
    TransactionID   INTEGER PRIMARY KEY AUTOINCREMENT,
    BookingID       INTEGER NOT NULL REFERENCES RentalBooking (BookingID),
    ReturnID        INTEGER NOT NULL REFERENCES VehicleReturns (ReturnID),
    PaymentMethod   TEXT,
    PaidAmount      REAL NOT NULL,
    ActualAmount    REAL NOT NULL,
    RemainingAmount REAL GENERATED ALWAYS AS (CASE WHEN ActualAmount > PaidAmount THEN ActualAmount - PaidAmount ELSE 0 END),
    RefundAmount    REAL GENERATED ALWAYS AS (CASE WHEN PaidAmount > ActualAmount THEN PaidAmount - ActualAmount ELSE 0 END),
    TransactionDate TEXT DEFAULT (datetime('now', 'localtime'))
);

CREATE TABLE VehicleMaintenance (
    MaintenanceID   INTEGER PRIMARY KEY AUTOINCREMENT,
    VehicleID       INTEGER NOT NULL REFERENCES Vehicles (VehicleID),
    Description    TEXT,
    Cost           REAL,
    MaintenanceDate TEXT DEFAULT (datetime('now', 'localtime')),
    IsCompleted    INTEGER DEFAULT 0
);

CREATE TABLE VehicleMaintenanceHistory (
    MaintenanceID   INTEGER,
    VehicleID       INTEGER,
    Description    TEXT,
    Cost           REAL,
    MaintenanceDate TEXT,
    CompletedDate   TEXT DEFAULT (datetime('now', 'localtime'))
);

-- Indexes --------------------------------------------------------------------
CREATE INDEX IX_Vehicle_Category ON Vehicles (CategoryID);
CREATE INDEX IX_Vehicle_Plate ON Vehicles (PlateNumber);

-- Active bookings view (string concatenation uses || in SQLite) --------------
CREATE VIEW vw_ActiveBookings AS
SELECT
    b.BookingID,
    b.CustomerID,
    b.VehicleID,
    b.RentalStartDate,
    b.RentalEndDate,
    b.PickupLocation,
    b.DropoffLocation,
    b.InitialRentalDays,
    b.RentalPricePerDay,
    b.InitialTotalDueAmount,
    b.InitialCheckNotes,
    c.Name AS CustomerName,
    v.PlateNumber,
    m.MakeName,
    mo.ModelName,
    v.Year,
    ('Booking #' || CAST(b.BookingID AS TEXT) || ' - '
     || c.Name || ' - '
     || m.MakeName || ' ' || mo.ModelName || ' '
     || CAST(v.Year AS TEXT)
     || ' (' || v.PlateNumber || ')') AS BookingInfo
FROM RentalBooking b
JOIN Customer  c  ON b.CustomerID = c.CustomerID
JOIN Vehicles  v  ON b.VehicleID  = v.VehicleID
JOIN Makes     m  ON v.MakeID     = m.MakeID
JOIN Models    mo ON v.ModelID    = mo.ModelID
WHERE NOT EXISTS (
    SELECT 1 FROM VehicleReturns vr
    WHERE vr.BookingID = b.BookingID
);

PRAGMA foreign_keys = ON;
