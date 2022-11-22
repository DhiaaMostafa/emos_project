namespace emos_project.PL.userinterface.interface_update
{
    partial class update_user_account_emp
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
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_user_satus = new System.Windows.Forms.ComboBox();
            this.txt_user_pass_valid = new System.Windows.Forms.TextBox();
            this.txt_user_pass_new = new System.Windows.Forms.TextBox();
            this.cmb_user_permision = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_cust_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user_pass_old = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_account_info = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account_info)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(169, 67);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(311, 27);
            this.txt_user_name.TabIndex = 153;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 165;
            this.label7.Text = "اسم المستخدم";
            // 
            // cmb_user_satus
            // 
            this.cmb_user_satus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_user_satus.FormattingEnabled = true;
            this.cmb_user_satus.Items.AddRange(new object[] {
            "Active",
            "Disactive"});
            this.cmb_user_satus.Location = new System.Drawing.Point(168, 280);
            this.cmb_user_satus.Name = "cmb_user_satus";
            this.cmb_user_satus.Size = new System.Drawing.Size(312, 27);
            this.cmb_user_satus.TabIndex = 157;
            // 
            // txt_user_pass_valid
            // 
            this.txt_user_pass_valid.Location = new System.Drawing.Point(169, 187);
            this.txt_user_pass_valid.Name = "txt_user_pass_valid";
            this.txt_user_pass_valid.Size = new System.Drawing.Size(311, 27);
            this.txt_user_pass_valid.TabIndex = 155;
            this.txt_user_pass_valid.UseSystemPasswordChar = true;
            this.txt_user_pass_valid.Validated += new System.EventHandler(this.txt_user_pass_valid_Validated);
            // 
            // txt_user_pass_new
            // 
            this.txt_user_pass_new.Location = new System.Drawing.Point(169, 145);
            this.txt_user_pass_new.Name = "txt_user_pass_new";
            this.txt_user_pass_new.Size = new System.Drawing.Size(311, 27);
            this.txt_user_pass_new.TabIndex = 154;
            this.txt_user_pass_new.UseSystemPasswordChar = true;
            // 
            // cmb_user_permision
            // 
            this.cmb_user_permision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_user_permision.FormattingEnabled = true;
            this.cmb_user_permision.Items.AddRange(new object[] {
            "Admin",
            "Officer",
            "User",
            ""});
            this.cmb_user_permision.Location = new System.Drawing.Point(168, 224);
            this.cmb_user_permision.Name = "cmb_user_permision";
            this.cmb_user_permision.Size = new System.Drawing.Size(312, 27);
            this.cmb_user_permision.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 163;
            this.label4.Text = "حالة الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 162;
            this.label3.Text = "تاكيد كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 161;
            this.label2.Text = "كلمة المرور الجديدة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 164;
            this.label5.Text = "نوع الحساب";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 50);
            this.panel1.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(234, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "تعديل حساب المستخدم";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::emos_project.Properties.Resources.Settings_100px;
            this.pictureBox2.Location = new System.Drawing.Point(483, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::emos_project.Properties.Resources.Close_Window_48px1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Image = global::emos_project.Properties.Resources.Cancel_40px;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(291, 327);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(151, 65);
            this.btn_cancel.TabIndex = 159;
            this.btn_cancel.Text = "إلـــغــاء";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = global::emos_project.Properties.Resources.Save_40px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(38, 327);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(151, 65);
            this.btn_save.TabIndex = 158;
            this.btn_save.Text = "تعديل";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_cust_Id
            // 
            this.txt_cust_Id.Location = new System.Drawing.Point(458, 350);
            this.txt_cust_Id.Name = "txt_cust_Id";
            this.txt_cust_Id.Size = new System.Drawing.Size(78, 27);
            this.txt_cust_Id.TabIndex = 166;
            this.txt_cust_Id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 167;
            this.label1.Text = "رقم العميل";
            this.label1.Visible = false;
            // 
            // txt_user_pass_old
            // 
            this.txt_user_pass_old.Location = new System.Drawing.Point(170, 106);
            this.txt_user_pass_old.Name = "txt_user_pass_old";
            this.txt_user_pass_old.Size = new System.Drawing.Size(311, 27);
            this.txt_user_pass_old.TabIndex = 168;
            this.txt_user_pass_old.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 169;
            this.label8.Text = "كلمة المرور القديمة";
            // 
            // dgv_account_info
            // 
            this.dgv_account_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account_info.Location = new System.Drawing.Point(278, 257);
            this.dgv_account_info.Name = "dgv_account_info";
            this.dgv_account_info.Size = new System.Drawing.Size(246, 64);
            this.dgv_account_info.TabIndex = 170;
            this.dgv_account_info.Visible = false;
            // 
            // update_user_account_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 408);
            this.Controls.Add(this.dgv_account_info);
            this.Controls.Add(this.txt_user_pass_old);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cust_Id);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_user_satus);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_user_pass_valid);
            this.Controls.Add(this.txt_user_pass_new);
            this.Controls.Add(this.cmb_user_permision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "update_user_account_emp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "update_user_account_emp";
            this.Load += new System.EventHandler(this.update_user_account_emp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_cust_Id;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_user_name;
        public System.Windows.Forms.ComboBox cmb_user_satus;
        public System.Windows.Forms.TextBox txt_user_pass_valid;
        public System.Windows.Forms.TextBox txt_user_pass_new;
        public System.Windows.Forms.ComboBox cmb_user_permision;
        public System.Windows.Forms.TextBox txt_user_pass_old;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgv_account_info;
    }
}