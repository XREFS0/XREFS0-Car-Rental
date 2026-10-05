namespace XREFS0CarRental
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUserValue = new System.Windows.Forms.Label();
            this.lblRoleTitle = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlUserDivider = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblSectionOverview = new System.Windows.Forms.Label();
            this.pnlCardFleet = new System.Windows.Forms.Panel();
            this.pnlCardFleetAccent = new System.Windows.Forms.Panel();
            this.lblCardFleetTitle = new System.Windows.Forms.Label();
            this.lblStatVehiclesValue = new System.Windows.Forms.Label();
            this.pnlCardCustomers = new System.Windows.Forms.Panel();
            this.pnlCardCustomersAccent = new System.Windows.Forms.Panel();
            this.lblCardCustomersTitle = new System.Windows.Forms.Label();
            this.lblStatCustomersValue = new System.Windows.Forms.Label();
            this.pnlCardBookings = new System.Windows.Forms.Panel();
            this.pnlCardBookingsAccent = new System.Windows.Forms.Panel();
            this.lblCardBookingsTitle = new System.Windows.Forms.Label();
            this.lblStatBookingsValue = new System.Windows.Forms.Label();
            this.pnlCardRevenue = new System.Windows.Forms.Panel();
            this.pnlCardRevenueAccent = new System.Windows.Forms.Panel();
            this.lblCardRevenueTitle = new System.Windows.Forms.Label();
            this.lblStatRevenueValue = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblSectionModules = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslApplicationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlCardFleet.SuspendLayout();
            this.pnlCardCustomers.SuspendLayout();
            this.pnlCardBookings.SuspendLayout();
            this.pnlCardRevenue.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Controls.Add(this.lblAppSubtitle);
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 96);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            //
            // lblLogo
            //
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLogo.Location = new System.Drawing.Point(20, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(50, 50);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "XR";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblAppTitle
            //
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(80, 16);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(371, 40);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "XREFS0  |  DASHBOARD";
            //
            // lblAppSubtitle
            //
            this.lblAppSubtitle.AutoSize = true;
            this.lblAppSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(83, 56);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(274, 21);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Car Rental & Fleet Management System";
            //
            // lblDateTime
            //
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.lblDateTime.Location = new System.Drawing.Point(600, 36);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(375, 25);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "—";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnlUserInfo
            //
            this.pnlUserInfo.BackColor = System.Drawing.Color.White;
            this.pnlUserInfo.Controls.Add(this.lblAvatar);
            this.pnlUserInfo.Controls.Add(this.lblUserTitle);
            this.pnlUserInfo.Controls.Add(this.lblUserValue);
            this.pnlUserInfo.Controls.Add(this.lblRoleTitle);
            this.pnlUserInfo.Controls.Add(this.lblRoleValue);
            this.pnlUserInfo.Controls.Add(this.btnLogout);
            this.pnlUserInfo.Controls.Add(this.pnlUserDivider);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 96);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(1000, 62);
            this.pnlUserInfo.TabIndex = 1;
            //
            // lblAvatar
            //
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAvatar.Location = new System.Drawing.Point(20, 12);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(38, 38);
            this.lblAvatar.TabIndex = 5;
            this.lblAvatar.Text = "A";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblUserTitle
            //
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUserTitle.Location = new System.Drawing.Point(68, 8);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(91, 19);
            this.lblUserTitle.TabIndex = 0;
            this.lblUserTitle.Text = "ACTIVE USER";
            //
            // lblUserValue
            //
            this.lblUserValue.AutoSize = true;
            this.lblUserValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblUserValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblUserValue.Location = new System.Drawing.Point(68, 27);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(24, 25);
            this.lblUserValue.TabIndex = 1;
            this.lblUserValue.Text = "—";
            //
            // lblRoleTitle
            //
            this.lblRoleTitle.AutoSize = true;
            this.lblRoleTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoleTitle.Location = new System.Drawing.Point(260, 8);
            this.lblRoleTitle.Name = "lblRoleTitle";
            this.lblRoleTitle.Size = new System.Drawing.Size(92, 19);
            this.lblRoleTitle.TabIndex = 2;
            this.lblRoleTitle.Text = "ACCESS ROLE";
            //
            // lblRoleValue
            //
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblRoleValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRoleValue.ForeColor = System.Drawing.Color.White;
            this.lblRoleValue.Location = new System.Drawing.Point(260, 29);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lblRoleValue.Size = new System.Drawing.Size(46, 25);
            this.lblRoleValue.TabIndex = 3;
            this.lblRoleValue.Text = "—";
            //
            // btnLogout
            //
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(860, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            //
            // pnlUserDivider
            //
            this.pnlUserDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlUserDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserDivider.Location = new System.Drawing.Point(0, 61);
            this.pnlUserDivider.Name = "pnlUserDivider";
            this.pnlUserDivider.Size = new System.Drawing.Size(1000, 1);
            this.pnlUserDivider.TabIndex = 6;
            //
            // pnlStats
            //
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlStats.Controls.Add(this.lblSectionOverview);
            this.pnlStats.Controls.Add(this.pnlCardFleet);
            this.pnlStats.Controls.Add(this.pnlCardCustomers);
            this.pnlStats.Controls.Add(this.pnlCardBookings);
            this.pnlStats.Controls.Add(this.pnlCardRevenue);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 158);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1000, 152);
            this.pnlStats.TabIndex = 5;
            //
            // lblSectionOverview
            //
            this.lblSectionOverview.AutoSize = true;
            this.lblSectionOverview.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSectionOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSectionOverview.Location = new System.Drawing.Point(22, 10);
            this.lblSectionOverview.Name = "lblSectionOverview";
            this.lblSectionOverview.Size = new System.Drawing.Size(158, 19);
            this.lblSectionOverview.TabIndex = 0;
            this.lblSectionOverview.Text = "BUSINESS OVERVIEW";
            //
            // pnlCardFleet
            //
            this.pnlCardFleet.BackColor = System.Drawing.Color.White;
            this.pnlCardFleet.Controls.Add(this.pnlCardFleetAccent);
            this.pnlCardFleet.Controls.Add(this.lblCardFleetTitle);
            this.pnlCardFleet.Controls.Add(this.lblStatVehiclesValue);
            this.pnlCardFleet.Location = new System.Drawing.Point(20, 36);
            this.pnlCardFleet.Name = "pnlCardFleet";
            this.pnlCardFleet.Size = new System.Drawing.Size(225, 102);
            this.pnlCardFleet.TabIndex = 1;
            //
            // pnlCardFleetAccent
            //
            this.pnlCardFleetAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlCardFleetAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardFleetAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardFleetAccent.Name = "pnlCardFleetAccent";
            this.pnlCardFleetAccent.Size = new System.Drawing.Size(225, 5);
            this.pnlCardFleetAccent.TabIndex = 0;
            //
            // lblCardFleetTitle
            //
            this.lblCardFleetTitle.AutoSize = true;
            this.lblCardFleetTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardFleetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardFleetTitle.Location = new System.Drawing.Point(14, 14);
            this.lblCardFleetTitle.Name = "lblCardFleetTitle";
            this.lblCardFleetTitle.Size = new System.Drawing.Size(146, 20);
            this.lblCardFleetTitle.TabIndex = 1;
            this.lblCardFleetTitle.Text = "FLEET VEHICLES";
            //
            // lblStatVehiclesValue
            //
            this.lblStatVehiclesValue.AutoSize = true;
            this.lblStatVehiclesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatVehiclesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatVehiclesValue.Location = new System.Drawing.Point(12, 40);
            this.lblStatVehiclesValue.Name = "lblStatVehiclesValue";
            this.lblStatVehiclesValue.Size = new System.Drawing.Size(42, 46);
            this.lblStatVehiclesValue.TabIndex = 2;
            this.lblStatVehiclesValue.Text = "–";
            //
            // pnlCardCustomers
            //
            this.pnlCardCustomers.BackColor = System.Drawing.Color.White;
            this.pnlCardCustomers.Controls.Add(this.pnlCardCustomersAccent);
            this.pnlCardCustomers.Controls.Add(this.lblCardCustomersTitle);
            this.pnlCardCustomers.Controls.Add(this.lblStatCustomersValue);
            this.pnlCardCustomers.Location = new System.Drawing.Point(260, 36);
            this.pnlCardCustomers.Name = "pnlCardCustomers";
            this.pnlCardCustomers.Size = new System.Drawing.Size(225, 102);
            this.pnlCardCustomers.TabIndex = 2;
            //
            // pnlCardCustomersAccent
            //
            this.pnlCardCustomersAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.pnlCardCustomersAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardCustomersAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardCustomersAccent.Name = "pnlCardCustomersAccent";
            this.pnlCardCustomersAccent.Size = new System.Drawing.Size(225, 5);
            this.pnlCardCustomersAccent.TabIndex = 0;
            //
            // lblCardCustomersTitle
            //
            this.lblCardCustomersTitle.AutoSize = true;
            this.lblCardCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardCustomersTitle.Location = new System.Drawing.Point(14, 14);
            this.lblCardCustomersTitle.Name = "lblCardCustomersTitle";
            this.lblCardCustomersTitle.Size = new System.Drawing.Size(132, 20);
            this.lblCardCustomersTitle.TabIndex = 1;
            this.lblCardCustomersTitle.Text = "CUSTOMERS";
            //
            // lblStatCustomersValue
            //
            this.lblStatCustomersValue.AutoSize = true;
            this.lblStatCustomersValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatCustomersValue.Location = new System.Drawing.Point(12, 40);
            this.lblStatCustomersValue.Name = "lblStatCustomersValue";
            this.lblStatCustomersValue.Size = new System.Drawing.Size(42, 46);
            this.lblStatCustomersValue.TabIndex = 2;
            this.lblStatCustomersValue.Text = "–";
            //
            // pnlCardBookings
            //
            this.pnlCardBookings.BackColor = System.Drawing.Color.White;
            this.pnlCardBookings.Controls.Add(this.pnlCardBookingsAccent);
            this.pnlCardBookings.Controls.Add(this.lblCardBookingsTitle);
            this.pnlCardBookings.Controls.Add(this.lblStatBookingsValue);
            this.pnlCardBookings.Location = new System.Drawing.Point(500, 36);
            this.pnlCardBookings.Name = "pnlCardBookings";
            this.pnlCardBookings.Size = new System.Drawing.Size(225, 102);
            this.pnlCardBookings.TabIndex = 3;
            //
            // pnlCardBookingsAccent
            //
            this.pnlCardBookingsAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.pnlCardBookingsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardBookingsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardBookingsAccent.Name = "pnlCardBookingsAccent";
            this.pnlCardBookingsAccent.Size = new System.Drawing.Size(225, 5);
            this.pnlCardBookingsAccent.TabIndex = 0;
            //
            // lblCardBookingsTitle
            //
            this.lblCardBookingsTitle.AutoSize = true;
            this.lblCardBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardBookingsTitle.Location = new System.Drawing.Point(14, 14);
            this.lblCardBookingsTitle.Name = "lblCardBookingsTitle";
            this.lblCardBookingsTitle.Size = new System.Drawing.Size(166, 20);
            this.lblCardBookingsTitle.TabIndex = 1;
            this.lblCardBookingsTitle.Text = "ACTIVE BOOKINGS";
            //
            // lblStatBookingsValue
            //
            this.lblStatBookingsValue.AutoSize = true;
            this.lblStatBookingsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatBookingsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatBookingsValue.Location = new System.Drawing.Point(12, 40);
            this.lblStatBookingsValue.Name = "lblStatBookingsValue";
            this.lblStatBookingsValue.Size = new System.Drawing.Size(42, 46);
            this.lblStatBookingsValue.TabIndex = 2;
            this.lblStatBookingsValue.Text = "–";
            //
            // pnlCardRevenue
            //
            this.pnlCardRevenue.BackColor = System.Drawing.Color.White;
            this.pnlCardRevenue.Controls.Add(this.pnlCardRevenueAccent);
            this.pnlCardRevenue.Controls.Add(this.lblCardRevenueTitle);
            this.pnlCardRevenue.Controls.Add(this.lblStatRevenueValue);
            this.pnlCardRevenue.Location = new System.Drawing.Point(740, 36);
            this.pnlCardRevenue.Name = "pnlCardRevenue";
            this.pnlCardRevenue.Size = new System.Drawing.Size(225, 102);
            this.pnlCardRevenue.TabIndex = 4;
            //
            // pnlCardRevenueAccent
            //
            this.pnlCardRevenueAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.pnlCardRevenueAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardRevenueAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardRevenueAccent.Name = "pnlCardRevenueAccent";
            this.pnlCardRevenueAccent.Size = new System.Drawing.Size(225, 5);
            this.pnlCardRevenueAccent.TabIndex = 0;
            //
            // lblCardRevenueTitle
            //
            this.lblCardRevenueTitle.AutoSize = true;
            this.lblCardRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardRevenueTitle.Location = new System.Drawing.Point(14, 14);
            this.lblCardRevenueTitle.Name = "lblCardRevenueTitle";
            this.lblCardRevenueTitle.Size = new System.Drawing.Size(142, 20);
            this.lblCardRevenueTitle.TabIndex = 1;
            this.lblCardRevenueTitle.Text = "TOTAL REVENUE";
            //
            // lblStatRevenueValue
            //
            this.lblStatRevenueValue.AutoSize = true;
            this.lblStatRevenueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatRevenueValue.Location = new System.Drawing.Point(12, 40);
            this.lblStatRevenueValue.Name = "lblStatRevenueValue";
            this.lblStatRevenueValue.Size = new System.Drawing.Size(42, 46);
            this.lblStatRevenueValue.TabIndex = 2;
            this.lblStatRevenueValue.Text = "–";
            //
            // pnlMainMenu
            //
            this.pnlMainMenu.BackColor = System.Drawing.Color.White;
            this.pnlMainMenu.Controls.Add(this.lblSectionModules);
            this.pnlMainMenu.Controls.Add(this.btnCustomers);
            this.pnlMainMenu.Controls.Add(this.btnVehicles);
            this.pnlMainMenu.Controls.Add(this.btnBookings);
            this.pnlMainMenu.Controls.Add(this.btnReturns);
            this.pnlMainMenu.Controls.Add(this.btnTransactions);
            this.pnlMainMenu.Controls.Add(this.btnMaintenance);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 310);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1000, 292);
            this.pnlMainMenu.TabIndex = 2;
            //
            // lblSectionModules
            //
            this.lblSectionModules.AutoSize = true;
            this.lblSectionModules.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSectionModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSectionModules.Location = new System.Drawing.Point(55, 10);
            this.lblSectionModules.Name = "lblSectionModules";
            this.lblSectionModules.Size = new System.Drawing.Size(79, 19);
            this.lblSectionModules.TabIndex = 6;
            this.lblSectionModules.Text = "MODULES";
            //
            // btnCustomers
            //
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCustomers.FlatAppearance.BorderSize = 2;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCustomers.Location = new System.Drawing.Point(55, 38);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(280, 105);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Tag = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCustomers.Text = "Customers\r\nManage clients && profiles";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnCustomers.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            //
            // btnVehicles
            //
            this.btnVehicles.BackColor = System.Drawing.Color.White;
            this.btnVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnVehicles.FlatAppearance.BorderSize = 2;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnVehicles.Location = new System.Drawing.Point(360, 38);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(280, 105);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Tag = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnVehicles.Text = "Vehicles\r\nFleet && availability";
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            this.btnVehicles.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnVehicles.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            //
            // btnBookings
            //
            this.btnBookings.BackColor = System.Drawing.Color.White;
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnBookings.FlatAppearance.BorderSize = 2;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBookings.Location = new System.Drawing.Point(665, 38);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(280, 105);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Tag = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnBookings.Text = "Bookings\r\nReservations && rentals";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            this.btnBookings.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnBookings.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            //
            // btnReturns
            //
            this.btnReturns.BackColor = System.Drawing.Color.White;
            this.btnReturns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturns.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnReturns.FlatAppearance.BorderSize = 2;
            this.btnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReturns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnReturns.Location = new System.Drawing.Point(55, 158);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(280, 105);
            this.btnReturns.TabIndex = 3;
            this.btnReturns.Tag = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnReturns.Text = "Returns\r\nCheck-ins && mileage";
            this.btnReturns.UseVisualStyleBackColor = false;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            this.btnReturns.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnReturns.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            //
            // btnTransactions
            //
            this.btnTransactions.BackColor = System.Drawing.Color.White;
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnTransactions.FlatAppearance.BorderSize = 2;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTransactions.Location = new System.Drawing.Point(360, 158);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(280, 105);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Tag = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnTransactions.Text = "Transactions\r\nPayments && invoices";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            this.btnTransactions.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnTransactions.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            //
            // btnMaintenance
            //
            this.btnMaintenance.BackColor = System.Drawing.Color.White;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnMaintenance.FlatAppearance.BorderSize = 2;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnMaintenance.Location = new System.Drawing.Point(665, 158);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(280, 105);
            this.btnMaintenance.TabIndex = 5;
            this.btnMaintenance.Tag = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnMaintenance.Text = "Maintenance\r\nService && repairs";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            this.btnMaintenance.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnMaintenance.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFooter.Controls.Add(this.lblVersion);
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 602);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1000, 52);
            this.pnlFooter.TabIndex = 3;
            //
            // lblVersion
            //
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblVersion.Location = new System.Drawing.Point(22, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(158, 19);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v1.0";
            //
            // btnExit
            //
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(860, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            //
            // stsStatusBar
            //
            this.stsStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.stsStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslApplicationStatus,
            this.tsslSeparator,
            this.tsslUserStatus});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 654);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1000, 26);
            this.stsStatusBar.TabIndex = 4;
            this.stsStatusBar.Text = "statusBar";
            //
            // tsslApplicationStatus
            //
            this.tsslApplicationStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.tsslApplicationStatus.Name = "tsslApplicationStatus";
            this.tsslApplicationStatus.Size = new System.Drawing.Size(128, 20);
            this.tsslApplicationStatus.Text = "XREFS0 Car Rental";
            //
            // tsslSeparator
            //
            this.tsslSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.tsslSeparator.Name = "tsslSeparator";
            this.tsslSeparator.Size = new System.Drawing.Size(13, 20);
            this.tsslSeparator.Text = "|";
            //
            // tsslUserStatus
            //
            this.tsslUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.tsslUserStatus.Name = "tsslUserStatus";
            this.tsslUserStatus.Size = new System.Drawing.Size(50, 20);
            this.tsslUserStatus.Text = "Ready";
            //
            // timerDateTime
            //
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XREFS0 Car Rental";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlCardFleet.ResumeLayout(false);
            this.pnlCardFleet.PerformLayout();
            this.pnlCardCustomers.ResumeLayout(false);
            this.pnlCardCustomers.PerformLayout();
            this.pnlCardBookings.ResumeLayout(false);
            this.pnlCardBookings.PerformLayout();
            this.pnlCardRevenue.ResumeLayout(false);
            this.pnlCardRevenue.PerformLayout();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Label lblDateTime;

        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.Label lblRoleTitle;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlUserDivider;

        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblSectionOverview;
        private System.Windows.Forms.Panel pnlCardFleet;
        private System.Windows.Forms.Panel pnlCardFleetAccent;
        private System.Windows.Forms.Label lblCardFleetTitle;
        private System.Windows.Forms.Label lblStatVehiclesValue;
        private System.Windows.Forms.Panel pnlCardCustomers;
        private System.Windows.Forms.Panel pnlCardCustomersAccent;
        private System.Windows.Forms.Label lblCardCustomersTitle;
        private System.Windows.Forms.Label lblStatCustomersValue;
        private System.Windows.Forms.Panel pnlCardBookings;
        private System.Windows.Forms.Panel pnlCardBookingsAccent;
        private System.Windows.Forms.Label lblCardBookingsTitle;
        private System.Windows.Forms.Label lblStatBookingsValue;
        private System.Windows.Forms.Panel pnlCardRevenue;
        private System.Windows.Forms.Panel pnlCardRevenueAccent;
        private System.Windows.Forms.Label lblCardRevenueTitle;
        private System.Windows.Forms.Label lblStatRevenueValue;

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Label lblSectionModules;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnMaintenance;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslApplicationStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserStatus;

        private System.Windows.Forms.Timer timerDateTime;
    }
}
