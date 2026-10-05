using XREFS0Business;
using XREFS0CarRental.Booking;
using XREFS0CarRental.Return;
using XREFS0CarRental.Transaction;
using XREFS0CarRental.Maintenance;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace XREFS0CarRental
{
    public partial class frmMain : Form
    {
        private static readonly Color CardBorderIdle = Color.FromArgb(226, 232, 240);
        private static readonly Color CardBackIdle = Color.White;
        private static readonly Color CardForeIdle = Color.FromArgb(30, 41, 59);
        private static readonly Color CardBackHover = Color.FromArgb(239, 246, 255);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string username = "Guest";
            string role = "Viewer";

            if (frmLogin.CurrentUser != null)
            {
                username = frmLogin.CurrentUser.Username;
                role = frmLogin.CurrentUser.Role;
            }

            lblUserValue.Text = username;
            lblRoleValue.Text = role;
            tsslUserStatus.Text = $"Logged in as: {username}";

            lblAvatar.Text = username.Substring(0, 1).ToUpper();
            MakeCircular(lblAvatar);
            MakeCircular(lblLogo);
            ApplyModuleBadges();

            UpdateDateTime();
            LoadStats();
        }

        private void MakeCircular(Control control)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(0, 0, control.Width, control.Height);
                control.Region = new Region(path);
            }
        }

        private void ApplyModuleBadges()
        {
            SetBadge(btnCustomers, "C");
            SetBadge(btnVehicles, "V");
            SetBadge(btnBookings, "B");
            SetBadge(btnReturns, "R");
            SetBadge(btnTransactions, "T");
            SetBadge(btnMaintenance, "M");
        }

        private void SetBadge(Button btn, string letter)
        {
            Color accent = btn.Tag is Color c ? c : Color.FromArgb(37, 99, 235);
            btn.Image = MakeBadge(letter, accent);
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(24, 0, 0, 0);
        }

        private static Image MakeBadge(string letter, Color backColor)
        {
            const int size = 46;
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (Brush brush = new SolidBrush(backColor))
                {
                    g.FillEllipse(brush, 1, 1, size - 2, size - 2);
                }
                using (Font font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Pixel))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(letter, font, textBrush, new RectangleF(0, 1, size, size), format);
                }
            }
            return bmp;
        }

        private void LoadStats()
        {
            try
            {
                int totalVehicles = clsVehicle.ListVehicles().Rows.Count;
                int availableVehicles = clsVehicle.GetAvailableVehicles().Rows.Count;
                lblStatVehiclesValue.Text = $"{availableVehicles} / {totalVehicles}";

                lblStatCustomersValue.Text = clsCustomer.ListCustomers().Rows.Count.ToString();

                lblStatBookingsValue.Text = clsBooking.ListActiveBookings().Rows.Count.ToString();

                decimal revenue = 0;
                foreach (DataRow row in clsTransaction.ListTransactions().Rows)
                {
                    if (row["PaidAmount"] != DBNull.Value)
                        revenue += Convert.ToDecimal(row["PaidAmount"]);
                }
                lblStatRevenueValue.Text = revenue.ToString("C0");
            }
            catch
            {
                // Stats are informational only - never break the dashboard.
            }
        }

        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy  |  hh:mm:ss tt");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using (frmListCustomers frm = new frmListCustomers())
            {
                frm.ShowDialog();
            }
            LoadStats();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            using (frmListVehicles frm = new frmListVehicles())
            {
                frm.ShowDialog();
            }
            LoadStats();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            using (frmListBooking frm = new frmListBooking())
            {
                frm.ShowDialog();
            }
            LoadStats();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            using (frmListReturns frm = new frmListReturns())
            {
                frm.ShowDialog();
            }
            LoadStats();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            using (frmListTransactions frm = new frmListTransactions())
            {
                frm.ShowDialog();
            }
            LoadStats();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            using (frmListMaintenance frm = new frmListMaintenance())
            {
                frm.ShowDialog();
            }
            LoadStats();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                pnlHeader.ClientRectangle,
                System.Drawing.Color.FromArgb(15, 23, 42),
                System.Drawing.Color.FromArgb(30, 58, 138),
                0F))
            {
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
            }

            using (System.Drawing.SolidBrush lineBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(245, 158, 11)))
            {
                e.Graphics.FillRectangle(lineBrush, 0, pnlHeader.Height - 3, pnlHeader.Width, 3);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(10, 255, 255, 255), 1.5F))
            {
                e.Graphics.DrawEllipse(pen, pnlHeader.Width - 180, -90, 220, 220);
                e.Graphics.DrawEllipse(pen, pnlHeader.Width - 140, -50, 140, 140);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Color accent = btn.Tag is Color c ? c : Color.FromArgb(37, 99, 235);

            btn.BackColor = CardBackHover;
            btn.ForeColor = Color.FromArgb(15, 23, 42);
            btn.FlatAppearance.BorderColor = accent;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = CardBackIdle;
            btn.ForeColor = CardForeIdle;
            btn.FlatAppearance.BorderColor = CardBorderIdle;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(51, 65, 85);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(30, 41, 59);
        }


    }
}
