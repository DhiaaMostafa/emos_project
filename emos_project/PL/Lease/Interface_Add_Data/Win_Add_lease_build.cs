using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emos_project.PL.Lease.Interface_Add_Data
{
    public partial class Win_Add_lease_build : Form
    {
        BL.cls_lease_build.cls_lease_build cls_lease_build = new BL.cls_lease_build.cls_lease_build();
        public Win_Add_lease_build()
        {
            InitializeComponent();
        }
        BL.cls_building.cls_buildings cls_build = new BL.cls_building.cls_buildings();

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_build_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_build_name_TextChanged(object sender, EventArgs e)
        {
//if (cmb_build_name.Text != "")
            //{
            //    cmb_unit_name.DataSource = cls_lease_build.Les_Get_All_Unit_Name();
            //    cmb_unit_name.DisplayMember = "unit_name";
            //    cmb_unit_name.ValueMember = "Id";

          //  }


        }

        private void cmb_build_name_SelectedValueChanged(object sender, EventArgs e)
        {
            
      

            

           
        }

        private void btn_save_build_Click_1(object sender, EventArgs e)
        {
            //if (cmb_unit_name.Text == "")
            //{
            //    cls_lease_build.Les_Add_Lease_Build_Without_Unit(Convert.ToInt32(cmb_cust_name.SelectedValue.ToString()), Convert.ToInt32(cmb_build_name.SelectedValue.ToString()), dtp_lease_write_date.Value.ToString(), dtp_lease_start_date.Value.ToString(), dtp_lease_end_date.Value.ToString(), txt_total_money.Text, txt_payed_money.Text, txt_inst_money.Text, dtp_date_pay_money.Value.ToString(), txt_clusing_percentage.Text, txt_estate_percentage.Text, cmb_pay_type.Text, txt_wat1.Text, txt_wat2.Text, txt_lease_type.Text, txt_note.Text);
            //    MessageBox.Show("تم اضافة عقدالتاجير بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{


                cls_lease_build.Les_Add_Lease_Build(Convert.ToInt32(cmb_cust_name.SelectedValue.ToString()), Convert.ToInt32(cmb_build_name.SelectedValue.ToString()), Convert.ToInt32(cmb_unit_name.SelectedValue.ToString()), dtp_lease_write_date.Value.ToString(), dtp_lease_start_date.Value.ToString(), dtp_lease_end_date.Value.ToString(), txt_total_money.Text, txt_payed_money.Text, txt_inst_money.Text, dtp_date_pay_money.Value.ToString(), txt_clusing_percentage.Text, txt_estate_percentage.Text, cmb_pay_type.Text, txt_wat1.Text, txt_wat2.Text, txt_lease_type.Text, txt_note.Text);
                MessageBox.Show("تم اضافة عقدالتاجير بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


           // }


            
                int cust_Id = Convert.ToInt16(cmb_cust_name.SelectedValue.ToString());
                int build_Id = Convert.ToInt16(cmb_build_name.SelectedValue.ToString());
                int unit_Id = Convert.ToInt16(cmb_unit_name.SelectedValue.ToString());

                int cust_build_Id = Convert.ToInt16(cmb_cust_order.SelectedValue.ToString());
                int build_id_seller = Convert.ToInt32(cmb_build_name.SelectedValue.ToString());
                BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();



                if (txt_lease_type.Text == "عقد بيع")
                { 
                    int unit_count=Convert.ToInt32(dgv_count_unit.Rows[0].Cells[0].Value.ToString());
                    if (unit_count==1)
                    {
                        cls_building.B_Update_Order_State_Request_Seller_Build_Unit(build_Id, unit_Id);
                        
                    }
                    //تعديل حالة طلب المالك
                    cls_building.B_Update_Order_State_For_Seller_Request(build_Id, unit_Id);


                    cls_building.B_Update_Order_State_For_Buyer_Request(cust_Id,cust_build_Id);

                }
                else
                    if (txt_lease_type.Text == "عقد تاجير")
                    {
                        int unit_count = Convert.ToInt32(dgv_count_unit.Rows[0].Cells[0].Value.ToString());
                        if (unit_count == 1)
                        {
                            cls_building.B_Update_Order_State_Request_Rent_Build_Unit(build_Id, unit_Id);

                        }
                        //تعديل حالة طلب المالك
                        cls_building.B_Update_Order_State_For_Seller_Request(build_Id, unit_Id);


                        cls_building.B_Update_Order_State_For_Buyer_Request(cust_Id, cust_build_Id);
                    }
        }

        private void cmb_cust_name_SelectedValueChanged(object sender, EventArgs e)
        {
            


        }

        private void cmb_cust_name_Click(object sender, EventArgs e)
        {
        //    int cust_Id = Convert.ToInt16(cmb_cust_name.SelectedValue.ToString());

        //    BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

        //    cmb_cust_order.DataSource = cls_building.Les_Get_All_Order_Request_Buyer_Build_Name(cust_Id);
        //    cmb_cust_order.DisplayMember = "build_name";
        //    cmb_cust_order.ValueMember = "Id";
        }

        private void cmb_cust_name_MouseUp(object sender, MouseEventArgs e)
        {
            int cust_Id = Convert.ToInt16(cmb_cust_name.SelectedValue.ToString());

            BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

            cmb_cust_order.DataSource = cls_building.Les_Get_All_Order_Request_Buyer_Build_Name(cust_Id);
            cmb_cust_order.DisplayMember = "build_name";
            cmb_cust_order.ValueMember = "Id";
        }

        private void cmb_cust_name_Leave(object sender, EventArgs e)
        {
            int cust_Id = Convert.ToInt16(cmb_cust_name.SelectedValue.ToString());

            BL.cls_building.cls_buildings cls_building = new BL.cls_building.cls_buildings();

            cmb_cust_order.DataSource = cls_building.Les_Get_All_Order_Request_Buyer_Build_Name(cust_Id);
            cmb_cust_order.DisplayMember = "build_name";
            cmb_cust_order.ValueMember = "Id";
        }

        private void cmb_build_name_Leave(object sender, EventArgs e)
        {
            string build_Id = cmb_build_name.SelectedValue.ToString();
            cmb_unit_name.DataSource = cls_lease_build.Les_Get_All_Unit_Name(Convert.ToInt32(build_Id));
            cmb_unit_name.DisplayMember = "unit_name";
            cmb_unit_name.ValueMember = "Id";
            dgv_count_unit.DataSource = cls_build.B_Get_All_Count_Unit_in_Build_State(Convert.ToInt32(build_Id));
            
        }
    }
}
