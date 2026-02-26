using System.Windows.Forms;
using System.Drawing;

namespace PhishingAdminPanel
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            this.BackColor = Color.White;

            Label lbl = new Label();
            lbl.Text = "Settings";
            lbl.Font = new Font("Segoe UI", 20);
            lbl.Location = new Point(20, 20);

            this.Controls.Add(lbl);
        }
    }
}
