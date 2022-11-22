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

namespace emos_project
{
    public partial class interview_cust : Form
    {
        public interview_cust()
        {
            InitializeComponent();
        }

        BL.cls_customer cc = new BL.cls_customer();

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

       

        private void button11_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_cust_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void interview_cust_Load(object sender, EventArgs e)
        {
            txt_cust_name.Text = dgv_cust_info.Rows[0].Cells[1].Value.ToString();
            txt_cust_card_no.Text = dgv_cust_info.Rows[0].Cells[2].Value.ToString();
            txt_cust_card_loc.Text = dgv_cust_info.Rows[0].Cells[3].Value.ToString();
            txt_cust_card_date.Text = dgv_cust_info.Rows[0].Cells[4].Value.ToString();
            txt_cust_conservatism.Text = dgv_cust_info.Rows[0].Cells[5].Value.ToString();
            txt_cust_city.Text = dgv_cust_info.Rows[0].Cells[6].Value.ToString();
            txt_cust_squar.Text = dgv_cust_info.Rows[0].Cells[7].Value.ToString();
            txt_cust_street.Text = dgv_cust_info.Rows[0].Cells[8].Value.ToString();
            txt_cust_tel.Text = dgv_cust_info.Rows[0].Cells[9].Value.ToString();
            txt_cust_phone.Text = dgv_cust_info.Rows[0].Cells[10].Value.ToString();
            txt_cust_email.Text = dgv_cust_info.Rows[0].Cells[11].Value.ToString();
            //pic_cust.Image = dgv_cust_info.Rows[0].Cells[12].Value.ToString();
            txt_cust_note.Text = dgv_cust_info.Rows[0].Cells[13].Value.ToString();
            txt_cust_auctioneer.Text = dgv_cust_info.Rows[0].Cells[14].Value.ToString();
            txt_cust_agent.Text = dgv_cust_info.Rows[0].Cells[15].Value.ToString();
            txt_cust_type.Text = dgv_cust_info.Rows[0].Cells[16].Value.ToString();

            int cust_idimg = Convert.ToInt32(dgv_cust_info.Rows[0].Cells[0].Value.ToString());
            byte[] cust_image = (byte[])cc.View_Image(cust_idimg).Rows[0][0];
            MemoryStream ms = new MemoryStream(cust_image);
            pic_cust.Image = Image.FromStream(ms);

            if (dgv_request_build.Rows[0].Cells[0].Value != null)
            {
                int build_Id = Convert.ToInt32(dgv_request_build.Rows[0].Cells[0].Value.ToString());
                BL.cls_building.cls_unit cls_unit = new BL.cls_building.cls_unit();
                dgv_request_unit.DataSource = cls_unit.B_Get_All_Unit_In_Build(build_Id);
            }
            else
            {
                

            }

        }

        PL.userinterface.interface_update.update_customer update_cust = new PL.userinterface.interface_update.update_customer();
        //add_customer update_cust = new add_customer();
        private void button1_Click(object sender, EventArgs e)
        {
            update_cust.txt_cust_id.Text = dgv_cust_info.Rows[0].Cells[0].Value.ToString();
            update_cust.txt_cust_name.Text = dgv_cust_info.Rows[0].Cells[1].Value.ToString();
            update_cust.txt_cust_card_no.Text = dgv_cust_info.Rows[0].Cells[2].Value.ToString();
            update_cust.txt_cust_card_loc.Text = dgv_cust_info.Rows[0].Cells[3].Value.ToString();
            update_cust.cmb_cust_conservatism.Text = dgv_cust_info.Rows[0].Cells[5].Value.ToString();
            update_cust.cmb_cust_city.Text = dgv_cust_info.Rows[0].Cells[6].Value.ToString();
            update_cust.txt_cust_squar.Text = dgv_cust_info.Rows[0].Cells[7].Value.ToString();
            update_cust.txt_cust_street.Text = dgv_cust_info.Rows[0].Cells[8].Value.ToString();
            update_cust.txt_cust_tel.Text = dgv_cust_info.Rows[0].Cells[9].Value.ToString();
            update_cust.txt_cust_phone.Text = dgv_cust_info.Rows[0].Cells[10].Value.ToString();
            update_cust.txt_cust_email.Text = dgv_cust_info.Rows[0].Cells[11].Value.ToString();
            //pic_cust.Image = dgv_cust_info.Rows[0].Cells[12].Value.ToString();
            update_cust.txt_cust_note.Text = dgv_cust_info.Rows[0].Cells[13].Value.ToString();
            update_cust.txt_cust_auctioneer.Text = dgv_cust_info.Rows[0].Cells[14].Value.ToString();
            update_cust.txt_cust_agent.Text = dgv_cust_info.Rows[0].Cells[15].Value.ToString();
            update_cust.cmb_cust_type.Text = dgv_cust_info.Rows[0].Cells[16].Value.ToString();
            
            update_cust.ShowDialog();

          
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            BL.cls_partner cls_partner = new BL.cls_partner();
            //int cust_Id = Convert.ToInt16(dgv_cust_info.Rows[0].Cells[0].Value.ToString());


            dgv_show_partner.DataSource = cls_partner.Get_Cust_Partner(int.Parse(txt_cust_id.Text));

        }

        private void txt_cust_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_show_partner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_show_partner_DoubleClick(object sender, EventArgs e)
        {
            BL.cls_partner cl_partner=new BL.cls_partner();
            byte[] imag = (byte[])cl_partner.Get_Image_Partner(Convert.ToInt32( this.dgv_show_partner.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(imag);
            PL.userinterface.interface_view.interview_partner_image vpimage = new PL.userinterface.interface_view.interview_partner_image();
            vpimage.pictureBox1.Image = Image.FromStream(ms);
            vpimage.ShowDialog();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgv_request_build_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_request_build.Rows[0].Cells[0].Value == null)
            {
                
            }
            else
            {
                int build_Id = Convert.ToInt32(dgv_request_build.CurrentRow.Cells[0].Value.ToString());
                BL.cls_building.cls_unit cls_unit = new BL.cls_building.cls_unit();
                dgv_request_unit.DataSource= cls_unit.B_Get_All_Unit_In_Build(build_Id);

            }
        }
    }
}
