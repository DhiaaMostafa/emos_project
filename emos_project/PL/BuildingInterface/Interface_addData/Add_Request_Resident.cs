using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.BuildingInterface.Interface_addData
{
    public partial class Add_Request_Resident : Form
    {
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
        public Add_Request_Resident()
        {
            InitializeComponent();
        }
        private void Add_Request_Resident_Load(object sender, EventArgs e)
        {
            

            cmb_build_conservatism.DataSource = cls_building.B_Get_All_Cust_Conservatism();
            cmb_build_conservatism.DisplayMember = "conservatism";
            cmb_build_conservatism.ValueMember = "conservatism";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                BL.cls_building.cls_unit cls_unit = new BL.cls_building.cls_unit();
                BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

                int build_id_max;


                this.dgv_get_max_build_Id.DataSource = cls_building.B_Get_max_build_Id();
                build_id_max = int.Parse(dgv_get_max_build_Id.Rows[0].Cells[0].Value.ToString());

                cls_unit.B_Add_Request_Rent_Unit(build_id_max, "", "", "0", "0", "0", "0", "", "", "0","لم تنفذ");
                //MessageBox.Show("تم اضافة طلب تاجير الوحدة بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = 0;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            add_customer add_cust = new add_customer();
            add_cust.ShowDialog();
        }

        int count = 0;
        private void btn_save_build_Click(object sender, EventArgs e)
        {
          
            
            cls_building.B_Add_Build_Request_Resident(txt_build_name.Text, Convert.ToInt32(cmb_cust_name.SelectedValue.ToString()), cmb_build_conservatism.Text, cmb_build_city.Text, txt_build_square.Text, txt_build_street.Text,
                                     txt_build_price.Text, cmb_build_type.Text, txt_build_area.Text, txt_order_type.Text, txt_order_state.Text, txt_build_note.Text);
            MessageBox.Show("تم اضافة طلب الاستاجار بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            count = 1;
            btn_build_add_unit.Enabled = true;
        }

        private void cmb_build_conservatism_TextChanged(object sender, EventArgs e)
        {
            cmb_build_city.DataSource = cls_building.B_Get_All_Customer_City(1 + int.Parse(cmb_build_conservatism.SelectedIndex.ToString()));
            cmb_build_city.DisplayMember = "city";
            cmb_build_city.ValueMember = "city";
        }

        private void btn_build_add_unit_Click(object sender, EventArgs e)
        {
            Add_Build_Unit add_build_unit = new Add_Build_Unit();
            add_build_unit.ShowDialog();
        }

   
    }
}
