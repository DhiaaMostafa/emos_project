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

    public partial class update_customer : Form
    {
        public update_customer()
        {
            InitializeComponent();
        }
        PL.userinterface.interface_addData.add_user_employee add_user = new interface_addData.add_user_employee();

        BL.cls_customer cc = new BL.cls_customer();
        BL.cls_customer_type cct = new BL.cls_customer_type();
        
        private void button11_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btn_cust_update_Click(object sender, EventArgs e)
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

        private void update_customer_Load(object sender, EventArgs e)
        {
            cmb_cust_type.DataSource = cct.Get_All_Cust_Type();
            cmb_cust_type.DisplayMember = "type_name";
            cmb_cust_type.ValueMember = "Id";

            cmb_cust_conservatism.DataSource = cc.Get_All_Cust_Conservatism();
            cmb_cust_conservatism.DisplayMember = "conservatism";
            cmb_cust_conservatism.ValueMember = "conservatism";


            // من اجال اخذ رقم النوع للعميل من استخدامة في تعبئة الكمبوبكس اثناء التعديل 
            BL.cls_customer cls_customer=new BL.cls_customer();
            dgv.DataSource = cls_customer.Get_Cust_Type_Id(Convert.ToInt32( txt_cust_id.Text.ToString()));
            interview_cust c = new interview_cust();
            txt_get_id.Text = dgv.Rows[0].Cells[0].Value.ToString();
            cmb_cust_type.SelectedIndex = Convert.ToInt32(txt_get_id.Text) - 1;



            



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

        private void cmb_cust_conservatism_TextChanged(object sender, EventArgs e)
        {
            cmb_cust_city.DataSource = cc.Get_All_Customer_City(1 + int.Parse(cmb_cust_conservatism.SelectedIndex.ToString()));
            cmb_cust_city.DisplayMember = "city";
            cmb_cust_city.ValueMember = "city";
        }

        private void btn_add_partner_Click(object sender, EventArgs e)
        {

            interview_view_partner view_partners = new interview_view_partner();
            view_partners.txt_cust_id.Text = this.txt_cust_id.Text;
            view_partners.ShowDialog();


         
        }

        BL.cls_user_account cls_user_account = new BL.cls_user_account();
        private void btn_add_cust_account_Click(object sender, EventArgs e)
        {
            // لفحص ما اذا كان العميل لدية حساب يريد تعديلة ام لا 
            PL.userinterface.interface_update.update_user_account_emp update_user_account_emp = new update_user_account_emp();
            


            DataTable DT= new DataTable();
            DT = cls_user_account.Get_User_Account_Info(Convert.ToInt32(txt_cust_id.Text.ToString()));

            if (DT.Rows.Count > 0)
            {
                DataGridView d = new DataGridView();
                d.DataSource = DT;
                update_user_account_emp.dgv_account_info.DataSource = DT;

                update_user_account_emp.ShowDialog();

            }
            else
            {
                MessageBox.Show("ليس لديك حساب مستخدم لتعديلة يجب عليك اضافة حساب مستخدم اولا");
                add_user.ShowDialog();
            }
        }
    }
}
