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
    public partial class Add_Build_Unit : Form
    {
        public Add_Build_Unit()
        {
            InitializeComponent();
        }
        BL.cls_building.cls_unit cls_unit = new BL.cls_building.cls_unit();
        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

        int build_id_max;
        int build_unit_max;


        private void Add_Build_Unit_Load(object sender, EventArgs e)
        {

            this.dgv_get_max_build_Id.DataSource = cls_building.B_Get_max_build_Id();
            build_id_max = int.Parse(dgv_get_max_build_Id.Rows[0].Cells[0].Value.ToString());
        }
        private void btn_save_build_Click(object sender, EventArgs e)
        {
            cls_unit.B_Add_Request_Rent_Unit(build_id_max, txt_unit_name.Text, txt_unit_price.Text, nud_living_room.Value.ToString(), nud_bed_room.Value.ToString(), nud_bath_room.Value.ToString(), nud_ketchen.Value.ToString(), txt_round_area.Text, txt_unit_note.Text, nud_room_number.Value.ToString(),txt_unit_state.Text);
            MessageBox.Show("تم اضافة طلب تاجير الوحدة بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_unit_add_enclosure.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_unit_add_enclosure_Click(object sender, EventArgs e)
        {
            Add_request_enclosures add_enclosures = new Add_request_enclosures();

             add_enclosures.dgv_get_max_unit_Id.DataSource = cls_unit.B_Get_Max_Unit_Id();
             add_enclosures.build_unit_max= int.Parse(add_enclosures.dgv_get_max_unit_Id.Rows[0].Cells[0].Value.ToString());

             add_enclosures.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
