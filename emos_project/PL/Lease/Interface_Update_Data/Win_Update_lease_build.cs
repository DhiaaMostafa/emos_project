using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.Lease.Interface_Update_Data
{
    public partial class Win_Update_lease_build : Form
    {
        BL.cls_lease_build.cls_lease_build cls_lease_build = new BL.cls_lease_build.cls_lease_build();
        public Win_Update_lease_build()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Win_Update_lease_build_Load(object sender, EventArgs e)
        {
            txt_cust_name.Text = dgv_update_lease_build.Rows[0].Cells[1].Value.ToString();
            cmb_build_name.Text = dgv_update_lease_build.Rows[0].Cells[2].Value.ToString();
            cmb_unit_name.Text = dgv_update_lease_build.Rows[0].Cells[3].Value.ToString();
            dtp_lease_write_date.Text = dgv_update_lease_build.Rows[0].Cells[4].Value.ToString();
            dtp_lease_start_date.Text = dgv_update_lease_build.Rows[0].Cells[5].Value.ToString();
            dtp_lease_end_date.Text = dgv_update_lease_build.Rows[0].Cells[6].Value.ToString();
            txt_total_money.Text = dgv_update_lease_build.Rows[0].Cells[7].Value.ToString();
            txt_payed_money.Text = dgv_update_lease_build.Rows[0].Cells[8].Value.ToString();
            txt_inst_money.Text = dgv_update_lease_build.Rows[0].Cells[9].Value.ToString();
            dtp_date_pay_money.Text = dgv_update_lease_build.Rows[0].Cells[10].Value.ToString();
            txt_clusing_percentage.Text = dgv_update_lease_build.Rows[0].Cells[11].Value.ToString();
            txt_estate_percentage.Text = dgv_update_lease_build.Rows[0].Cells[12].Value.ToString();
            cmb_pay_type.Text = dgv_update_lease_build.Rows[0].Cells[13].Value.ToString();
            txt_wat1.Text = dgv_update_lease_build.Rows[0].Cells[14].Value.ToString();
            txt_wat2.Text = dgv_update_lease_build.Rows[0].Cells[15].Value.ToString();
            txt_lease_type.Text = dgv_update_lease_build.Rows[0].Cells[16].Value.ToString();
            txt_note.Text = dgv_update_lease_build.Rows[0].Cells[17].Value.ToString();
        }

        private void cmb_build_name_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmb_build_name.SelectedIndex == 0)
            {

            }
            else
            {

                string x = cmb_build_name.SelectedValue.ToString();
                cmb_unit_name.DataSource = cls_lease_build.Les_Get_All_Unit_Name(Convert.ToInt32(x));
                cmb_unit_name.DisplayMember = "unit_name";
                cmb_unit_name.ValueMember = "Id";
            }
        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {
            int lease_Id=Convert.ToInt16( this.dgv_update_lease_build.Rows[0].Cells[0].Value.ToString());
            cls_lease_build.Les_Update_Lease_Build(lease_Id, Convert.ToInt32(cmb_build_name.SelectedValue.ToString()), Convert.ToInt32(cmb_unit_name.SelectedValue.ToString()), dtp_lease_write_date.Value.ToString(), dtp_lease_start_date.Value.ToString(), dtp_lease_end_date.Value.ToString(), txt_total_money.Text, txt_payed_money.Text, txt_inst_money.Text, dtp_date_pay_money.Value.ToString(), txt_clusing_percentage.Text, txt_estate_percentage.Text, cmb_pay_type.Text, txt_wat1.Text, txt_wat2.Text, txt_lease_type.Text, txt_note.Text);

            MessageBox.Show("تم تعديل العقد  بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
