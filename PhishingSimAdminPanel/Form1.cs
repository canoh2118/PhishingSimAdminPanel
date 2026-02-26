using System;
using System.Windows.Forms;

namespace PhishingAdminPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        private void btnCampaigns_Click(object sender, EventArgs e)
        {
            LoadControl(new CampaignsControl());
        }

        private void btnTemplates_Click(object sender, EventArgs e)
        {
            LoadControl(new TemplatesControl());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadControl(new UsersControl());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadControl(new ReportsControl());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadControl(new SettingsControl());
        }
    }
}

