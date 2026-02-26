namespace PhishingAdminPanel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel mainPanel;

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCampaigns;
        private System.Windows.Forms.Button btnTemplates;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();

            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCampaigns = new System.Windows.Forms.Button();
            this.btnTemplates = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // SIDEBAR
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Width = 200;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);

            // HEADER
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Height = 60;
            this.header.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);

            // MAIN PANEL
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.BackColor = System.Drawing.Color.White;

            // BUTTON STYLE HELPER
            void StyleButton(System.Windows.Forms.Button b, string text)
            {
                b.Text = text;
                b.Dock = System.Windows.Forms.DockStyle.Top;
                b.Height = 50;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.ForeColor = System.Drawing.Color.White;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            }

            StyleButton(btnDashboard, "Dashboard");
            StyleButton(btnCampaigns, "Campaigns");
            StyleButton(btnTemplates, "Templates");
            StyleButton(btnUsers, "Users");
            StyleButton(btnReports, "Reports");
            StyleButton(btnSettings, "Settings");

            // ADD BUTTONS TO SIDEBAR
            this.sidebar.Controls.Add(btnSettings);
            this.sidebar.Controls.Add(btnReports);
            this.sidebar.Controls.Add(btnUsers);
            this.sidebar.Controls.Add(btnTemplates);
            this.sidebar.Controls.Add(btnCampaigns);
            this.sidebar.Controls.Add(btnDashboard);

            // ADD PANELS TO FORM
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);

            // BUTTON EVENTS
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnCampaigns.Click += new System.EventHandler(this.btnCampaigns_Click);
            this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // FORM SETTINGS
            this.Text = "Phishing Simulator Admin Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.ResumeLayout(false);
        }
    }
}
