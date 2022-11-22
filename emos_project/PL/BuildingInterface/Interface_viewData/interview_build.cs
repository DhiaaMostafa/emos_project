using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace emos_project.PL.BuildingInterface.Interface_viewData
{
    public partial class interview_build : Form
    {
        public interview_build()
        {
            InitializeComponent();
        }

        BL.cls_building.cls_unit cls_unit = new BL.cls_building.cls_unit();
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();


        int build_id;

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void interview_build_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void interview_build_Load_1(object sender, EventArgs e)
        {

            build_id = Convert.ToInt32(dgv_build_info.Rows[0].Cells[0].Value.ToString());
            lbl_build_id.Text = build_id.ToString();
            txt_build_name.Text = dgv_build_info.Rows[0].Cells[1].Value.ToString();
            txt_build_conservatism.Text = dgv_build_info.Rows[0].Cells[2].Value.ToString();
            txt_build_city.Text = dgv_build_info.Rows[0].Cells[3].Value.ToString();
            txt_build_squar.Text = dgv_build_info.Rows[0].Cells[4].Value.ToString();
            txt_build_street.Text = dgv_build_info.Rows[0].Cells[5].Value.ToString();
            txt_build_price.Text = dgv_build_info.Rows[0].Cells[6].Value.ToString();
            txt_build_type.Text = dgv_build_info.Rows[0].Cells[7].Value.ToString();
            txt_build_state.Text = dgv_build_info.Rows[0].Cells[8].Value.ToString();
            txt_order_type.Text = dgv_build_info.Rows[0].Cells[10].Value.ToString();
            txt_order_state.Text = dgv_build_info.Rows[0].Cells[11].Value.ToString();
            txt_build_note.Text = dgv_build_info.Rows[0].Cells[12].Value.ToString();
            txt_cust_name.Text = dgv_build_info.Rows[0].Cells[14].Value.ToString();
            txt_cust_card_no.Text = dgv_build_info.Rows[0].Cells[15].Value.ToString();
            txt_cust_phone.Text = dgv_build_info.Rows[0].Cells[16].Value.ToString();
            txt_cust_email.Text = dgv_build_info.Rows[0].Cells[17].Value.ToString();


            txt_build_count_unit.Text = cls_building.B_Get_All_Unit_In_build_Count(build_id).ToString();

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            int build_id = Convert.ToInt32(lbl_build_id.Text);
            dgv_image_build.DataSource = cls_building.B_Get_Image_Build(build_id);
            dgv_all_unit_in_build.DataSource = cls_unit.B_Get_All_Unit_In_Build(build_id);
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
           
            if (txt_order_type.Text == "تاجير" || txt_order_type.Text == "بيع")
            {
                PL.BuildingInterface.Interface_updateData.Update_Build_Request_Rent update_request_rent = new Interface_updateData.Update_Build_Request_Rent();

                update_request_rent.dgv_request_rent_info.DataSource = cls_building.B_Get_Request_Rent_info(build_id);
                update_request_rent.ShowDialog();
            }
            else
                if (txt_order_type.Text == "استاجار" || txt_order_type.Text == "شراء")
                {
                    PL.BuildingInterface.Interface_updateData.Update_Build_Request_Resident update_request_resident = new Interface_updateData.Update_Build_Request_Resident();
                    update_request_resident.dgv_request_resident_info.DataSource = cls_building.B_Get_Request_Resident_info(build_id);
                    update_request_resident.ShowDialog();
                }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("هل تريد فعلا حذف الطلب المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_building.B_Delete_Request_Build(build_id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PL.BuildingInterface.Interface_selectData.Select_Building select_build = new Interface_selectData.Select_Building();
                select_build.dgv_Building.DataSource = cls_building.B_Get_All_Building();
                this.Close();



            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgv_image_build_DoubleClick(object sender, EventArgs e)
        {
            BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();
            BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
            int image_id = Convert.ToInt32(dgv_image_build.CurrentRow.Cells[0].Value.ToString());
            byte[] imag = (byte[])cls_land.L_View_Image_land(image_id).Rows[0][0];
            MemoryStream ms = new MemoryStream(imag);
            PL.Land_Interface.Interface_View_Data.win_view_image view_image = new Land_Interface.Interface_View_Data.win_view_image();
            view_image.pic_image_land.Image = Image.FromStream(ms);
            view_image.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.BuildingInterface.Interface_viewData.view_enclosures view_image = new view_enclosures();
            if (dgv_all_unit_in_build.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("هذه الوحدة ليس لديها مرفقات");
            }
            else
            {
                int unit_id = Convert.ToInt32(dgv_all_unit_in_build.CurrentRow.Cells[0].Value.ToString());
                view_image.dgv_image_unit.DataSource = cls_unit.B_Get_Image_Unit(unit_id);
                view_image.ShowDialog();

            }

            }
        }
        


       
    }

