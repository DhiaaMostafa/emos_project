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
namespace emos_project.PL.Land_Interface.Interface_View_Data
{
    public partial class Win_View_Lands : Form
    {
        public Win_View_Lands()
        {
            InitializeComponent();
        }
        BL.cls_land.cls_land cls_land=new BL.cls_land.cls_land();
        int land_id;
        private void Win_View_Lands_Load(object sender, EventArgs e)
        {

            land_id=Convert.ToInt32(dgv_land_info.Rows[0].Cells[0].Value.ToString());
            lbl_land_id.Text = land_id.ToString();


            txt_land_name.Text = dgv_land_info.Rows[0].Cells[1].Value.ToString();
            txt_land_conservatism.Text = dgv_land_info.Rows[0].Cells[2].Value.ToString();
            txt_land_city.Text = dgv_land_info.Rows[0].Cells[3].Value.ToString();
            txt_land_squar.Text = dgv_land_info.Rows[0].Cells[4].Value.ToString();
            txt_land_street.Text = dgv_land_info.Rows[0].Cells[5].Value.ToString();
            txt_land_price.Text = dgv_land_info.Rows[0].Cells[6].Value.ToString();
            txt_order_type.Text = dgv_land_info.Rows[0].Cells[7].Value.ToString();
            txt_order_state.Text = dgv_land_info.Rows[0].Cells[8].Value.ToString();
            txt_land_type.Text = dgv_land_info.Rows[0].Cells[9].Value.ToString();
            txt_land_state.Text = dgv_land_info.Rows[0].Cells[10].Value.ToString();
            
            txt_land_note.Text = dgv_land_info.Rows[0].Cells[11].Value.ToString();
            txt_cust_name.Text = dgv_land_info.Rows[0].Cells[12].Value.ToString();
            txt_cust_card_no.Text = dgv_land_info.Rows[0].Cells[13].Value.ToString();
            txt_cust_phone.Text = dgv_land_info.Rows[0].Cells[14].Value.ToString();
            txt_cust_email.Text = dgv_land_info.Rows[0].Cells[15].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_land_Click(object sender, EventArgs e)
        {

            int land_id = Convert.ToInt32(dgv_land_info.Rows[0].Cells[0].Value.ToString());

            if (txt_order_type.Text == "تاجير" || txt_order_type.Text == "بيع")
            {
                PL.Land_Interface.Interface_Update_Data.Win_Update_Request_Sell Update_Request_Sell = new Interface_Update_Data.Win_Update_Request_Sell();
                Update_Request_Sell.dgv_request_sell_info.DataSource = cls_land.L_Get_Request_Sell_Info(land_id);
                Update_Request_Sell.ShowDialog();
            }
            else
                if (txt_order_type.Text == "استاجار" || txt_order_type.Text == "شراء")
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
                cls_land.L_Delete_Request_Land(land_id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PL.Land_Interface.Interface_Select_Data.Win_Select_Land select_land = new Interface_Select_Data.Win_Select_Land();
                select_land.dgv_land.DataSource = cls_land.L_Get_All_Lands();
                this.Close();
            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

            int land_id = Convert.ToInt32(lbl_land_id.Text);
            dgv_image_land.DataSource = cls_land.L_Get_Image_land(land_id);
            dgv_board_area.DataSource = cls_land.L_Get_Board_Area_Land(land_id);
            if (dgv_board_area.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("هذه الارض لم يتم تعبئة البيانات الخاصة بمساحتها");
            }
            else
            {
                txt_area.Text = dgv_board_area.Rows[0].Cells[2].Value.ToString();
                txt_board_east.Text = dgv_board_area.Rows[0].Cells[4].Value.ToString();
                txt_east.Text = dgv_board_area.Rows[0].Cells[3].Value.ToString();
                txt_board_west.Text = dgv_board_area.Rows[0].Cells[6].Value.ToString();
                txt_west.Text = dgv_board_area.Rows[0].Cells[5].Value.ToString();
                txt_board_north.Text = dgv_board_area.Rows[0].Cells[8].Value.ToString();
                txt_north.Text = dgv_board_area.Rows[0].Cells[7].Value.ToString();
                txt_board_south.Text = dgv_board_area.Rows[0].Cells[10].Value.ToString();
                txt_south.Text = dgv_board_area.Rows[0].Cells[9].Value.ToString();
                txt_prim_diag.Text = dgv_board_area.Rows[0].Cells[11].Value.ToString();
                txt_sec_diag.Text = dgv_board_area.Rows[0].Cells[12].Value.ToString();
                txt_calc_area.Text = dgv_board_area.Rows[0].Cells[13].Value.ToString();
            }
        }

        private void dgv_image_land_DoubleClick(object sender, EventArgs e)
        {
            BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();

            byte[] imag = (byte[])cls_land.L_View_Image_land(Convert.ToInt32(this.dgv_image_land.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(imag);
            PL.Land_Interface.Interface_View_Data.win_view_image view_image = new win_view_image();
            view_image.pic_image_land.Image = Image.FromStream(ms);
            view_image.ShowDialog();

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
