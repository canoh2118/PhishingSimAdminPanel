using System.Windows.Forms;
using System.Drawing;

namespace PhishingAdminPanel
{
    public partial class CampaignsControl : UserControl
    {
        public CampaignsControl()
        {
            InitializeComponent();

            this.BackColor = Color.White;

            Label lbl = new Label();
            lbl.Text = "Campaigns";
            lbl.Font = new Font("Segoe UI", 20);
            lbl.Location = new Point(20, 20);

            this.Controls.Add(lbl);
        }
    }
}
