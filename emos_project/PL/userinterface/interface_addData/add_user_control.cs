using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.userinterface.interface_addData
{
    public partial class add_user_control : Form
    {
        public add_user_control()
        {
            InitializeComponent();
        }

        BL.cls_customer cls_cust = new BL.cls_customer();
        BL.cls_user_account cls_user_account = new BL.cls_user_account();
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text != "" && txt_user_pass.Text != "" && txt_user_pass_valid.Text != "")
            {
                cls_user_account.Add_User_Account(Convert.ToInt32(cmb_emp_name.SelectedValue.ToString()), txt_user_name.Text, txt_user_pass.Text, cmb_user_permision.Text.ToString(), cmb_user_satus.Text.ToString());
                MessageBox.Show("تمت اضافة حساب المستخدم بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("يجب تعبئة الحقول كاملة");
                txt_user_pass.Text = "";
                txt_user_pass_valid.Text = "";
                txt_user_name.Focus();

            }
        }

        private void txt_user_pass_valid_Validated(object sender, EventArgs e)
        {
            if (txt_user_pass.Text != txt_user_pass_valid.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة الرجاء المحاولة");
                txt_user_pass.Text = "";
                txt_user_pass_valid.Text = "";
                txt_user_pass.Focus();
            }
            else
            {

            }
        }

        private void add_user_Load(object sender, EventArgs e)
        {
            cmb_emp_name.DataSource = cls_cust.Get_All_Cust_Name();
            cmb_emp_name.DisplayMember = "cust_name";
            cmb_emp_name.ValueMember = "Id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
