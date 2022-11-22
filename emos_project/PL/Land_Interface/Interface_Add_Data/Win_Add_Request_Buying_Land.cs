using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.Land_Interface.Interface_Add_Data
{
    public partial class Win_Add_Request_Buying_Land : Form
    {
        BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();
        public Win_Add_Request_Buying_Land()
        {
            InitializeComponent();
        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {
            cls_land.L_Add_Request_Buy(Convert.ToInt32(cmb_cust_name.SelectedValue.ToString()), cmb_land_conservatism.Text, cmb_land_city.Text, txt_land_square.Text, txt_land_street.Text, txt_land_price.Text, txt_land_order_type.Text, txt_land_order_state.Text, cmb_land_type.Text, txt_land_note.Text,txt_area.Text);


            MessageBox.Show("تم اضافة طلب الشراء بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_land_add_board_area.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
