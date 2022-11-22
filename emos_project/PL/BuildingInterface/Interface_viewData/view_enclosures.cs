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

namespace emos_project.PL.BuildingInterface.Interface_viewData
{
    public partial class view_enclosures : Form
    {
        public view_enclosures()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_image_unit_DoubleClick(object sender, EventArgs e)
        {
            BL.cls_land.cls_land cls_land = new BL.cls_land.cls_land();
            BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
            int image_id = Convert.ToInt32(dgv_image_unit.CurrentRow.Cells[0].Value.ToString());
            byte[] imag = (byte[])cls_land.L_View_Image_land(image_id).Rows[0][0];
            MemoryStream ms = new MemoryStream(imag);
            PL.Land_Interface.Interface_View_Data.win_view_image view_image = new Land_Interface.Interface_View_Data.win_view_image();
            view_image.pic_image_land.Image = Image.FromStream(ms);
            view_image.ShowDialog();
        }

        private void dgv_image_unit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
