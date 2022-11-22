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

namespace emos_project.PL.lease_land.Interface_Select_Data
{
    public partial class Win_Select_Lease_Land : Form
    {
        BL.cls_lease_land.cls_lease_land cls_lease_land = new BL.cls_lease_land.cls_lease_land();
        BL.cls_customer cls_cust = new BL.cls_customer();

        PL.lease_land.Interface_Add_Data.Win_Add_Lease_Land add_lease_land = new Interface_Add_Data.Win_Add_Lease_Land();
        PL.lease_land.Interface_Update_Data.Win_Update_Lease_Land update_lease_land = new Interface_Update_Data.Win_Update_Lease_Land();
        PL.lease_land.Interface_View_Data.Win_View_Lease_Land view_lease_land = new Interface_View_Data.Win_View_Lease_Land();


        public Win_Select_Lease_Land()
        {
            InitializeComponent();
        }

        private void Win_Select_Lease_Land_Load(object sender, EventArgs e)
        {
            dgv_lease_land.DataSource = cls_lease_land.Land_Les_Get_All_Lease_Land();

        }

        private void btn_all_lease_land_Click(object sender, EventArgs e)
        {
            dgv_lease_land.DataSource = cls_lease_land.Land_Les_Get_All_Lease_Land();

        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            dgv_lease_land.DataSource = cls_lease_land.Land_Les_Get_All_Lease_Land_Sells();

        }

        private void btn_buyers_Click(object sender, EventArgs e)
        {
            dgv_lease_land.DataSource = cls_lease_land.Land_Les_Get_All_Lease_Land_Rents();

        }

