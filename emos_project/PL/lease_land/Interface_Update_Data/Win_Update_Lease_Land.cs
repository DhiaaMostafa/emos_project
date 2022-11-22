using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.lease_land.Interface_Update_Data
{
    public partial class Win_Update_Lease_Land : Form
    {
        BL.cls_lease_land.cls_lease_land cls_lease_land = new BL.cls_lease_land.cls_lease_land();
        public Win_Update_Lease_Land()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Win_Update_Lease_Land_Load(object sender, EventArgs e)
        {
            txt_cust_name.Text = dgv_update_lease_land.Rows[0].Cells[1].Value.ToString();
            cmb_land_name.Text = dgv_update_lease_land.Rows[0].Cells[2].Value.ToString();
            dtp_lease_write_date.Text = dgv_update_lease_land.Rows[0].Cells[3].Value.ToString();
            dtp_lease_start_date.Text = dgv_update_lease_land.Rows[0].Cells[4].Value.ToString();
            dtp_lease_end_date.Text = dgv_update_lease_land.Rows[0].Cells[5].Value.ToString();
            txt_total_money.Text = dgv_update_lease_land.Rows[0].Cells[6].Value.ToString();
            txt_payed_money.Text = dgv_update_lease_land.Rows[0].Cells[7].Value.ToString();
            txt_inst_money.Text = dgv_update_lease_land.Rows[0].Cells[8].Value.ToString();
            dtp_date_pay_money.Text = dgv_update_lease_land.Rows[0].Cells[9].Value.ToString();
            txt_clusing_percentage.Text = dgv_update_lease_land.Rows[0].Cells[10].Value.ToString();
            txt_estate_percentage.Text = dgv_update_lease_land.Rows[0].Cells[11].Value.ToString();
            cmb_pay_type.Text = dgv_update_lease_land.Rows[0].Cells[12].Value.ToString();
            txt_wat1.Text = dgv_update_lease_land.Rows[0].Cells[13].Value.ToString();
            txt_wat2.Text = dgv_update_lease_land.Rows[0].Cells[14].Value.ToString();
            txt_lease_type.Text = dgv_update_lease_land.Rows[0].Cells[15].Value.ToString();
            txt_note.Text = dgv_update_lease_land.Rows[0].Cells[16].Value.ToString();
        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {
            int lease_Id = Convert.ToInt16(this.dgv_update_lease_land.Rows[0].Cells[0].Value.ToString());
            cls_lease_land.Land_Les_Update_Lease_Land(lease_Id,Convert.ToInt32(cmb_land_name.SelectedValue.ToString()), dtp_lease_write_date.Value.ToString(), dtp_lease_start_date.Value.ToString(), dtp_lease_end_date.Value.ToString(), txt_total_money.Text, txt_payed_money.Text, txt_inst_money.Text, dtp_date_pay_money.Value.ToString(), txt_clusing_percentage.Text, txt_estate_percentage.Text, cmb_pay_type.Text, txt_wat1.Text, txt_wat2.Text, txt_lease_type.Text, txt_note.Text);

            MessageBox.Show("تم تعديل العقد  بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
