using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.userinterface.interface_update
{
    public partial class update_user_acount_control : Form
    {
        BL.cls_customer cls_cust = new BL.cls_customer();
        public update_user_acount_control()
        {
            InitializeComponent();
        }

        private void update_user_acount_control_Load(object sender, EventArgs e)
        {

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


                try
                {
                    BL.cls_user_account user_account = new BL.cls_user_account();
                    user_account.Update_User_Account_control (Convert.ToInt16(txt_user_id.Text), txt_user_name.Text, txt_user_pass_new.Text, cmb_user_permision.Text, cmb_user_satus.Text);
                    MessageBox.Show("تم التعديل بنجاح");

                    this.Close();
                }
                catch
                {

                }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_user_pass_valid_Validated(object sender, EventArgs e)
        {
            if (txt_user_pass_new.Text != txt_user_pass_valid.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة الرجاء المحاولة");
                txt_user_pass_new.Text = "";
                txt_user_pass_valid.Text = "";
                txt_user_pass_new.Focus();
            }
            else
            {

            }
        }
    }
}
