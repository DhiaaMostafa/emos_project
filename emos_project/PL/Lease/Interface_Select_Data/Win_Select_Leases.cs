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
using System.Data.SqlClient;

namespace emos_project.PL.Lease.Interface_Select_Data
{
    public partial class Win_Select_Leases : Form
    {

        BL.cls_lease_build.cls_lease_build cls_lease_build = new BL.cls_lease_build.cls_lease_build();
        BL.cls_customer cls_cust = new BL.cls_customer();

        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

        
        public Win_Select_Leases()
        {
            InitializeComponent();
        }

        private void Win_Select_Leases_Load(object sender, EventArgs e)
        {
            dgv_lease_build.DataSource = cls_lease_build.Les_Get_All_Lease_Build();

        }

        private void btn_all_cust_Click(object sender, EventArgs e)
        {
            dgv_lease_build.DataSource = cls_lease_build.Les_Get_All_Lease_Build();

        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            dgv_lease_build.DataSource = cls_lease_build.Les_Get_All_Lease_Build_Sells();

        }

        private void btn_buyers_Click(object sender, EventArgs e)
        {
            dgv_lease_build.DataSource = cls_lease_build.Les_Get_All_Lease_Build_Rents();

        }

        private void circular_button5_Click(object sender, EventArgs e)
        {
            PL.Lease.Interface_Add_Data.Win_Add_lease_build add_leae_build_rent = new Interface_Add_Data.Win_Add_lease_build();

            add_leae_build_rent.lbl_address_form.Text = "إضافة عقد بيع";

            add_leae_build_rent.lbl_cust_name.Text = "اسم المشتري";
            add_leae_build_rent.cmb_cust_name.DataSource = cls_lease_build.Les_Get_All_Buyers_Name();
            add_leae_build_rent.cmb_cust_name.DisplayMember = "cust_name";
            add_leae_build_rent.cmb_cust_name.ValueMember = "Id";


            add_leae_build_rent.cmb_build_name.DataSource = cls_lease_build.Les_Get_All_Sell_Build_Name();
            add_leae_build_rent.cmb_build_name.DisplayMember = "build_name";
            add_leae_build_rent.cmb_build_name.ValueMember = "Id";


            //..........
            int cust_Id = Convert.ToInt16(add_leae_build_rent.cmb_cust_name.SelectedValue.ToString());

            BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

            add_leae_build_rent.cmb_cust_order.DataSource = cls_building.Les_Get_All_Order_Request_Buyer_Build_Name(cust_Id);
            add_leae_build_rent.cmb_cust_order.DisplayMember = "build_name";
            add_leae_build_rent.cmb_cust_order.ValueMember = "Id";

            //.......

            add_leae_build_rent.txt_lease_type.Text = "عقد بيع";

            add_leae_build_rent.ShowDialog();
        }

        private void circular_button1_Click(object sender, EventArgs e)
        {
            PL.Lease.Interface_Add_Data.Win_Add_lease_build add_leae_build_rent = new Interface_Add_Data.Win_Add_lease_build();

            add_leae_build_rent.lbl_address_form.Text = "تعديل عقد تاجير";
            add_leae_build_rent.lbl_cust_name.Text = "اسم المستاجر";

            add_leae_build_rent.cmb_cust_name.DataSource = cls_lease_build.Les_Get_All_Residents_Name();
            add_leae_build_rent.cmb_cust_name.DisplayMember = "cust_name";
            add_leae_build_rent.cmb_cust_name.ValueMember = "Id";

            add_leae_build_rent.cmb_build_name.DataSource = cls_lease_build.Les_Get_All_Rent_Build_Name();
            add_leae_build_rent.cmb_build_name.DisplayMember = "build_name";
            add_leae_build_rent.cmb_build_name.ValueMember = "Id";
            add_leae_build_rent.txt_lease_type.Text = "عقد تاجير";
            dgv_build_name.DataSource = cls_lease_build.Les_Get_All_Rent_Build_Name();
            if (dgv_build_name.Rows[0].Cells[0].Value != null)
            {
                add_leae_build_rent.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا يوجد منشأت للايجار في الوقت الحالي ");

            }

            

            
        }

