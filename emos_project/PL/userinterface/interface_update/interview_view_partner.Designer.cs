namespace emos_project.PL.userinterface.interface_update
{
    partial class interview_view_partner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_show_partner = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_cust_id = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.circular_button5 = new emos_project.classes.circular_button();
            this.circular_button4 = new emos_project.classes.circular_button();
            this.circular_button3 = new emos_project.classes.circular_button();
            this.circular_button2 = new emos_project.classes.circular_button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_partner)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_show_partner
            // 
            this.dgv_show_partner.AllowUserToAddRows = false;
            this.dgv_show_partner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_show_partner.BackgroundColor = System.Drawing.Color.White;
            this.dgv_show_partner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show_partner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_partner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cust_name,
            this.cust_type_id,
            this.tel});
            this.dgv_show_partner.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_show_partner.EnableHeadersVisualStyles = false;
            this.dgv_show_partner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_show_partner.Location = new System.Drawing.Point(0, 38);
            this.dgv_show_partner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_show_partner.Name = "dgv_show_partner";
            this.dgv_show_partner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_show_partner.RowHeadersVisible = false;
            this.dgv_show_partner.RowTemplate.Height = 26;
            this.dgv_show_partner.Size = new System.Drawing.Size(823, 229);
            this.dgv_show_partner.TabIndex = 12;
            this.dgv_show_partner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_show_partner_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "الرقم";
            this.id.Name = "id";
            // 
            // cust_name
            // 
            this.cust_name.DataPropertyName = "p_name";
            this.cust_name.HeaderText = "اسم الشريك";
            this.cust_name.Name = "cust_name";
            // 
            // cust_type_id
            // 
            this.cust_type_id.DataPropertyName = "p_phone";
            this.cust_type_id.HeaderText = "رقم الجوال";
            this.cust_type_id.Name = "cust_type_id";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "p_note";
            this.tel.HeaderText = "الملاحظات";
            this.tel.Name = "tel";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel10.Controls.Add(this.button11);
            this.panel10.Controls.Add(this.label23);
            this.panel10.Controls.Add(this.txt_cust_id);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel10.Size = new System.Drawing.Size(823, 38);
            this.panel10.TabIndex = 11;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Left;
            this.button11.Image = global::emos_project.Properties.Resources.Close_Window_48px;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 38);
            this.button11.TabIndex = 13;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(344, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "رقم العميل";
            this.label23.Visible = false;
            // 
            // txt_cust_id
            // 
            this.txt_cust_id.Location = new System.Drawing.Point(304, 5);
            this.txt_cust_id.Name = "txt_cust_id";
            this.txt_cust_id.Size = new System.Drawing.Size(22, 20);
            this.txt_cust_id.TabIndex = 11;
            this.txt_cust_id.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(568, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(239, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "البيانات الاساسية للشريك";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::emos_project.Properties.Resources.Info_26px;
            this.pictureBox1.Location = new System.Drawing.Point(523, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.circular_button5);
            this.panel8.Controls.Add(this.circular_button4);
            this.panel8.Controls.Add(this.circular_button3);
            this.panel8.Controls.Add(this.circular_button2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(0, 105);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(823, 259);
            this.panel8.TabIndex = 13;
            // 
            // circular_button5
            // 
            this.circular_button5.BackColor = System.Drawing.Color.Crimson;
            this.circular_button5.FlatAppearance.BorderSize = 0;
            this.circular_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button5.ForeColor = System.Drawing.Color.White;
            this.circular_button5.Image = global::emos_project.Properties.Resources.Add_35px;
            this.circular_button5.Location = new System.Drawing.Point(584, 174);
            this.circular_button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button5.Name = "circular_button5";
            this.circular_button5.Size = new System.Drawing.Size(93, 76);
            this.circular_button5.TabIndex = 13;
            this.circular_button5.Text = "إضــافة";
            this.circular_button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button5.UseVisualStyleBackColor = false;
            this.circular_button5.Click += new System.EventHandler(this.circular_button5_Click);
            // 
            // circular_button4
            // 
            this.circular_button4.BackColor = System.Drawing.Color.MediumVioletRed;
            this.circular_button4.FlatAppearance.BorderSize = 0;
            this.circular_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button4.ForeColor = System.Drawing.Color.Black;
            this.circular_button4.Image = global::emos_project.Properties.Resources.View_Details_50px;
            this.circular_button4.Location = new System.Drawing.Point(150, 173);
            this.circular_button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button4.Name = "circular_button4";
            this.circular_button4.Size = new System.Drawing.Size(93, 76);
            this.circular_button4.TabIndex = 12;
            this.circular_button4.Text = "عـــرض الصورة";
            this.circular_button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button4.UseVisualStyleBackColor = false;
            this.circular_button4.Click += new System.EventHandler(this.circular_button4_Click);
            // 
            // circular_button3
            // 
            this.circular_button3.BackColor = System.Drawing.Color.Orange;
            this.circular_button3.FlatAppearance.BorderSize = 0;
            this.circular_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button3.ForeColor = System.Drawing.Color.Black;
            this.circular_button3.Image = global::emos_project.Properties.Resources.Delete_User_Male_50px;
            this.circular_button3.Location = new System.Drawing.Point(302, 171);
            this.circular_button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button3.Name = "circular_button3";
            this.circular_button3.Size = new System.Drawing.Size(93, 76);
            this.circular_button3.TabIndex = 11;
            this.circular_button3.Text = "حــــــذف";
            this.circular_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button3.UseVisualStyleBackColor = false;
            this.circular_button3.Click += new System.EventHandler(this.circular_button3_Click);
            // 
            // circular_button2
            // 
            this.circular_button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.circular_button2.FlatAppearance.BorderSize = 0;
            this.circular_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button2.ForeColor = System.Drawing.Color.Black;
            this.circular_button2.Image = global::emos_project.Properties.Resources.Edit_50px;
            this.circular_button2.Location = new System.Drawing.Point(438, 174);
            this.circular_button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button2.Name = "circular_button2";
            this.circular_button2.Size = new System.Drawing.Size(93, 76);
            this.circular_button2.TabIndex = 10;
            this.circular_button2.Text = "تعديل";
            this.circular_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button2.UseVisualStyleBackColor = false;
            this.circular_button2.Click += new System.EventHandler(this.circular_button2_Click);
            // 
            // interview_view_partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 364);
            this.Controls.Add(this.dgv_show_partner);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interview_view_partner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "interview_view_partner";
            this.Load += new System.EventHandler(this.interview_view_partner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_partner)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_show_partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox txt_cust_id;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel8;
        private classes.circular_button circular_button4;
        private classes.circular_button circular_button3;
        private classes.circular_button circular_button2;
        private classes.circular_button circular_button5;


    }
}