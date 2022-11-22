using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.BuildingInterface.Interface_updateData
{
    public partial class Update_Build_Request_Rent : Form
    {
        public Update_Build_Request_Rent()
        {
            InitializeComponent();
        }
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

        private void Update_Build_Request_Rent_Load(object sender, EventArgs e)
        {

            int build_Id = Convert.ToInt16(dgv_request_rent_info.Rows[0].Cells[0].Value.ToString());
            int count = cls_building.B_Get_Count_Build_In_Lease(build_Id);

            if (count > 0)
            {
                txt_order_type.Visible = true;
                cmb_order_type.Visible = false;

            }
            else
                if (count == 0)
                {
                    cmb_order_type.Visible = true;
                    txt_order_type.Visible = false;

                }


            cmb_build_conservatism.DataSource = cls_building.B_Get_All_Cust_Conservatism();
            cmb_build_conservatism.DisplayMember = "conservatism";
            cmb_build_conservatism.ValueMember = "conservatism";

            txt_cust_name.Text = dgv_request_rent_info.Rows[0].Cells[1].Value.ToString();
            txt_build_name.Text = dgv_request_rent_info.Rows[0].Cells[2].Value.ToString();
            cmb_build_conservatism.Text = dgv_request_rent_info.Rows[0].Cells[3].Value.ToString();
            cmb_build_city.Text = dgv_request_rent_info.Rows[0].Cells[4].Value.ToString();
            txt_build_square.Text = dgv_request_rent_info.Rows[0].Cells[5].Value.ToString();
            txt_build_street.Text = dgv_request_rent_info.Rows[0].Cells[6].Value.ToString();
            txt_build_price.Text = dgv_request_rent_info.Rows[0].Cells[7].Value.ToString();
            cmb_build_type.Text = dgv_request_rent_info.Rows[0].Cells[8].Value.ToString();
            cmb_build_state.Text = dgv_request_rent_info.Rows[0].Cells[9].Value.ToString();
            txt_build_area.Text = dgv_request_rent_info.Rows[0].Cells[10].Value.ToString();

            txt_order_type.Text = dgv_request_rent_info.Rows[0].Cells[11].Value.ToString();
            cmb_order_type.Text = dgv_request_rent_info.Rows[0].Cells[11].Value.ToString();

            cmb_order_state.Text = dgv_request_rent_info.Rows[0].Cells[12].Value.ToString();
            txt_build_note.Text = dgv_request_rent_info.Rows[0].Cells[13].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_build_conservatism_TextChanged(object sender, EventArgs e)
        {
            cmb_build_city.DataSource = cls_building.B_Get_All_Customer_City(1 + int.Parse(cmb_build_conservatism.SelectedIndex.ToString()));
            cmb_build_city.DisplayMember = "city";
            cmb_build_city.ValueMember = "city";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //PL.userinterface.interface_update.update_customer update_cust = new userinterface.interface_update.update_customer();
            //update_cust.ShowDialog();
        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {
            string order_type = "";

            if (cmb_order_type.Visible == true)
            {
                order_type = cmb_order_type.Text;
            }
            else
                if (txt_order_type.Visible == true)
                {
                    order_type = txt_order_type.Text;
                }

            int build_Id=Convert.ToInt32( dgv_request_rent_info.Rows[0].Cells[0].Value.ToString());
            cls_building.B_Update_Request_Rent(build_Id, txt_build_name.Text, cmb_build_conservatism.Text, cmb_build_city.Text, txt_build_square.Text, txt_build_street.Text,
                                      txt_build_price.Text, cmb_build_type.Text, cmb_build_state.Text, txt_build_area.Text, order_type, cmb_order_state.Text, txt_build_note.Text);
            MessageBox.Show("تم تعديل طلب التاجير بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
