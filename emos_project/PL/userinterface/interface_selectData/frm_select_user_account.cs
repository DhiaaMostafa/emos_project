using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.userinterface.interface_selectData
{
    public partial class frm_select_user_account : Form
    {
        public frm_select_user_account()
        {
            InitializeComponent();
        }
        BL.cls_user_account cls_user = new BL.cls_user_account();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void circular_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف العميل المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_user.Delete_User(Convert.ToInt32(dgv_user_account.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_user_account.DataSource = cls_user.Get_All_User_Account();

                //من اجل تحديث الاعداد الخاصة باعداد العلاء والمستاجرين وغيرة

            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frm_select_user_account_Load(object sender, EventArgs e)
        {

        }
    }
}
