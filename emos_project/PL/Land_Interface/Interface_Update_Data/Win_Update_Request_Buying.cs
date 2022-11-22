using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.Land_Interface.Interface_Update_Data
{
    public partial class Win_Update_Request_Buying : Form
    {
        public Win_Update_Request_Buying()
        {
            InitializeComponent();
        }
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
        BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();


        private void Win_Update_Request_Buying_Load(object sender, EventArgs e)
        {
            cmb_land_conservatism.DataSource = cls_building.B_Get_All_Cust_Conservatism();
            cmb_land_conservatism.DisplayMember = "conservatism";
            cmb_land_conservatism.ValueMember = "conservatism";

            txt_cust_name.Text = dgv_request_buy_info.Rows[0].Cells[1].Value.ToString();
            cmb_land_conservatism.Text = dgv_request_buy_info.Rows[0].Cells[2].Value.ToString();
            cmb_land_city.Text = dgv_request_buy_info.Rows[0].Cells[3].Value.ToString();
            txt_land_square.Text = dgv_request_buy_info.Rows[0].Cells[4].Value.ToString();
            txt_land_street.Text = dgv_request_buy_info.Rows[0].Cells[5].Value.ToString();
            txt_land_price.Text = dgv_request_buy_info.Rows[0].Cells[6].Value.ToString();
            txt_land_order_type.Text = dgv_request_buy_info.Rows[0].Cells[7].Value.ToString();
            txt_land_order_state.Text = dgv_request_buy_info.Rows[0].Cells[8].Value.ToString();
            cmb_land_type.Text = dgv_request_buy_info.Rows[0].Cells[9].Value.ToString();
            txt_land_note.Text = dgv_request_buy_info.Rows[0].Cells[10].Value.ToString();
            txt_area.Text = dgv_request_buy_info.Rows[0].Cells[11].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_land_conservatism_TextChanged(object sender, EventArgs e)
        {
            cmb_land_city.DataSource = cls_building.B_Get_All_Customer_City(1 + int.Parse(cmb_land_conservatism.SelectedIndex.ToString()));
            cmb_land_city.DisplayMember = "city";
            cmb_land_city.ValueMember = "city";
        }

        private void btn_update_land_Click(object sender, EventArgs e)
        {
            int land_Id = Convert.ToInt32(dgv_request_buy_info.Rows[0].Cells[0].Value.ToString());
            cls_land.L_Update_Request_Buy(land_Id, cmb_land_conservatism.Text, cmb_land_city.Text, txt_land_square.Text, txt_land_street.Text,
                                      txt_land_price.Text, txt_land_order_type.Text, txt_land_order_state.Text, cmb_land_type.Text, txt_land_note.Text,txt_area.Text);
            MessageBox.Show("تم تعديل طلب الشراء بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
