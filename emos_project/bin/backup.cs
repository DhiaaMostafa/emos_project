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
namespace emos_project.bin
{
    public partial class backup : Form
    {
        public backup()
        {
            InitializeComponent();
        }

               SqlConnection con =new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=estate_database;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String filname = txt_backup.Text + "\\ ALmeen " + DateTime.Now.ToLongDateString().Replace('/', '-') + DateTime.Now.ToLongTimeString().Replace(':', '-');
            String s = "Backup Database estate_database To Disk='" + filname + ".bak'";
            cmd = new SqlCommand(s, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحفظ النسخة الاحتياطية بنجاح بنجاح");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_backup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_backup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
