using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace emos_project
{
    public partial class select_cust : Form
    {
        BL.cls_customer cls_cust = new BL.cls_customer();


        public select_cust()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = cls_cust.Get_All_Cust();
        }

        add_customer adc = new add_customer();
        interview_cust frm = new interview_cust();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adc.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm.ShowDialog();
        }

        public void refresh()
        {
            lbl_buyer_count.Text ="0";
            lbl_cust_count.Text = "0";
            lbl_owner_count.Text = "0";
            lbl_resident_count.Text = "0";

            BL.cls_counter counter = new BL.cls_counter();

            lbl_resident_count.Text = Convert.ToString(counter.Get_All_Resident_Counts());
            lbl_cust_count.Text = Convert.ToString(counter.Get_All_Customer_Counts());
            lbl_buyer_count.Text = Convert.ToString(counter.Get_All_buyer_Counts());
            lbl_owner_count.Text = Convert.ToString(counter.Get_All_owner_Counts());
            
        }

        private void select_cust_Load(object sender, EventArgs e)
        {


            refresh();


        }

        private void circular_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف العميل المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_cust.Delete_Customer(Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cls_cust.Get_All_Cust();

                //من اجل تحديث الاعداد الخاصة باعداد العلاء والمستاجرين وغيرة
                select_cust s = new select_cust();
                s.refresh();
            }
            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void circular_button2_Click(object sender, EventArgs e)
        {
            interview_cust view_cust = new interview_cust();

            int cust_Id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            view_cust.dgv_cust_info.DataSource = cls_cust.Get_Cust_Info(cust_Id);
            //for updateing customer
            PL.userinterface.interface_update.update_customer update_cust = new PL.userinterface.interface_update.update_customer();

            update_cust.txt_cust_id.Text = view_cust.dgv_cust_info.Rows[0].Cells[0].Value.ToString();
            update_cust.txt_cust_name.Text =view_cust.dgv_cust_info.Rows[0].Cells[1].Value.ToString();
            update_cust.txt_cust_card_no.Text = view_cust.dgv_cust_info.Rows[0].Cells[2].Value.ToString();
            update_cust.txt_cust_card_loc.Text = view_cust.dgv_cust_info.Rows[0].Cells[3].Value.ToString();
            update_cust.dtp_card_date.Text = view_cust.dgv_cust_info.Rows[0].Cells[4].Value.ToString();

            update_cust.cmb_cust_conservatism.Text = view_cust.dgv_cust_info.Rows[0].Cells[5].Value.ToString();
            update_cust.cmb_cust_city.Text = view_cust.dgv_cust_info.Rows[0].Cells[6].Value.ToString();
            update_cust.txt_cust_squar.Text = view_cust.dgv_cust_info.Rows[0].Cells[7].Value.ToString();
            update_cust.txt_cust_street.Text = view_cust.dgv_cust_info.Rows[0].Cells[8].Value.ToString();
            update_cust.txt_cust_tel.Text = view_cust.dgv_cust_info.Rows[0].Cells[9].Value.ToString();

            update_cust.txt_cust_phone.Text = view_cust.dgv_cust_info.Rows[0].Cells[10].Value.ToString();
            update_cust.txt_cust_email.Text = view_cust.dgv_cust_info.Rows[0].Cells[11].Value.ToString();
            //pic_cust.Image = dgv_cust_info.Rows[0].Cells[12].Value.ToString();
            update_cust.txt_cust_note.Text = view_cust.dgv_cust_info.Rows[0].Cells[13].Value.ToString();
            update_cust.txt_cust_auctioneer.Text = view_cust.dgv_cust_info.Rows[0].Cells[14].Value.ToString();
            update_cust.txt_cust_agent.Text = view_cust.dgv_cust_info.Rows[0].Cells[15].Value.ToString();
            //update_cust.cmb_cust_type.SelectedIndex = Convert.ToInt32(view_cust.dgv_cust_info.Rows[0].Cells[16].Value.ToString())-1;
            //update_cust.cmb_cust_type.SelectedIndex = 2;
            //update_cust.cmb_cust_type.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();



            int cust_idimg = Convert.ToInt32(view_cust.dgv_cust_info.Rows[0].Cells[0].Value.ToString());
            byte[] cust_image = (byte[])cls_cust.View_Image(cust_idimg).Rows[0][0];
            MemoryStream ms = new MemoryStream(cust_image);
            update_cust.pic_cust.Image = Image.FromStream(ms);
            
            update_cust.ShowDialog();



        }

        private void circular_button5_Click(object sender, EventArgs e)
        {

            adc.ShowDialog();
        
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
      

        private void btn_all_cust_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_Cust();

        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_seller();

        }

        private void btn_buyers_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_buyer();

        }

        private void btn_residents_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_Residents();

        }

        private void btn_renters_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_Renters();

        }

        private void btn_agents_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_Agents();

        }

        private void btn_auctioneer_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cls_cust.Get_All_Auctioneers();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            interview_cust view_cust = new interview_cust();

            int cust_Id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            view_cust.txt_cust_id.Text = cust_Id.ToString();
            view_cust.dgv_cust_info.DataSource=cls_cust.Get_Cust_Info(cust_Id);

            view_cust.dgv_request_build.DataSource = cls_cust.Get_All_Request_Build(cust_Id);
            view_cust.dgv_request_land.DataSource = cls_cust.Get_All_Request_Land(cust_Id);
            
            view_cust.ShowDialog();
            

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circular_button4_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = cls_cust.Search_Customer(txtbox_search.Text);
            this.dataGridView1.DataSource = DT;
        }
    }
}
