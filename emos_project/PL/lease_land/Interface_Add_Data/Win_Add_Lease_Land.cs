using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.lease_land.Interface_Add_Data
{
    public partial class Win_Add_Lease_Land : Form
    {
        BL.cls_lease_land.cls_lease_land cls_lease_land = new BL.cls_lease_land.cls_lease_land();
        public Win_Add_Lease_Land()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {
            cls_lease_land.Land_Les_Add_Lease_Land(Convert.ToInt32(cmb_cust_name.SelectedValue.ToString()), Convert.ToInt32(cmb_land_name.SelectedValue.ToString()), dtp_lease_write_date.Value.ToString(), dtp_lease_start_date.Value.ToString(), dtp_lease_end_date.Value.ToString(), txt_total_money.Text, txt_payed_money.Text, txt_inst_money.Text, dtp_date_pay_money.Value.ToString(), txt_clusing_percentage.Text, txt_estate_percentage.Text, cmb_pay_type.Text, txt_wat1.Text, txt_wat2.Text, txt_lease_type.Text, txt_note.Text);
            MessageBox.Show("تم اضافة العقد  بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