        private void circular_button5_Click(object sender, EventArgs e)
        {

            add_lease_land.lbl_address_form.Text = "إضافة عقد بيع";

            add_lease_land.lbl_cust_name.Text = "اسم المشتري";
            add_lease_land.cmb_cust_name.DataSource = cls_lease_land.Land_Les_Get_All_Buyers_Name();
            add_lease_land.cmb_cust_name.DisplayMember = "cust_name";
            add_lease_land.cmb_cust_name.ValueMember = "Id";


            add_lease_land.cmb_land_name.DataSource = cls_lease_land.Land_Les_Get_All_Lands_Sell_Name();
            add_lease_land.cmb_land_name.DisplayMember = "land_name";
            add_lease_land.cmb_land_name.ValueMember = "Id";

            add_lease_land.txt_lease_type.Text = "عقد بيع";


            add_lease_land.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circular_button1_Click(object sender, EventArgs e)
        {

            add_lease_land.lbl_address_form.Text = "اضافة عقد تاجير";
            add_lease_land.lbl_cust_name.Text = "اسم المستاجر";

            add_lease_land.cmb_cust_name.DataSource = cls_lease_land.Land_Les_Get_All_Residents_Name();
            add_lease_land.cmb_cust_name.DisplayMember = "cust_name";
            add_lease_land.cmb_cust_name.ValueMember = "Id";

            add_lease_land.cmb_land_name.DataSource = cls_lease_land.Land_Les_Get_All_Lands_Rent_Name();
            add_lease_land.cmb_land_name.DisplayMember = "land_name";
            add_lease_land.cmb_land_name.ValueMember = "Id";

            add_lease_land.txt_lease_type.Text = "عقد تاجير";

            add_lease_land.ShowDialog();

        }

        private void circular_button2_Click(object sender, EventArgs e)
        {

            int lease_id = Convert.ToInt32(dgv_lease_land.CurrentRow.Cells[0].Value.ToString());
            string lease_type = dgv_lease_land.CurrentRow.Cells[3].Value.ToString();


            if (lease_type == "عقد تاجير")
            {

                update_lease_land.lbl_address_form.Text = "تعديل عقد تاجير";
                update_lease_land.lbl_cust_name.Text = "اسم المستاجر";

                update_lease_land.txt_lease_type.Text = "عقد تاجير";

                update_lease_land.dgv_update_lease_land.DataSource = cls_lease_land.Land_Les_Get_Lease_Land_Info(lease_id);

                update_lease_land.cmb_land_name.DataSource = cls_lease_land.Land_Les_Get_All_Lands_Rent_Name();
                update_lease_land.cmb_land_name.DisplayMember = "land_name";
                update_lease_land.cmb_land_name.ValueMember = "Id";

                update_lease_land.btn_save_build.Text = "تعديل";

                update_lease_land.ShowDialog();
            }
            else
                if (lease_type == "عقد بيع")
                {


                    update_lease_land.lbl_address_form.Text = "تعديل عقد بيع";
                    update_lease_land.lbl_cust_name.Text = "اسم المشتري";


                    update_lease_land.txt_lease_type.Text = "عقد بيع";
                    update_lease_land.dgv_update_lease_land.DataSource = cls_lease_land.Land_Les_Get_Lease_Land_Info(lease_id);


                    update_lease_land.cmb_land_name.DataSource = cls_lease_land.Land_Les_Get_All_Lands_Sell_Name();
                    update_lease_land.cmb_land_name.DisplayMember = "land_name";
                    update_lease_land.cmb_land_name.ValueMember = "Id";

                    update_lease_land.btn_save_build.Text = "تعديل";


                    update_lease_land.ShowDialog();

                }
        }

        private void circular_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف العقد المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_lease_land.Land_Les_Delete_Lease_Land(Convert.ToInt32(dgv_lease_land.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_lease_land.DataSource = cls_lease_land.Land_Les_Get_All_Lease_Land();


            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_show_lease_land_Click(object sender, EventArgs e)
        {

           

            //من اجل اخذ رقم العميل  رقم الارض والعقد 
            int lease_Id = Convert.ToInt32(dgv_lease_land.CurrentRow.Cells[0].Value.ToString());
            dgv_Ids.DataSource = cls_lease_land.Land_Les_Get_Ids(lease_Id);
            int cust_Id = Convert.ToInt16(dgv_Ids.Rows[0].Cells[0].Value.ToString());
            int land_Id = Convert.ToInt16(dgv_Ids.Rows[0].Cells[3].Value.ToString());

            //لتعبئة البيانات 
            view_lease_land.dgv_lease_land_info.DataSource = cls_lease_land.Land_Les_Get_Lease_Land_Info(lease_Id);
            view_lease_land.dgv_land_info.DataSource = cls_lease_land.Land_Les_Get_Land_Info(land_Id);
            view_lease_land.dgv_owner_info.DataSource = cls_lease_land.Land_Les_Get_Owner_Info(land_Id);
            view_lease_land.dgv_cust_info.DataSource = cls_lease_land.Land_Les_Get_Resident_buyer_Info(cust_Id);
            view_lease_land.dgv_board_area.DataSource = cls_lease_land.Land_Les_Get_Board_Area(land_Id);

            // نقل البيانات من الداتاجريد فيوا الي الفورم في واجهة العقرض
            //show land lease data in view data tap for lease land 
            view_lease_land.txt_les_land_name.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[2].Value.ToString();
            view_lease_land.txt_lease_write_date.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[3].Value.ToString();
            view_lease_land.txt_lease_start_date.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[4].Value.ToString();
            view_lease_land.txt_lease_end_date.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[5].Value.ToString();
            view_lease_land.txt_total_money.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[6].Value.ToString();
            view_lease_land.txt_payed_money.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[7].Value.ToString();
            view_lease_land.txt_inst_money.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[8].Value.ToString();
            view_lease_land.txt_date_pay_money.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[9].Value.ToString();
            view_lease_land.txt_clusing_percentage.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[10].Value.ToString();
            view_lease_land.txt_estate_percentage.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[11].Value.ToString();
            view_lease_land.txt_pay_type.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[12].Value.ToString();
            view_lease_land.txt_wat1.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[13].Value.ToString();
            view_lease_land.txt_wat2.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[14].Value.ToString();
            view_lease_land.txt_lease_type.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[15].Value.ToString();
            view_lease_land.txt_note.Text = view_lease_land.dgv_lease_land_info.Rows[0].Cells[16].Value.ToString();


            //// عرض بيانات المساحة والحدود
            view_lease_land.txt_area.Text = view_lease_land.dgv_board_area.Rows[0].Cells[2].Value.ToString();
            view_lease_land.txt_board_east.Text = view_lease_land.dgv_board_area.Rows[0].Cells[4].Value.ToString();
            view_lease_land.txt_east.Text = view_lease_land.dgv_board_area.Rows[0].Cells[3].Value.ToString();
            view_lease_land.txt_board_west.Text = view_lease_land.dgv_board_area.Rows[0].Cells[6].Value.ToString();
            view_lease_land.txt_west.Text = view_lease_land.dgv_board_area.Rows[0].Cells[5].Value.ToString();
            view_lease_land.txt_board_north.Text = view_lease_land.dgv_board_area.Rows[0].Cells[8].Value.ToString();
            view_lease_land.txt_north.Text = view_lease_land.dgv_board_area.Rows[0].Cells[7].Value.ToString();
            view_lease_land.txt_board_south.Text = view_lease_land.dgv_board_area.Rows[0].Cells[10].Value.ToString();
            view_lease_land.txt_south.Text = view_lease_land.dgv_board_area.Rows[0].Cells[9].Value.ToString();
            view_lease_land.txt_prim_diag.Text = view_lease_land.dgv_board_area.Rows[0].Cells[11].Value.ToString();
            view_lease_land.txt_sec_diag.Text = view_lease_land.dgv_board_area.Rows[0].Cells[12].Value.ToString();
            view_lease_land.txt_calc_area.Text = view_lease_land.dgv_board_area.Rows[0].Cells[13].Value.ToString();


            //عرض بيانات المالك
            view_lease_land.txt_owner_name.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[1].Value.ToString();
            view_lease_land.txt_owner_type.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[2].Value.ToString();
            view_lease_land.txt_owner_card_no.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[3].Value.ToString();
            view_lease_land.txt_owner_card_loc.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[4].Value.ToString();
            view_lease_land.txt_owner_card_date.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[5].Value.ToString();
            view_lease_land.txt_owner_conservatism.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[6].Value.ToString();
            view_lease_land.txt_owner_city.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[7].Value.ToString();
            view_lease_land.txt_owner_squar.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[8].Value.ToString();
            view_lease_land.txt_owner_street.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[9].Value.ToString();
            view_lease_land.txt_owner_tel.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[10].Value.ToString();
            view_lease_land.txt_owner_phone.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[11].Value.ToString();
            view_lease_land.txt_owner_email.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[12].Value.ToString();
            //view_lease_land.pic_owner.Image = view_lease_land.dgv_owner_info.Rows[0].Cells[13].Value;
            view_lease_land.txt_owner_note.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[14].Value.ToString();
            view_lease_land.txt_owner_auctioneer.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[15].Value.ToString();
            view_lease_land.txt_owner_agent.Text = view_lease_land.dgv_owner_info.Rows[0].Cells[16].Value.ToString();

            int owner_Id = Convert.ToInt16(view_lease_land.dgv_owner_info.Rows[0].Cells[0].Value.ToString());
            byte[] owner_image = (byte[])cls_cust.View_Image(owner_Id).Rows[0][0];
            MemoryStream ms = new MemoryStream(owner_image);
            view_lease_land.pic_owner.Image = Image.FromStream(ms);


            ////عرض بيانات المستفيد

            ////عرض بيانات المالك
            view_lease_land.txt_cust_name.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[1].Value.ToString();
            view_lease_land.txt_cust_type.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[2].Value.ToString();
            view_lease_land.txt_cust_card_no.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[3].Value.ToString();
            view_lease_land.txt_cust_card_loc.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[4].Value.ToString();
            view_lease_land.txt_cust_card_date.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[5].Value.ToString();
            view_lease_land.txt_cust_conservatism.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[6].Value.ToString();
            view_lease_land.txt_cust_city.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[7].Value.ToString();
            view_lease_land.txt_cust_squar.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[8].Value.ToString();
            view_lease_land.txt_cust_street.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[9].Value.ToString();
            view_lease_land.txt_cust_tel.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[10].Value.ToString();
            view_lease_land.txt_cust_phone.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[11].Value.ToString();
            view_lease_land.txt_cust_email.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[12].Value.ToString();
            //view_lease_land.pic_cust.Image = view_lease_land.dgv_cust_info.Rows[0].Cells[13].Value;
            view_lease_land.txt_cust_note.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[14].Value.ToString();
            view_lease_land.txt_cust_auctioneer.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[15].Value.ToString();
            view_lease_land.txt_cust_agent.Text = view_lease_land.dgv_cust_info.Rows[0].Cells[16].Value.ToString();


            byte[] cust_image = (byte[])cls_cust.View_Image(cust_Id).Rows[0][0];
            MemoryStream mss = new MemoryStream(cust_image);
            view_lease_land.pic_cust.Image = Image.FromStream(mss);



            view_lease_land.ShowDialog();
        }
    }
}
