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


namespace emos_project.PL.Land_Interface.Interface_Add_Data
{
    
    public partial class Win_Add_Request_Enclosures_Land : Form
    {
        public int land_id_max;
        BL.cls_land.cls_land cls_land=new BL.cls_land.cls_land();
        public Win_Add_Request_Enclosures_Land()
        {
            InitializeComponent();
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
            byte[] imag;
            MemoryStream ms = new MemoryStream();
            pic_request_enclosures.Image.Save(ms, pic_request_enclosures.Image.RawFormat);
            imag = ms.ToArray();


            
                    //تابع للارض

                   int land_id = int.Parse(dgv_get_max_land_Id.Rows[0].Cells[0].Value.ToString());

                    cls_land.L_Add_Land_Image(land_id, imag);
                    MessageBox.Show("تمت اضافة المرفق  بنجاح", "عملية اضافة مرفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //build_Id_max = 0;

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
