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
    public partial class report_customer : Form
    {
        public report_customer()
        {
            InitializeComponent();
        }
        BL.cls_reporting.cls_report cls_report = new BL.cls_reporting.cls_report();
        private void report_customer_Load(object sender, EventArgs e)
        {




        }

        private void cmb_cust_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cust_name.SelectedIndex <= -1)
            {
                return;
            }
        }

        private void cmb_cust_name_Click(object sender, EventArgs e)
        {
            cmb_cust_name.DataSource = cls_report.Rep_Get_All_Cust_Name();
            cmb_cust_name.DisplayMember = "cust_name";
            cmb_cust_name.ValueMember = "Id";

        }

        private void cmb_cust_type_Click(object sender, EventArgs e)
        {
            cmb_cust_type.DataSource = cls_report.Rep_Get_All_Cust_Type();
            cmb_cust_type.DisplayMember = "type_name";
            cmb_cust_type.ValueMember = "Id";
        }

        private void cmb_conservatism_Click(object sender, EventArgs e)
        {
            cmb_conservatism.DataSource = cls_report.Rep_Get_All_Cust_Conservatism();
            cmb_conservatism.DisplayMember = "conservatism";
            cmb_conservatism.ValueMember = "Id";

        }
    }
}
