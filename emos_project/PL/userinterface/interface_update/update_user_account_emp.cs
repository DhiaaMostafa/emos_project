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
    public partial class update_user_account_emp : Form
    {
        public update_user_account_emp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void update_user_account_emp_Load(object sender, EventArgs e)
        {
            txt_user_name.Text = dgv_account_info.Rows[0].Cells[2].Value.ToString();
            
            cmb_user_permision.Text = "";
            cmb_user_satus.Text = "";

            cmb_user_permision.Text = dgv_account_info.Rows[0].Cells[4].Value.ToString();
            cmb_user_satus.Text = dgv_account_info.Rows[0].Cells[5].Value.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string old_pass = dgv_account_info.Rows[0].Cells[3].Value.ToString();

            if (old_pass == txt_user_pass_old.Text)
            {
                //

                try
                {
                    
                    int account_id=Convert.ToInt32(dgv_account_info.Rows[0].Cells[0].Value.ToString());
                    txt_cust_Id.Text = dgv_account_info.Rows[0].Cells[1].Value.ToString();

                    BL.cls_user_account user_account = new BL.cls_user_account();
                    user_account.Update_User_Account(account_id,Convert.ToInt32(txt_cust_Id.Text), txt_user_name.Text, txt_user_pass_new.Text, cmb_user_permision.Text, cmb_user_satus.Text);
                    MessageBox.Show("تم التعديل بنجاح");
                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("كلمة المرور القديمة غير صالحة");
                txt_user_pass_old.Text = "";
                txt_user_pass_new.Text = "";
                txt_user_pass_valid.Text = "";
                txt_user_pass_old.Focus();
               
            }
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