        private void circular_button2_Click(object sender, EventArgs e)
        {
            int lease_id = Convert.ToInt32(dgv_lease_build.CurrentRow.Cells[0].Value.ToString());
            string lease_type=dgv_lease_build.CurrentRow.Cells[4].Value.ToString();

            PL.Lease.Interface_Update_Data.Win_Update_lease_build update_lease = new Interface_Update_Data.Win_Update_lease_build();

            if (lease_type == "عقد تاجير")
            {

                update_lease.lbl_address_form.Text = "تعديل عقد تاجير";
                update_lease.lbl_cust_name.Text = "اسم المستاجر";

                update_lease.txt_lease_type.Text = "عقد تاجير";

                update_lease.dgv_update_lease_build.DataSource = cls_lease_build.Les_Get_Lease_Build_Info(lease_id);

                update_lease.cmb_build_name.DataSource = cls_lease_build.Les_Get_All_Rent_Build_Name();
                update_lease.cmb_build_name.DisplayMember = "build_name";
                update_lease.cmb_build_name.ValueMember = "Id";

                update_lease.btn_save_build.Text = "تعديل";

                update_lease.ShowDialog();
            }
            else
                if (lease_type == "عقد بيع")
                {


                    update_lease.lbl_address_form.Text = "تعديل عقد بيع";
                    update_lease.lbl_cust_name.Text = "اسم المشتري";

                   
                    update_lease.txt_lease_type.Text = "عقد بيع";
                    update_lease.dgv_update_lease_build.DataSource = cls_lease_build.Les_Get_Lease_Build_Info(lease_id);


                    update_lease.cmb_build_name.DataSource = cls_lease_build.Les_Get_All_Sell_Build_Name();
                    update_lease.cmb_build_name.DisplayMember = "build_name";
                    update_lease.cmb_build_name.ValueMember = "Id";

                    update_lease.btn_save_build.Text = "تعديل";


                    update_lease.ShowDialog();

                }



            
          
                
        }//end of method update


