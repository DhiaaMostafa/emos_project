using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace emos_project.bin
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        PL.userinterface.interface_addData.add_user_control add_user = new PL.userinterface.interface_addData.add_user_control();

        classes.BL.cls_login login = new classes.BL.cls_login();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);
       
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 60;
               
               
            }
            else
            {
                menuVertical.Width = 250;
              
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            //lbl_user_name.Text = dgv_user_info.Rows[0].Cells[0].Value.ToString();
            //lbl_user_permission.Text = dgv_user_info.Rows[0].Cells[2].Value.ToString();

            //byte[] cust_image = (byte[])(dgv_user_info.Rows[0].Cells[1].Value);
            //MemoryStream ms = new MemoryStream(cust_image);
            //pic_user.Image = Image.FromStream(ms);

            abirforminpanel(new interface_view.menu_prime());
            menuVertical.Width = 250;
            btncust.Width = 250;
            btnunit.Width = 250;
            btnlease.Width = 250;
            btnaccount.Width = 250;
            btnreport.Width = 250;
            btnnotific.Width = 250;
            btnother.Width = 250;

            //if (lbl_user_permission.Text != "Admin")
            //{
            //    btn_add_user.Visible = false;
            //    btn_delete_user.Visible = false;
            //    btn_update_user.Visible = false;
            //}
        }

        public void abirforminpanel(object formhijo)
        {
            if(this.panelContainer.Controls.Count>0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }
        public void btncust_Click(object sender, EventArgs e)
        {
            abirforminpanel(new select_cust());
        }

        public int count = 0;

        public void btnunit_Click(object sender, EventArgs e)
        {

            abirforminpanel(new PL.BuildingInterface.Interface_selectData.Select_Building());

            //if (count == 0)
            //{
            //    abirforminpanel(new PL.BuildingInterface.Interface_selectData.main_select_request_all());
            //}
            //else
            //    if (count == 1)
            //    {
                  
            //    }
            //    else
            //        if (count == 2)
            //        {

            //        }
            //        else
            //            if (count == 3)
            //            {

            //            }
            //            else
            //                if (count == 4)
            //                {

            //                }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnotific_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void infouser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void barra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnother_Click(object sender, EventArgs e)
        {
            abirforminpanel(new PL.Reporting.Win_Report_All());
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            abirforminpanel(new PL.Land_Interface.Interface_Select_Data.Win_Select_Land());

        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            abirforminpanel(new PL.lease_land.Interface_Select_Data.Win_Select_Lease_Land());
        }

        private void btnlease_Click(object sender, EventArgs e)
        {
            abirforminpanel(new PL.Lease.Interface_Select_Data.Win_Select_Leases());

        }

        private void btn_res_Click(object sender, EventArgs e)
        {

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void circular_picturebox2_Click(object sender, EventArgs e)
        {

        }

        private void circular_picturebox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abirforminpanel(new interface_view.menu_prime());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            add_user.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BL.cls_user_account cls_user = new BL.cls_user_account();
            PL.userinterface.interface_update.update_user_account update_user = new PL.userinterface.interface_update.update_user_account();
            update_user.dgv_user_account.DataSource = cls_user.Get_All_User_Account();
            update_user.ShowDialog();






            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BL.cls_user_account cls_user=new BL.cls_user_account();
            PL.userinterface.interface_selectData.frm_select_user_account delete_user = new PL.userinterface.interface_selectData.frm_select_user_account();
            delete_user.dgv_user_account.DataSource = cls_user.Get_All_User_Account();
            delete_user.ShowDialog();
        }
    }
}
