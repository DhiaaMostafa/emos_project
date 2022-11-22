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
    public partial class interview_view_partner : Form
    {
        public interview_view_partner()
        {
            InitializeComponent();
        }
        BL.cls_customer cls = new BL.cls_customer();

        private void dgv_show_partner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void circular_button5_Click(object sender, EventArgs e)
        {
            
            PL.userinterface.interface_update.add_partner_update add_partner = new add_partner_update();
            add_partner.txt_cust_id.Text = this.txt_cust_id.Text;

            add_partner.btn_p_update.Visible = false;
            add_partner.btn_p_update.Enabled = false;
            add_partner.btn_p_save.Visible = true;
            add_partner.btn_p_save.Enabled = true;

            add_partner.ShowDialog();

        }
        BL.cls_partner cls_partner = new BL.cls_partner();

        private void interview_view_partner_Load(object sender, EventArgs e)
        {
            //int cust_Id = Convert.ToInt16(dgv_cust_info.Rows[0].Cells[0].Value.ToString());
            dgv_show_partner.DataSource = cls_partner.Get_Cust_Partner(int.Parse(txt_cust_id.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circular_button2_Click(object sender, EventArgs e)
        {
            add_partner_update add_partner = new add_partner_update();
            add_partner.txt_cust_id.Text = this.txt_cust_id.Text;

            //لنقل البيانات الي واجهة التعديل 
            add_partner.txt_p_id.Text = this.dgv_show_partner.CurrentRow.Cells[0].Value.ToString();
            add_partner.txt_p_name.Text = this.dgv_show_partner.CurrentRow.Cells[1].Value.ToString();
            add_partner.txt_p_phone.Text = this.dgv_show_partner.CurrentRow.Cells[2].Value.ToString();
            add_partner.txt_p_note.Text = this.dgv_show_partner.CurrentRow.Cells[3].Value.ToString();

            //لعرض الصورة للشريك المراد تعديلة 

            BL.cls_partner cl_partner = new BL.cls_partner();
            byte[] imag = (byte[])cl_partner.Get_Image_Partner(Convert.ToInt32(this.dgv_show_partner.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(imag);
            add_partner.pic_partner.Image = Image.FromStream(ms);


            //واجهة واحدة للاضافة والتعديل لبيانات الشريك عبر عرض زر الحفظ مع الاضافة وزر التعديل مع التعديل بواجهة واحدة
            add_partner.btn_p_update.Visible = true;
            add_partner.btn_p_update.Enabled = true;
            add_partner.btn_p_save.Visible = false;
            add_partner.btn_p_save.Enabled = false;
            add_partner.ShowDialog();


            //view_cust.dgv_cust_info.DataSource = cls_cust.Get_Cust_Info(cust_Id);

        }

        private void circular_button4_Click(object sender, EventArgs e)
        {
            BL.cls_partner cl_partner = new BL.cls_partner();
            byte[] imag = (byte[])cl_partner.Get_Image_Partner(Convert.ToInt32(this.dgv_show_partner.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(imag);
            PL.userinterface.interface_view.interview_partner_image vpimage = new PL.userinterface.interface_view.interview_partner_image();
            vpimage.pictureBox1.Image = Image.FromStream(ms);
            vpimage.ShowDialog();
        }

        private void circular_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف العميل المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.Delete_Customer_Partner(Convert.ToInt32(dgv_show_partner.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_show_partner.DataSource = cls_partner.Get_Cust_Partner(int.Parse(txt_cust_id.Text));
            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
