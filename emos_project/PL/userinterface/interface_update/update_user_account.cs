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
    public partial class update_user_account : Form
    {
        public update_user_account()
        {
            InitializeComponent();
        }

        private void update_user_account_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void circular_button2_Click(object sender, EventArgs e)
        {
            // لفحص ما اذا كان العميل لدية حساب يريد تعديلة ام لا 
            PL.userinterface.interface_update.update_user_acount_control update_user = new PL.userinterface.interface_update.update_user_acount_control();
            //BL.cls_user_account cls_user_account = new BL.cls_user_account();
            update_user.txt_user_id.Text = dgv_user_account.CurrentRow.Cells[0].Value.ToString();
            update_user.txt_cust_name.Text = dgv_user_account.CurrentRow.Cells[1].Value.ToString();
            update_user.txt_user_name.Text = dgv_user_account.CurrentRow.Cells[2].Value.ToString();
            update_user.cmb_user_permision.Text = dgv_user_account.CurrentRow.Cells[4].Value.ToString();
            update_user.cmb_user_satus.Text = dgv_user_account.CurrentRow.Cells[5].Value.ToString();
            
            update_user.ShowDialog();
        }

        private void dgv_user_account_DoubleClick(object sender, EventArgs e)
        {

        }

        private void circular_button1_Click(object sender, EventArgs e)
        {
            BL.cls_user_account cls_user = new BL.cls_user_account();
           
            dgv_user_account.DataSource = cls_user.Get_All_User_Account();
        }
    }
}
