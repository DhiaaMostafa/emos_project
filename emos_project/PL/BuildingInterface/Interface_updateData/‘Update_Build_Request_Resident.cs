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
    public partial class Update_Build_Request_Resident : Form
    {
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

        public Update_Build_Request_Resident()
        {
            InitializeComponent();
        }
        private void Update_Build_Request_Resident_Load(object sender, EventArgs e)
        {

            int build_Id = Convert.ToInt16(dgv_request_resident_info.Rows[0].Cells[0].Value.ToString());
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

            txt_cust_name.Text = dgv_request_resident_info.Rows[0].Cells[1].Value.ToString();
            txt_build_name.Text = dgv_request_resident_info.Rows[0].Cells[2].Value.ToString();
            cmb_build_conservatism.Text = dgv_request_resident_info.Rows[0].Cells[3].Value.ToString();
            cmb_build_city.Text = dgv_request_resident_info.Rows[0].Cells[4].Value.ToString();
            txt_build_square.Text = dgv_request_resident_info.Rows[0].Cells[5].Value.ToString();
            txt_build_street.Text = dgv_request_resident_info.Rows[0].Cells[6].Value.ToString();
            txt_build_price.Text = dgv_request_resident_info.Rows[0].Cells[7].Value.ToString();
            cmb_build_type.Text = dgv_request_resident_info.Rows[0].Cells[8].Value.ToString();
            txt_build_area.Text = dgv_request_resident_info.Rows[0].Cells[10].Value.ToString();

            txt_order_type.Text = dgv_request_resident_info.Rows[0].Cells[11].Value.ToString();
            cmb_order_type.Text = dgv_request_resident_info.Rows[0].Cells[11].Value.ToString();

            cmb_order_state.Text = dgv_request_resident_info.Rows[0].Cells[12].Value.ToString();
            txt_order_state.Text = cmb_order_state.Text;

            txt_build_note.Text = dgv_request_resident_info.Rows[0].Cells[13].Value.ToString();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
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

            int build_Id = Convert.ToInt32(dgv_request_resident_info.Rows[0].Cells[0].Value.ToString());
            cls_building.B_Update_Request_Resident(build_Id, cmb_build_conservatism.Text, cmb_build_city.Text, txt_build_square.Text, txt_build_street.Text,
                                      txt_build_price.Text, cmb_build_type.Text, txt_build_area.Text, order_type, cmb_order_state.Text, txt_build_note.Text,txt_build_name.Text);
            MessageBox.Show("تم تعديل طلب الاستاجار بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
