namespace emos_project.bin
{
    partial class form_login
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.circular_picturebox2 = new emos_project.classes.circular_picturebox();
            this.label2 = new System.Windows.Forms.Label();
            this.circular_picturebox1 = new emos_project.classes.circular_picturebox();
            this.txt_user_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circular_picturebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circular_picturebox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 550;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.circular_picturebox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.circular_picturebox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 82);
            this.panel1.TabIndex = 21;
            // 
            // circular_picturebox2
            // 
            this.circular_picturebox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circular_picturebox2.Image = global::emos_project.Properties.Resources.Property_50px;
            this.circular_picturebox2.Location = new System.Drawing.Point(100, 38);
            this.circular_picturebox2.Name = "circular_picturebox2";
            this.circular_picturebox2.Size = new System.Drawing.Size(49, 41);
            this.circular_picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circular_picturebox2.TabIndex = 12;
            this.circular_picturebox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Koufi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "نظام ادارة مكتب عقاري";
            // 
            // circular_picturebox1
            // 
            this.circular_picturebox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circular_picturebox1.Image = global::emos_project.Properties.Resources.Delete_50pxa;
            this.circular_picturebox1.Location = new System.Drawing.Point(350, 38);
            this.circular_picturebox1.Name = "circular_picturebox1";
            this.circular_picturebox1.Size = new System.Drawing.Size(49, 41);
            this.circular_picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circular_picturebox1.TabIndex = 11;
            this.circular_picturebox1.TabStop = false;
            this.circular_picturebox1.Click += new System.EventHandler(this.circular_picturebox1_Click);
            // 
            // txt_user_pass
            // 
            this.txt_user_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_pass.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_pass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user_pass.HintText = "";
            this.txt_user_pass.isPassword = true;
            this.txt_user_pass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_user_pass.LineIdleColor = System.Drawing.Color.DimGray;
            this.txt_user_pass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_user_pass.LineThickness = 4;
            this.txt_user_pass.Location = new System.Drawing.Point(100, 264);
            this.txt_user_pass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_user_pass.Name = "txt_user_pass";
            this.txt_user_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_user_pass.Size = new System.Drawing.Size(316, 44);
            this.txt_user_pass.TabIndex = 18;
            this.txt_user_pass.Text = "كلمة المرور";
            this.txt_user_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_pass_KeyDown);
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.White;
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user_name.HintText = "";
            this.txt_user_name.isPassword = false;
            this.txt_user_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_user_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_user_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_user_name.LineThickness = 4;
            this.txt_user_name.Location = new System.Drawing.Point(105, 146);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_user_name.Size = new System.Drawing.Size(316, 44);
            this.txt_user_name.TabIndex = 17;
            this.txt_user_name.Text = "اســم المــستــخدم";
            this.txt_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 87);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Koufi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(146, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "واجهة الدخول للنظام";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(289, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "كلـمة الــمرور";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(265, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "اسم المستخدم";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Koufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(178, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "تسجيل الدخول";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_user_pass);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circular_picturebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circular_picturebox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private classes.circular_picturebox circular_picturebox2;
        private System.Windows.Forms.Label label2;
        private classes.circular_picturebox circular_picturebox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_user_pass;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_user_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

    }
}