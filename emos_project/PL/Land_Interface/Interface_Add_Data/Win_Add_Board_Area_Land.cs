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
    public partial class Win_Add_Board_Area_Land : Form
    {
        public Win_Add_Board_Area_Land()
        {
            InitializeComponent();
        }
        BL.cls_land.cls_board_area cls_area = new BL.cls_land.cls_board_area();
        private void btn_save_build_Click(object sender, EventArgs e)
        {
            int land_id = Convert.ToInt32(this.dgv_max_id_land.Rows[0].Cells[0].Value.ToString());
            cls_area.L_Add_Board_Area(land_id,txt_east.Text,txt_board_east.Text,txt_west.Text,txt_board_west.Text,txt_north.Text,txt_board_north.Text,txt_south.Text,txt_board_south.Text,txt_prim_diag.Text,txt_sec_diag.Text,txt_calc_area.Text);
            MessageBox.Show("تم اضافة المساحة والحدود للارض بنجاح بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void txt_board_east_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt_board_north_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt_prim_diag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt_sec_diag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt_board_south_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt_board_west_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
