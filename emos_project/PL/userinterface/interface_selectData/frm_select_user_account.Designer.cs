namespace emos_project.PL.userinterface.interface_selectData
{
    partial class frm_select_user_account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_user_account = new System.Windows.Forms.DataGridView();
            this.circular_button3 = new emos_project.classes.circular_button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Size = new System.Drawing.Size(690, 41);
            this.panel1.TabIndex = 161;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "حذف حساب مستخدم";
            // 
            // dgv_user_account
            // 
            this.dgv_user_account.AllowUserToAddRows = false;
            this.dgv_user_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user_account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_user_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user_account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgv_user_account.Size = new System.Drawing.Size(690, 223);
            this.dgv_user_account.TabIndex = 162;
            // 
            // circular_button3
            // 
            this.circular_button3.BackColor = System.Drawing.Color.Orange;
            this.circular_button3.FlatAppearance.BorderSize = 0;
            this.circular_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circular_button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_button3.ForeColor = System.Drawing.Color.Black;
            this.circular_button3.Image = global::emos_project.Properties.Resources.Delete_User_Male_50px;
            this.circular_button3.Location = new System.Drawing.Point(310, 268);
            this.circular_button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_button3.Name = "circular_button3";
            this.circular_button3.Size = new System.Drawing.Size(93, 76);
            this.circular_button3.TabIndex = 163;
            this.circular_button3.Text = "حــــــذف";
            this.circular_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.circular_button3.UseVisualStyleBackColor = false;
            this.circular_button3.Click += new System.EventHandler(this.circular_button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::emos_project.Properties.Resources.Settings_100px;
            this.pictureBox2.Location = new System.Drawing.Point(637, 0);
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
            // frm_select_user_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(690, 355);
            this.Controls.Add(this.circular_button3);
            this.Controls.Add(this.dgv_user_account);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_select_user_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_select_user_account";
            this.Load += new System.EventHandler(this.frm_select_user_account_Load);
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
        private classes.circular_button circular_button3;
    }
}