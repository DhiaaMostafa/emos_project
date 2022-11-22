using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.interface_view
{
    public partial class menu_prime : Form
    {
        BL.cls_counter cls_count = new BL.cls_counter();

        public menu_prime()
        {
            InitializeComponent();
            
        }

        bin.form_main frm_main = new bin.form_main();
        private void button8_Click(object sender, EventArgs e)
        {
            frm_main.btncust_Click(sender, e);
        }

        private void circular_panel1_Paint(object sender, PaintEventArgs e)
        {
            frm_main.abirforminpanel(new select_cust());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void menu_prime_Load(object sender, EventArgs e)
        {
            lbl_cust_count.Text = cls_count.Get_All_Customer_Counts().ToString();
            lbl_build_count.Text = cls_count.Get_All_Build_Counts().ToString();
            lbl_unit_count.Text = cls_count.Get_All_Unit_Counts().ToString();
            lbl_land_count.Text = cls_count.Get_All_Land_Counts().ToString();
            lbl_lease_build_count.Text = cls_count.Get_All_Lease_Build_Counts().ToString();
            lbl_lease_unit_count.Text = cls_count.Get_All_Lease_Unit_Counts().ToString();
            lbl_lease_land_count.Text = cls_count.Get_All_Lease_Land_Counts().ToString();


            
            lbl_date.Text = System.DateTime.Now.ToString("dd/MM/yyyy");


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("T");
        }

   
    }
}
