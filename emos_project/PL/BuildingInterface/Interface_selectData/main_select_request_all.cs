using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace emos_project.PL.BuildingInterface.Interface_selectData
{
    public partial class main_select_request_all : Form
    {

        public main_select_request_all()
        {
            InitializeComponent();
        }

        bin.form_main form_main = new bin.form_main();

        private void main_select_request_all_Load(object sender, EventArgs e)
        {

        }

        private void btn_request_rent_build_Click(object sender, EventArgs e)
        {
            main_select_request_all a = new main_select_request_all();
            Select_Building select_build = new Select_Building();
            select_build.ShowDialog();
           
        }

        private void btn_request_rent_land_Click(object sender, EventArgs e)
        {
            PL.Land_Interface.Interface_Select_Data.Win_Select_Land win_select_land = new Land_Interface.Interface_Select_Data.Win_Select_Land();
            win_select_land.ShowDialog();
        }
       

      
    }
}
