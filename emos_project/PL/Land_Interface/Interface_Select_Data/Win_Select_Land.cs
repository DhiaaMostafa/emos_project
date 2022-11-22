using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.Land_Interface.Interface_Select_Data
{
    public partial class Win_Select_Land : Form
    {

        BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();

        public Win_Select_Land()
        {
            InitializeComponent();
        }

        private void Win_Select_Land_Load(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Lands();

        }

       

        private void btn_all_land_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Lands();

        }

        private void btn_request_sell_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Sell();

        }

        private void btn_land_unselled_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Sell_Unselled();

        }

        private void btn_land_selled_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Sell_Selled();

        }

        private void btn_land_apart_selled_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Sell_Selled_Appart();

        }

        private void btn_request_buy_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Buy();

        }

        private void btn_request_proccessed_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Buy_Proccessed();

        }

        private void btn_request_unproccessed_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Buy_Unproccessed();

        }

        private void btn_request_rent_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Rent();

        }

        private void btn_request_resident_Click(object sender, EventArgs e)
        {
            dgv_land.DataSource = cls_land.L_Get_All_Request_Resident();

        }

        private void btn_add_request_sell_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Add_Data.Win_Add_Request_selling_Land Add_Request_Land = new Interface_Add_Data.Win_Add_Request_selling_Land();

            //لتعبئة الكمبوبوكس باسماء الباعة في واجهة البيع
            Add_Request_Land.cmb_cust_name.DataSource = cls_land.L_Get_All_Sellers_Name();
            Add_Request_Land.cmb_cust_name.DisplayMember = "cust_name";
            Add_Request_Land.cmb_cust_name.ValueMember = "Id";

            //لتعبئة نوع الطلب تلقائيا
            Add_Request_Land.txt_land_order_type.Text = "بيع";

            Add_Request_Land.txt_land_state.Text = "غير مبتاعة";
            Add_Request_Land.txt_land_order_state.Text = "لم ينفذ";



            //لتعبئة كل من عنوان الفورم وعنوان اسم المالك بكل تلقائي بما يناسب صفته والعملية التي هو فيها
            Add_Request_Land.lbl_form_address.Text = "اضافة طلب بيع ارض";
            Add_Request_Land.lbl_cust_name.Text = "اسم المالك";
            

            Add_Request_Land.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_request_buy_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Add_Data.Win_Add_Request_Buying_Land Add_Request_Land = new Interface_Add_Data.Win_Add_Request_Buying_Land();

            //لتعبئة الكمبوبوكس باسماء الباعة في واجهة البيع
            Add_Request_Land.cmb_cust_name.DataSource = cls_land.L_Get_All_Buyers_Name();
            Add_Request_Land.cmb_cust_name.DisplayMember = "cust_name";
            Add_Request_Land.cmb_cust_name.ValueMember = "Id";

            //لتعبئة نوع الطلب تلقائيا
            Add_Request_Land.txt_land_order_type.Text = "شراء";
            Add_Request_Land.txt_land_order_state.Text = "لم ينفذ";
            //لتعبئة كل من عنوان الفورم وعنوان اسم المالك بكل تلقائي بما يناسب صفته والعملية التي هو فيها

            Add_Request_Land.lbl_address_form.Text = "اضافة طلب شراء ارض";
            Add_Request_Land.lbl_cust_name.Text = "اسم المشتري";


            Add_Request_Land.ShowDialog();
        }

        private void btn_Add_request_rent_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Add_Data.Win_Add_Request_selling_Land Add_Request_Land = new Interface_Add_Data.Win_Add_Request_selling_Land();

            //لتعبئة الكمبوبوكس باسماء الباعة في واجهة البيع
            Add_Request_Land.cmb_cust_name.DataSource = cls_land.L_Get_All_Renters_Name();
            Add_Request_Land.cmb_cust_name.DisplayMember = "cust_name";
            Add_Request_Land.cmb_cust_name.ValueMember = "Id";

            Add_Request_Land.txt_land_order_type.Text = "تاجير";
            Add_Request_Land.txt_land_state.Text = "غير موجرة";
            Add_Request_Land.txt_land_order_state.Text = "لم ينفذ";


            //لتعبئة كل من عنوان الفورم وعنوان اسم المالك بكل تلقائي بما يناسب صفته والعملية التي هو فيها

            Add_Request_Land.lbl_form_address.Text = "اضافة طلب تاجير ارض";
            Add_Request_Land.lbl_cust_name.Text = "اسم المؤجر";



            Add_Request_Land.ShowDialog();
        }

        private void btn_add_request_resident_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Add_Data.Win_Add_Request_Buying_Land Add_Request_Land = new Interface_Add_Data.Win_Add_Request_Buying_Land();

            //لتعبئة الكمبوبوكس باسماء الباعة في واجهة البيع
            Add_Request_Land.cmb_cust_name.DataSource = cls_land.L_Get_All_Residents_Name();
            Add_Request_Land.cmb_cust_name.DisplayMember = "cust_name";
            Add_Request_Land.cmb_cust_name.ValueMember = "Id";

            Add_Request_Land.txt_land_order_type.Text = "استاجار";

            Add_Request_Land.txt_land_order_state.Text = "لم ينفذ";

            //لتعبئة كل من عنوان الفورم وعنوان اسم المالك بكل تلقائي بما يناسب صفته والعملية التي هو فيها

            Add_Request_Land.lbl_address_form.Text = "اضافة طلب استاجار ارض";
            Add_Request_Land.lbl_cust_name.Text = "اسم المستاجر";

            Add_Request_Land.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
             int land_id = Convert.ToInt32(dgv_land.CurrentRow.Cells[0].Value.ToString());

            dgv_type_order.DataSource = cls_land.L_Get_Order_Type(land_id);

            string type_order = dgv_type_order.Rows[0].Cells[0].Value.ToString();

            if (type_order == "تاجير" || type_order == "بيع")
            {
                PL.Land_Interface.Interface_Update_Data.Win_Update_Request_Sell Update_Request_Sell = new Interface_Update_Data.Win_Update_Request_Sell();
                Update_Request_Sell.dgv_request_sell_info.DataSource = cls_land.L_Get_Request_Sell_Info(land_id);
                Update_Request_Sell.ShowDialog();
            }
            else
                if (type_order == "استاجار" || type_order == "شراء")
                {
                    PL.Land_Interface.Interface_Update_Data.Win_Update_Request_Buying Update_Request_Buy = new Interface_Update_Data.Win_Update_Request_Buying();
                    Update_Request_Buy.dgv_request_buy_info.DataSource = cls_land.L_Get_Request_Buy_Info(land_id);
                    Update_Request_Buy.ShowDialog();
                   
                }
        
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف الطلب المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_land.L_Delete_Request_Land(Convert.ToInt32(dgv_land.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_land.DataSource = cls_land.L_Get_All_Lands();
            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_shoe_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_View_Data.Win_View_Lands win_view_land = new Interface_View_Data.Win_View_Lands();

            int land_id = Convert.ToInt32(dgv_land.CurrentRow.Cells[0].Value.ToString());

            win_view_land.dgv_land_info.DataSource = cls_land.L_Get_Request_Land_Info(land_id);
            win_view_land.ShowDialog();
        }


       
    }
}
