using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.Reporting
{
    public partial class Win_Report_All : Form
    {
        public Win_Report_All()
        {
            InitializeComponent();
        }


        public void abirforminpanel(object formhijo)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_all_lease_land_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            abirforminpanel(new report_customer());
        }

        private void Win_Report_All_Load(object sender, EventArgs e)
        {
            abirforminpanel(new report_customer());
        }
    }
}
