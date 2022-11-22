using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.BuildingInterface.Interface_selectData
{
    public partial class Select_Building : Form
    {
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
        PL.BuildingInterface.Interface_addData.Add_Request_Rent add_build = new Interface_addData.Add_Request_Rent();



        public Select_Building()
        {
            InitializeComponent();

        }

        private void Select_Building_Load(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Building();

        }

        private void btn_all_cust_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Building();

        }

        private void btn_residents_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Rent();

        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Rent_Empty();

        }

        private void btn_buyers_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Rent_Full();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Rent_Mid_Full();

        }

        private void btn_renters_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Resident();

        }

        private void btn_agents_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Resident_Proccessed();

        }

        private void btn_auctioneer_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Resident_Unproccessed();

        }

        private void circular_button1_Click(object sender, EventArgs e)
        {
            PL.BuildingInterface.Interface_addData.Add_Request_Rent add_build = new Interface_addData.Add_Request_Rent();

            
            add_build.cmb_cust_name.DataSource = cls_building.B_Get_All_Renters_Name();
            add_build.cmb_cust_name.DisplayMember = "cust_name";
            add_build.cmb_cust_name.ValueMember = "Id";
            add_build.txt_order_type.Text = "تاجير";

            add_build.txt_build_state.Text = "شاغرة";
            add_build.cmb_build_state.Visible = false;
            add_build.txt_order_state.Text = "لم ينفذ";
            add_build.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circular_button5_Click(object sender, EventArgs e)
        {
            PL.BuildingInterface.Interface_addData.Add_Request_Resident add_request_resident = new Interface_addData.Add_Request_Resident();

            add_request_resident.cmb_cust_name.DataSource = cls_building.B_Get_All_Residents_Name();

            add_request_resident.cmb_cust_name.DisplayMember = "cust_name";
            add_request_resident.cmb_cust_name.ValueMember = "Id";

            add_request_resident.txt_order_type.Text = "استاجار";

            add_request_resident.txt_order_state.Text = "لم ينفذ";

            add_request_resident.ShowDialog();

        
        }

        private void circular_button2_Click(object sender, EventArgs e)
        {
            int build_id = Convert.ToInt32(dgv_Building.CurrentRow.Cells[0].Value.ToString());

            dgv_type_order.DataSource = cls_building.B_Get_Order_Type(build_id);
            string type_order = dgv_type_order.Rows[0].Cells[0].Value.ToString();

            if (type_order == "تاجير"||type_order=="بيع")
            {
                PL.BuildingInterface.Interface_updateData.Update_Build_Request_Rent update_request_rent = new Interface_updateData.Update_Build_Request_Rent();

                update_request_rent.dgv_request_rent_info.DataSource = cls_building.B_Get_Request_Rent_info(build_id);
                update_request_rent.ShowDialog();
            }
            else
                if (type_order == "استاجار"||type_order=="شراء")
                {
                    PL.BuildingInterface.Interface_updateData.Update_Build_Request_Resident update_request_resident = new Interface_updateData.Update_Build_Request_Resident();
                    update_request_resident.dgv_request_resident_info.DataSource = cls_building.B_Get_Request_Resident_info(build_id);
                    update_request_resident.ShowDialog();
                }
                

         
        }

        private void circular_button4_Click(object sender, EventArgs e)
        {
            PL.BuildingInterface.Interface_viewData.interview_build view_build_info = new Interface_viewData.interview_build();
            int build_id = Convert.ToInt32(dgv_Building.CurrentRow.Cells[0].Value.ToString());

            view_build_info.dgv_build_info.DataSource = cls_building.B_Get_build_Info(build_id);
            view_build_info.ShowDialog();
        }

        private void circular_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف الطلب المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_building.B_Delete_Request_Build(Convert.ToInt32(dgv_Building.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_Building.DataSource = cls_building.B_Get_All_Building();

                
            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circular_button6_Click(object sender, EventArgs e)
        {
            PL.BuildingInterface.Interface_addData.Add_Request_Rent add_build = new Interface_addData.Add_Request_Rent();

            //لتعبئة الكمبوبوكس باسماء الباعة في واجهة البيع
            add_build.cmb_cust_name.DataSource = cls_building.B_Get_All_Sellers_Name();
            add_build.cmb_cust_name.DisplayMember = "cust_name";
            add_build.cmb_cust_name.ValueMember = "Id";


            add_build.txt_order_type.Text = "بيع";

            add_build.txt_build_state.Visible = false;
            add_build.txt_order_state.Text = "لم ينفذ";

            add_build.lbl_form_address.Text = "اضافة طلب بيع عقار";
            add_build.lbl_cust_name.Text = "اسم البائع";
            add_build.ShowDialog();
        }

        private void circular_button7_Click(object sender, EventArgs e)
        {
            

            PL.BuildingInterface.Interface_addData.Add_Request_Resident add_request_resident = new Interface_addData.Add_Request_Resident();

            add_request_resident.cmb_cust_name.DataSource = cls_building.B_Get_All_Buyers_Name();
            add_request_resident.cmb_cust_name.DisplayMember = "cust_name";
            add_request_resident.cmb_cust_name.ValueMember = "Id";

            add_request_resident.txt_order_type.Text = "شراء";

            add_request_resident.txt_order_state.Text = "لم ينفذ";

            add_request_resident.ShowDialog();
        }

        private void Select_Building_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Sell();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_Building.DataSource = cls_building.B_Get_All_Request_Buy();

        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = cls_building.B_Search_Build(txtbox_search.Text);
            this.dgv_Building.DataSource = DT;
        }
    }
}
