namespace emos_project.PL.userinterface.interface_update
{
    partial class update_user_account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_user_account = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circular_button2 = new emos_project.classes.circular_button();
            this.circular_button1 = new emos_project.classes.circular_button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(674, 41);
            this.panel1.TabIndex = 164;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "تعديل حساب مستخدم";
            // 
            // dgv_user_account
            // 
            this.dgv_user_account.AllowUserToAddRows = false;
            this.dgv_user_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user_account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_user_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user_account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_user_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_user_account.EnableHeadersVisualStyles = false;
            this.dgv_user_account.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_user_account.Location = new System.Drawing.Point(0, 41);
            this.dgv_user_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_user_account.Name = "dgv_user_account";
            this.dgv_user_account.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_user_account.RowHeadersVisible = false;
            this.dgv_user_account.RowTemplate.Height = 26;
            this.dgv_user_account.Size = new System.Drawing.Size(674, 223);
            this.dgv_user_account.TabIndex = 165;
            this.dgv_user_account.DoubleClick += new System.EventHandler(this.dgv_user_account_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::emos_project.Properties.Resources.Settings_100px;
            this.pictureBox2.Location = new System.Drawing.Point(621, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 41);
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
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // circular_button2
            // 
            this.circular_button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.circular_button2.FlatAppearance.BorderSize = 0;
            this.circular_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button2.ForeColor = System.Drawing.Color.White;
            this.circular_button2.Image = global::emos_project.Properties.Resources.Edit_50px;
            this.circular_button2.Location = new System.Drawing.Point(239, 268);
            this.circular_button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button2.Name = "circular_button2";
            this.circular_button2.Size = new System.Drawing.Size(93, 76);
            this.circular_button2.TabIndex = 167;
            this.circular_button2.Text = "تعديل";
            this.circular_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button2.UseVisualStyleBackColor = false;
            this.circular_button2.Click += new System.EventHandler(this.circular_button2_Click);
            // 
            // circular_button1
            // 
            this.circular_button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.circular_button1.FlatAppearance.BorderSize = 0;
            this.circular_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button1.ForeColor = System.Drawing.Color.White;
            this.circular_button1.Location = new System.Drawing.Point(381, 268);
            this.circular_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button1.Name = "circular_button1";
            this.circular_button1.Size = new System.Drawing.Size(93, 76);
            this.circular_button1.TabIndex = 168;
            this.circular_button1.Text = "تحديث";
            this.circular_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button1.UseVisualStyleBackColor = false;
            this.circular_button1.Click += new System.EventHandler(this.circular_button1_Click);
            // 
            // update_user_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(674, 354);
            this.Controls.Add(this.circular_button1);
            this.Controls.Add(this.circular_button2);
            this.Controls.Add(this.dgv_user_account);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update_user_account";
            this.Text = "update_user_account";
            this.Load += new System.EventHandler(this.update_user_account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgv_user_account;
        private classes.circular_button circular_button2;
        private classes.circular_button circular_button1;
    }
}