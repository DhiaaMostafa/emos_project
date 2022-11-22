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
    public partial class Win_Add_Request_selling_Land : Form
    {

        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
        BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();
        public Win_Add_Request_selling_Land()
        {
            InitializeComponent();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Win_Add_Request_selling_Land_Load(object sender, EventArgs e)
        {
            
            cmb_land_conservatism.DataSource = cls_building.B_Get_All_Cust_Conservatism();
            cmb_land_conservatism.DisplayMember = "conservatism";
            cmb_land_conservatism.ValueMember = "conservatism";
        }

        private void cmb_build_conservatism_TextChanged(object sender, EventArgs e)
        {
            cmb_land_city.DataSource = cls_building.B_Get_All_Customer_City(1 + int.Parse(cmb_land_conservatism.SelectedIndex.ToString()));
            cmb_land_city.DisplayMember = "city";
            cmb_land_city.ValueMember = "city";
        }

     

        private void btn_save_land_Click_1(object sender, EventArgs e)
        {

            cls_land.L_Add_Request_Sell(Convert.ToInt32(cmb_cust_name.SelectedValue.ToString()), txt_land_name.Text, cmb_land_conservatism.Text, cmb_land_city.Text, txt_land_square.Text, txt_land_street.Text, txt_land_price.Text, txt_land_order_type.Text, txt_land_order_state.Text, cmb_land_type.Text, txt_land_state.Text, txt_land_note.Text,txt_area.Text);


           MessageBox.Show("تم اضافة طلب التاجير بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           btn_land_add_enclosure.Enabled = true;
           btn_land_add_board_area.Enabled = true;
        }

        private void btn_land_add_enclosure_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Add_Data.Win_Add_Request_Enclosures_Land add_enclosures = new Win_Add_Request_Enclosures_Land();

            add_enclosures.dgv_get_max_land_Id.DataSource = cls_land.L_Get_Max_Land_Id();
            add_enclosures.land_id_max = int.Parse(add_enclosures.dgv_get_max_land_Id.Rows[0].Cells[0].Value.ToString());

            add_enclosures.ShowDialog();
        }

        private void btn_land_add_board_area_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Add_Data.Win_Add_Board_Area_Land add_board_area = new Win_Add_Board_Area_Land();

            add_board_area.dgv_max_id_land.DataSource = cls_land.L_Get_Max_Land_Id();
            //add_board_area.land_id_max = int.Parse(add_enclosures.dgv_get_max_land_Id.Rows[0].Cells[0].Value.ToString());

            add_board_area.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

     
    }
}
