namespace emos_project.PL.userinterface.interface_addData
{
    partial class add_user_employee
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_user_satus = new System.Windows.Forms.ComboBox();
            this.txt_user_pass_valid = new System.Windows.Forms.TextBox();
            this.txt_user_pass = new System.Windows.Forms.TextBox();
            this.cmb_user_permision = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_get_max_cust = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_get_max_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(234, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "اضافة حساب مستخدم";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(177, 71);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(311, 27);
            this.txt_user_name.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "اسم المستخدم";
            // 
            // cmb_user_satus
            // 
            this.cmb_user_satus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_user_satus.FormattingEnabled = true;
            this.cmb_user_satus.Items.AddRange(new object[] {
            "Active",
            "Disactive"});
            this.cmb_user_satus.Location = new System.Drawing.Point(176, 284);
            this.cmb_user_satus.Name = "cmb_user_satus";
            this.cmb_user_satus.Size = new System.Drawing.Size(312, 27);
            this.cmb_user_satus.TabIndex = 4;
            // 
            // txt_user_pass_valid
            // 
            this.txt_user_pass_valid.Location = new System.Drawing.Point(177, 177);
            this.txt_user_pass_valid.Name = "txt_user_pass_valid";
            this.txt_user_pass_valid.Size = new System.Drawing.Size(311, 27);
            this.txt_user_pass_valid.TabIndex = 2;
            this.txt_user_pass_valid.UseSystemPasswordChar = true;
            this.txt_user_pass_valid.Validated += new System.EventHandler(this.txt_user_pass_valid_Validated);
            // 
            // txt_user_pass
            // 
            this.txt_user_pass.Location = new System.Drawing.Point(177, 123);
            this.txt_user_pass.Name = "txt_user_pass";
            this.txt_user_pass.Size = new System.Drawing.Size(311, 27);
            this.txt_user_pass.TabIndex = 1;
            this.txt_user_pass.UseSystemPasswordChar = true;
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
            this.cmb_user_permision.Location = new System.Drawing.Point(176, 228);
            this.cmb_user_permision.Name = "cmb_user_permision";
            this.cmb_user_permision.Size = new System.Drawing.Size(312, 27);
            this.cmb_user_permision.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "حالة الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "تاكيد كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "كلمة المرور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 43;
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
            this.panel1.Size = new System.Drawing.Size(543, 50);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::emos_project.Properties.Resources.Settings_100px;
            this.pictureBox2.Location = new System.Drawing.Point(490, 0);
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
            this.btn_cancel.Location = new System.Drawing.Point(299, 331);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(151, 65);
            this.btn_cancel.TabIndex = 6;
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
            this.btn_save.Location = new System.Drawing.Point(46, 331);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(151, 65);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حـــفـــظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_get_max_cust
            // 
            this.dgv_get_max_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_get_max_cust.Location = new System.Drawing.Point(333, 210);
            this.dgv_get_max_cust.Name = "dgv_get_max_cust";
            this.dgv_get_max_cust.Size = new System.Drawing.Size(210, 58);
            this.dgv_get_max_cust.TabIndex = 152;
            this.dgv_get_max_cust.Visible = false;
            // 
            // add_user_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 416);
            this.Controls.Add(this.dgv_get_max_cust);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_user_satus);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_user_pass_valid);
            this.Controls.Add(this.txt_user_pass);
            this.Controls.Add(this.cmb_user_permision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "add_user_employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "add_user_employee";
            this.Load += new System.EventHandler(this.add_user_employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_get_max_cust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_user_satus;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_user_pass_valid;
        private System.Windows.Forms.TextBox txt_user_pass;
        private System.Windows.Forms.ComboBox cmb_user_permision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_get_max_cust;
    }
}