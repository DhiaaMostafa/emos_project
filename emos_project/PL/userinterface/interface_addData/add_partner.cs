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

namespace emos_project.PL.userinterface.interface_addData
{
    public partial class add_partner : Form
    {
        public add_partner()
        {
            InitializeComponent();
        }

        //لاخذ رقم العميل من الداتا جريد فيوا من اجل استخدامة في الحفظ
        public static int cust_id;

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
            btn_p_save.Visible = true;
        }

      
        private void btn_p_save_Click(object sender, EventArgs e)
        {
            BL.cls_partner ap = new BL.cls_partner();

            //for checking if there is an image or not 
            byte[] imag;
            MemoryStream ms = new MemoryStream();
            pic_partner.Image.Save(ms, pic_partner.Image.RawFormat);
            imag = ms.ToArray();

            ap.Add_Partner(cust_id, txt_p_name.Text, txt_p_phone.Text, txt_p_note.Text,imag);

            MessageBox.Show("تمت عملية اضافة الشريك بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void add_partner_Load(object sender, EventArgs e)
        {
            //لاخذ اكبر رقم عميل من اجل اضافة شريك له عبر اجراء
            BL.cls_customer cc = new BL.cls_customer();
            this.dgv_get_max_cust.DataSource = cc.Get_max();
             cust_id = int.Parse(dgv_get_max_cust.Rows[0].Cells[0].Value.ToString());

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
