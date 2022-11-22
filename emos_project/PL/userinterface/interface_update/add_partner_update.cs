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

namespace emos_project.PL.userinterface.interface_update
{
    public partial class add_partner_update : Form
    {
        public add_partner_update()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_p_save_Click(object sender, EventArgs e)
        {
            BL.cls_partner ap = new BL.cls_partner();

            //for checking if there is an image or not 
            byte[] imag;
            MemoryStream ms = new MemoryStream();
            pic_partner.Image.Save(ms, pic_partner.Image.RawFormat);
            imag = ms.ToArray();

            ap.Add_Partner(Convert.ToInt32(txt_cust_id.Text.ToString()), txt_p_name.Text, txt_p_phone.Text, txt_p_note.Text, imag);
            MessageBox.Show("تمت عملية اضافة الشريك بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void add_partner_update_Load(object sender, EventArgs e)
        {
            //BL.cls_partner cl_partner = new BL.cls_partner();
            //byte[] imag = (byte[])cl_partner.Get_Image_Partner(Convert.ToInt32(this.txt_p_id.Text.ToString())).Rows[0][0];
            //MemoryStream ms = new MemoryStream(imag);
            //pic_partner.Image = Image.FromStream(ms);

           
        }

        private void btn_add_cust_image_Click(object sender, EventArgs e)
        {

            //for adding image into the project 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور |*.jpg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_partner.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_p_update_Click(object sender, EventArgs e)
        {
            //

            try
            {
            
                //for checking if there is an image or not 
                byte[] imag;

                MemoryStream ms = new MemoryStream();
                pic_partner.Image.Save(ms, pic_partner.Image.RawFormat);
                imag = ms.ToArray();

                BL.cls_partner cls_update_partner=new BL.cls_partner();

                cls_update_partner.Update_Customer_Partner(Convert.ToInt32(txt_p_id.Text), Convert.ToInt32(txt_cust_id.Text), txt_p_name.Text, imag, txt_p_note.Text, txt_p_phone.Text);

                MessageBox.Show("تم التعديل بنجاح");
            }
            catch
            {

            }
        }
    }
}
