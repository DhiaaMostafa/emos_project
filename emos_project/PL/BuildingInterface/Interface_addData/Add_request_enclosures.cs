using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace emos_project.PL.BuildingInterface.Interface_addData
{
    public partial class Add_request_enclosures : Form
    {
        public Add_request_enclosures()
        {
            InitializeComponent();
        }

        public string add_build = "";
        public string add_unit = "";

        BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();
        BL.cls_building.cls_unit cls_unit = new BL.cls_building.cls_unit();

        public int build_Id_max;
        public int build_unit_max;

        private void Add_request_enclosures_Load(object sender, EventArgs e)
        {

            MessageBox.Show(build_unit_max.ToString());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for adding image into the project 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور |*.jpg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_request_enclosures.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {
           

            //for checking if there is an image or not 
            byte[] imag;
            MemoryStream ms = new MemoryStream();
            pic_request_enclosures.Image.Save(ms, pic_request_enclosures.Image.RawFormat);
            imag = ms.ToArray();


            if (build_Id_max!=0)
            {
                //تابع للعقار
                build_Id_max = int.Parse(dgv_get_max_build_Id.Rows[0].Cells[0].Value.ToString());

                cls_building.B_Add_Build_Image(build_Id_max, imag);
                MessageBox.Show("تمت اضافة المرفق  بنجاح", "عملية اضافة مرفق", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
                if (build_unit_max!=0)
                {
                    //تابع للوحدة
                    build_unit_max = int.Parse(dgv_get_max_unit_Id.Rows[0].Cells[0].Value.ToString());
                    cls_unit.B_Add_Unit_Image(build_unit_max, imag);
                    MessageBox.Show("تمت اضافة المرفق  بنجاح", "عملية اضافة مرفق", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            
           






             



        }

      
    }
}
