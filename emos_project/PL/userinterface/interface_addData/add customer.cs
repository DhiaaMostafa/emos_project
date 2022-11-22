using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace emos_project
{
    public partial class add_customer : Form
    {
       

        public add_customer()
        {
            InitializeComponent();
           
        }
        BL.cls_customer cc = new BL.cls_customer();
        BL.cls_customer_type cct = new BL.cls_customer_type();
        
   
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            btn_cust_save.Visible = true;
            btn_add_partner.Enabled = false;
            btn_add_cust_account.Enabled = false;


            select_cust s = new select_cust();
            s.dataGridView1.DataSource = cls_cust.Get_All_Cust();
            s.refresh();
            s.Refresh();
            Close();

        }

    

        private void add_customer_Load(object sender, EventArgs e)
        {
            cmb_cust_type.DataSource = cct.Get_All_Cust_Type();
            cmb_cust_type.DisplayMember = "type_name";
            cmb_cust_type.ValueMember = "Id";

            cmb_cust_conservatism.DataSource = cc.Get_All_Cust_Conservatism();
            cmb_cust_conservatism.DisplayMember = "conservatism";
            cmb_cust_conservatism.ValueMember = "conservatism";




        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void txttel_Validating(object sender, CancelEventArgs e)
        {
        }

        private void cmbxtype_Validating(object sender, CancelEventArgs e)
        {
           
        }

    

        private void add_customer_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //

            try
            {
                //لفحص الرقم نوع العميل والتاكد من انه قد تم اختيارة ام لا اذا لا يتم اسناد العميل الي النوع رقم واحد كقيمة افتراضية من نوع عميل
                int cust_type_id = cmb_cust_type.SelectedText == null ? 1 : 1 + int.Parse(cmb_cust_type.SelectedIndex.ToString());

                //for getting data from the interface
                string date = dtp_card_date.Value.ToString();

                //for checking if there is an image or not 
                byte[] imag;

                MemoryStream ms = new MemoryStream();
                pic_cust.Image.Save(ms, pic_cust.Image.RawFormat);
                imag = ms.ToArray();

                //cc.Update_Customer(Convert.ToInt32(txt_cust_id.Text), txt_cust_name.Text.ToString(), txt_cust_card_no.Text.ToString(), txt_cust_card_loc.Text.ToString(),
                //cmb_cust_conservatism.Text.ToString(), cmb_cust_city.Text.ToString(), txt_cust_squar.Text.ToString(), txt_cust_street.Text.ToString(),
                //txt_cust_phone.Text.ToString(), txt_cust_tel.Text.ToString(), txt_cust_email.Text.ToString(), txt_cust_note.Text, txt_cust_auctioneer.Text,
                //txt_cust_agent.Text, cust_type_id, date, imag);

                cc.Update_Customer(Convert.ToInt32(txt_cust_id.Text), txt_cust_name.Text.ToString(), txt_cust_card_no.Text.ToString(), txt_cust_card_loc.Text.ToString(),
                   cmb_cust_conservatism.Text.ToString(), cmb_cust_city.Text.ToString(), txt_cust_squar.Text.ToString(), txt_cust_street.Text.ToString(), txt_cust_tel.Text.ToString(),
                   txt_cust_phone.Text.ToString(), txt_cust_email.Text.ToString(), txt_cust_note.Text.ToString(), txt_cust_auctioneer.Text.ToString(),
                   txt_cust_agent.Text.ToString(), cust_type_id, date, imag);
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        BL.cls_customer cls_cust = new BL.cls_customer();

        private void btn_cust_save_Click(object sender, EventArgs e)
        {
            try
            {
                //لفحص الرقم نوع العميل والتاكد من انه قد تم اختيارة ام لا اذا لا يتم اسناد العميل الي النوع رقم واحد كقيمة افتراضية من نوع عميل
                int cust_type_id = cmb_cust_type.SelectedText == null ? 1 : 1 + int.Parse(cmb_cust_type.SelectedIndex.ToString());

                //for getting data from the interface
                string date = dtp_card_date.Value.ToString();

                //for checking if there is an image or not 
                byte[] imag;
                MemoryStream ms = new MemoryStream();
                pic_cust.Image.Save(ms, pic_cust.Image.RawFormat);
                imag = ms.ToArray();


                cc.Add_Customer(txt_cust_name.Text.ToString(), txt_cust_card_no.Text.ToString(), txt_cust_card_loc.Text.ToString(),
                cmb_cust_conservatism.Text.ToString(), cmb_cust_city.Text.ToString(), txt_cust_squar.Text.ToString(), txt_cust_street.Text.ToString(),
                txt_cust_tel.Text.ToString() ,txt_cust_phone.Text.ToString(), txt_cust_email.Text.ToString(), txt_cust_note.Text, txt_cust_auctioneer.Text,
                txt_cust_agent.Text, cust_type_id, date, imag);

                MessageBox.Show("تمت اضافة العميل بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_add_partner.Enabled = true;

                if (cmb_cust_type.Text == "موظف")
                {
                    btn_add_cust_account.Enabled = true;

                }


            }
            catch
            {
                return;
            }
            finally
            {
                select_cust s_cust = new select_cust();
                s_cust.dataGridView1.DataSource= cls_cust.Get_All_Cust();

            }
           
        
        }

        private void btn_add_cust_image_Click(object sender, EventArgs e)
        {
            //for adding image into the project 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور |*.jpg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_cust.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_add_partner_Click(object sender, EventArgs e)
        {
            PL.userinterface.interface_addData.add_partner add_partner = new PL.userinterface.interface_addData.add_partner();
            
            add_partner.ShowDialog();
            
        }

        private void cmb_cust_conservatism_TextChanged(object sender, EventArgs e)
        {
            cmb_cust_city.DataSource = cc.Get_All_Customer_City(1+int.Parse(cmb_cust_conservatism.SelectedIndex.ToString()));
            cmb_cust_city.DisplayMember = "city";
            cmb_cust_city.ValueMember = "city";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_cust_account_Click(object sender, EventArgs e)
        {
            PL.userinterface.interface_addData.add_user_employee add_user_emp = new PL.userinterface.interface_addData.add_user_employee();
            add_user_emp.ShowDialog();
        }

        private void cmb_cust_type_Validated(object sender, EventArgs e)
        {
           
        }

       
    }
}
