using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.bin
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }
        classes.BL.cls_login login = new classes.BL.cls_login();
        bin.form_main main_form = new form_main();
        private void button1_Click(object sender, EventArgs e)
        {
            //code button ok in interface login
            DataTable dt = login.login(txt_user_name.Text, txt_user_pass.Text);
            if (dt.Rows.Count > 0)
            {
                main_form.dgv_user_info.DataSource = login.User_Account_Info(txt_user_name.Text, txt_user_pass.Text);


                main_form.ShowDialog();

                Close();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void txt_user_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void circular_picturebox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