        private void circular_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف العقد المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_lease_build.Les_Delete_Lease_Build(Convert.ToInt32(dgv_lease_build.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_lease_build.DataSource = cls_lease_build.Les_Get_All_Lease_Build();

                
            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void circular_button4_Click(object sender, EventArgs e)
        {
            PL.Lease.Interface_View_Data.Win_view_lease_build view_data = new Interface_View_Data.Win_view_lease_build();

            //من اجل اخذ رقم العميل والمنشائة والوحدة والعقد 
            int lease_Id = Convert.ToInt32(dgv_lease_build.CurrentRow.Cells[0].Value.ToString());
            dgv_Ids.DataSource = cls_lease_build.Les_Get_Ids(lease_Id);
            int cust_Id = Convert.ToInt16(dgv_Ids.Rows[0].Cells[0].Value.ToString());
            int build_Id = Convert.ToInt16(dgv_Ids.Rows[0].Cells[1].Value.ToString());
            int unit_Id = Convert.ToInt16(dgv_Ids.Rows[0].Cells[2].Value.ToString());

            //لتعبئة البيانات 
            view_data.dgv_lease_info.DataSource = cls_lease_build.Les_Get_Lease_Build_Info(lease_Id);
            view_data.dgv_build_info.DataSource = cls_lease_build.Les_Get_Build_Info(build_Id);
            view_data.dgv_unit_info.DataSource = cls_lease_build.Les_Get_Unit_In_Build_Info(unit_Id);
            view_data.dgv_owner_info.DataSource = cls_lease_build.Les_Get_Owner_Info(build_Id);
            view_data.dgv_cust_info.DataSource = cls_lease_build.Les_Get_Resident_buyer_Info(cust_Id);

            // نقل البيانات من الداتاجريد فيوا الي الفورم في واجهة العقرض
            view_data.txt_les_build_name.Text = view_data.dgv_lease_info.Rows[0].Cells[2].Value.ToString();
            view_data.txt_les_unit_name.Text = view_data.dgv_lease_info.Rows[0].Cells[3].Value.ToString();
            view_data.txt_lease_write_date.Text = view_data.dgv_lease_info.Rows[0].Cells[4].Value.ToString();
            view_data.txt_lease_start_date.Text = view_data.dgv_lease_info.Rows[0].Cells[5].Value.ToString();
            view_data.txt_lease_end_date.Text = view_data.dgv_lease_info.Rows[0].Cells[6].Value.ToString();
            view_data.txt_total_money.Text = view_data.dgv_lease_info.Rows[0].Cells[7].Value.ToString();
            view_data.txt_payed_money.Text = view_data.dgv_lease_info.Rows[0].Cells[8].Value.ToString();
            view_data.txt_inst_money.Text = view_data.dgv_lease_info.Rows[0].Cells[9].Value.ToString();
            view_data.txt_date_pay_money.Text = view_data.dgv_lease_info.Rows[0].Cells[10].Value.ToString();
            view_data.txt_clusing_percentage.Text = view_data.dgv_lease_info.Rows[0].Cells[11].Value.ToString();
            view_data.txt_estate_percentage.Text = view_data.dgv_lease_info.Rows[0].Cells[12].Value.ToString();
            view_data.txt_pay_type.Text = view_data.dgv_lease_info.Rows[0].Cells[13].Value.ToString();
            view_data.txt_wat1.Text = view_data.dgv_lease_info.Rows[0].Cells[14].Value.ToString();
            view_data.txt_wat2.Text = view_data.dgv_lease_info.Rows[0].Cells[15].Value.ToString();
            view_data.txt_lease_type.Text = view_data.dgv_lease_info.Rows[0].Cells[16].Value.ToString();
            view_data.txt_note.Text = view_data.dgv_lease_info.Rows[0].Cells[17].Value.ToString();

            view_data.txt_unit_build_count.Text= cls_building.B_Get_All_Unit_In_build_Count(build_Id).ToString();



            // لعرض بيانات المنشاة والوحدة في تاب المنشات والوحدات
            // عرض بيانات المنشاة
            view_data.txt_build_name.Text = view_data.dgv_build_info.Rows[0].Cells[1].Value.ToString();
            view_data.txt_build_conservatism.Text = view_data.dgv_build_info.Rows[0].Cells[2].Value.ToString();
            view_data.txt_build_city.Text = view_data.dgv_build_info.Rows[0].Cells[3].Value.ToString();
            view_data.txt_build_square.Text = view_data.dgv_build_info.Rows[0].Cells[4].Value.ToString();
            view_data.txt_build_street.Text = view_data.dgv_build_info.Rows[0].Cells[5].Value.ToString();
            view_data.txt_build_price.Text = view_data.dgv_build_info.Rows[0].Cells[6].Value.ToString();
            view_data.txt_build_type.Text = view_data.dgv_build_info.Rows[0].Cells[7].Value.ToString();
            view_data.txt_build_state.Text = view_data.dgv_build_info.Rows[0].Cells[8].Value.ToString();
            view_data.txt_order_type.Text = view_data.dgv_build_info.Rows[0].Cells[10].Value.ToString();
            view_data.txt_order_state.Text = view_data.dgv_build_info.Rows[0].Cells[11].Value.ToString();
            view_data.txt_note.Text = view_data.dgv_build_info.Rows[0].Cells[12].Value.ToString();

            //عرض بيانات الوحدة

            view_data.txt_unit_name.Text= view_data.dgv_unit_info.Rows[0].Cells[1].Value.ToString();
            view_data.txt_unit_rooms_count.Text = view_data.dgv_unit_info.Rows[0].Cells[2].Value.ToString();
            view_data.txt_unit_price.Text = view_data.dgv_unit_info.Rows[0].Cells[3].Value.ToString();
            view_data.txt_unit_living_rooms.Text = view_data.dgv_unit_info.Rows[0].Cells[4].Value.ToString();
            view_data.txt_unit_bed_rooms.Text = view_data.dgv_unit_info.Rows[0].Cells[5].Value.ToString();
            view_data.txt_unit_bath_rooms.Text = view_data.dgv_unit_info.Rows[0].Cells[6].Value.ToString();
            view_data.txt_unit_ketchens.Text= view_data.dgv_unit_info.Rows[0].Cells[7].Value.ToString();
            view_data.txt_unit_note.Text = view_data.dgv_unit_info.Rows[0].Cells[9].Value.ToString();

            //عرض بيانات المالك
            view_data.txt_owner_name.Text = view_data.dgv_owner_info.Rows[0].Cells[1].Value.ToString();
            view_data.txt_owner_type.Text = view_data.dgv_owner_info.Rows[0].Cells[2].Value.ToString();
            view_data.txt_owner_card_no.Text = view_data.dgv_owner_info.Rows[0].Cells[3].Value.ToString();
            view_data.txt_owner_card_loc.Text = view_data.dgv_owner_info.Rows[0].Cells[4].Value.ToString();
            view_data.txt_owner_card_date.Text = view_data.dgv_owner_info.Rows[0].Cells[5].Value.ToString();
            view_data.txt_owner_conservatism.Text = view_data.dgv_owner_info.Rows[0].Cells[6].Value.ToString();
            view_data.txt_owner_city.Text = view_data.dgv_owner_info.Rows[0].Cells[7].Value.ToString();
            view_data.txt_owner_squar.Text = view_data.dgv_owner_info.Rows[0].Cells[8].Value.ToString();
            view_data.txt_owner_street.Text = view_data.dgv_owner_info.Rows[0].Cells[9].Value.ToString();
            view_data.txt_owner_tel.Text = view_data.dgv_owner_info.Rows[0].Cells[10].Value.ToString();
            view_data.txt_owner_phone.Text = view_data.dgv_owner_info.Rows[0].Cells[11].Value.ToString();
            view_data.txt_owner_email.Text = view_data.dgv_owner_info.Rows[0].Cells[12].Value.ToString();
            //view_data.pic_owner.Image = view_data.dgv_owner_info.Rows[0].Cells[13].Value;
            view_data.txt_owner_note.Text = view_data.dgv_owner_info.Rows[0].Cells[14].Value.ToString();
            view_data.txt_owner_auctioneer.Text = view_data.dgv_owner_info.Rows[0].Cells[15].Value.ToString();
            view_data.txt_owner_agent.Text = view_data.dgv_owner_info.Rows[0].Cells[16].Value.ToString();

            int owner_Id = Convert.ToInt16(view_data.dgv_owner_info.Rows[0].Cells[0].Value.ToString());
            byte[] owner_image = (byte[])cls_cust.View_Image(owner_Id).Rows[0][0];
            MemoryStream ms = new MemoryStream(owner_image);
            view_data.pic_owner.Image= Image.FromStream(ms);


            //عرض بيانات المستفيد

            //عرض بيانات المالك
            view_data.txt_cust_name.Text = view_data.dgv_cust_info.Rows[0].Cells[1].Value.ToString();
            view_data.txt_cust_type.Text = view_data.dgv_cust_info.Rows[0].Cells[2].Value.ToString();
            view_data.txt_cust_card_no.Text = view_data.dgv_cust_info.Rows[0].Cells[3].Value.ToString();
            view_data.txt_cust_card_loc.Text = view_data.dgv_cust_info.Rows[0].Cells[4].Value.ToString();
            view_data.txt_cust_card_date.Text = view_data.dgv_cust_info.Rows[0].Cells[5].Value.ToString();
            view_data.txt_cust_conservatism.Text = view_data.dgv_cust_info.Rows[0].Cells[6].Value.ToString();
            view_data.txt_cust_city.Text = view_data.dgv_cust_info.Rows[0].Cells[7].Value.ToString();
            view_data.txt_cust_squar.Text = view_data.dgv_cust_info.Rows[0].Cells[8].Value.ToString();
            view_data.txt_cust_street.Text = view_data.dgv_cust_info.Rows[0].Cells[9].Value.ToString();
            view_data.txt_cust_tel.Text = view_data.dgv_cust_info.Rows[0].Cells[10].Value.ToString();
            view_data.txt_cust_phone.Text = view_data.dgv_cust_info.Rows[0].Cells[11].Value.ToString();
            view_data.txt_cust_email.Text = view_data.dgv_cust_info.Rows[0].Cells[12].Value.ToString();
            //view_data.pic_cust.Image = view_data.dgv_cust_info.Rows[0].Cells[13].Value;
            view_data.txt_cust_note.Text = view_data.dgv_cust_info.Rows[0].Cells[14].Value.ToString();
            view_data.txt_cust_auctioneer.Text = view_data.dgv_cust_info.Rows[0].Cells[15].Value.ToString();
            view_data.txt_cust_agent.Text = view_data.dgv_cust_info.Rows[0].Cells[16].Value.ToString();


            byte[] cust_image = (byte[])cls_cust.View_Image(cust_Id).Rows[0][0];
            MemoryStream mss = new MemoryStream(cust_image);
            view_data.pic_cust.Image = Image.FromStream(mss);



            
            view_data.ShowDialog();
         

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
