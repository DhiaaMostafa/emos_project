namespace emos_project.bin
{
    partial class form_main
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
            this.menuVertical = new System.Windows.Forms.Panel();
            this.infouser = new System.Windows.Forms.Panel();
            this.lbl_user_permission = new System.Windows.Forms.Label();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dgv_user_info = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.btnreport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnother = new System.Windows.Forms.Button();
            this.btnnotific = new System.Windows.Forms.Button();
            this.btnaccount = new System.Windows.Forms.Button();
            this.btnlease = new System.Windows.Forms.Button();
            this.btnunit = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.btn_delete_user = new System.Windows.Forms.PictureBox();
            this.btn_update_user = new System.Windows.Forms.PictureBox();
            this.btn_add_user = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circular_picturebox2 = new emos_project.classes.circular_picturebox();
            this.pic_user = new emos_project.classes.circular_picturebox();
            this.menuVertical.SuspendLayout();
            this.infouser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.barra.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circular_picturebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuVertical.Controls.Add(this.btnreport);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.btnother);
            this.menuVertical.Controls.Add(this.btnnotific);
            this.menuVertical.Controls.Add(this.btnaccount);
            this.menuVertical.Controls.Add(this.btnlease);
            this.menuVertical.Controls.Add(this.btnunit);
            this.menuVertical.Controls.Add(this.btncust);
            this.menuVertical.Controls.Add(this.infouser);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuVertical.Location = new System.Drawing.Point(1076, 0);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(242, 724);
            this.menuVertical.TabIndex = 0;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // infouser
            // 
            this.infouser.BackColor = System.Drawing.Color.White;
            this.infouser.Controls.Add(this.btn_delete_user);
            this.infouser.Controls.Add(this.btn_update_user);
            this.infouser.Controls.Add(this.btn_add_user);
            this.infouser.Controls.Add(this.lbl_user_permission);
            this.infouser.Controls.Add(this.circular_picturebox2);
            this.infouser.Controls.Add(this.lbl_user_name);
            this.infouser.Controls.Add(this.pic_user);
            this.infouser.Dock = System.Windows.Forms.DockStyle.Top;
            this.infouser.Location = new System.Drawing.Point(0, 41);
            this.infouser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infouser.Name = "infouser";
            this.infouser.Size = new System.Drawing.Size(242, 190);
            this.infouser.TabIndex = 8;
            this.infouser.Paint += new System.Windows.Forms.PaintEventHandler(this.infouser_Paint);
            // 
            // lbl_user_permission
            // 
            this.lbl_user_permission.AutoSize = true;
            this.lbl_user_permission.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_permission.ForeColor = System.Drawing.Color.Black;
            this.lbl_user_permission.Location = new System.Drawing.Point(121, 130);
            this.lbl_user_permission.Name = "lbl_user_permission";
            this.lbl_user_permission.Size = new System.Drawing.Size(37, 21);
            this.lbl_user_permission.TabIndex = 4;
            this.lbl_user_permission.Text = "مدير";
            this.lbl_user_permission.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_user_name.Location = new System.Drawing.Point(53, 109);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(160, 21);
            this.lbl_user_name.TabIndex = 2;
            this.lbl_user_name.Text = "مرحباً : محمد احمد صالح";
            this.lbl_user_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 41);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Koufi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "نظام إدارة مكتب عقاري";
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.MidnightBlue;
            this.barra.Controls.Add(this.pictureBox2);
            this.barra.Controls.Add(this.btnslide);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1076, 41);
            this.barra.TabIndex = 1;
            this.barra.Paint += new System.Windows.Forms.PaintEventHandler(this.barra_Paint);
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.dgv_user_info);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1076, 683);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // dgv_user_info
            // 
            this.dgv_user_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_info.Location = new System.Drawing.Point(763, 53);
            this.dgv_user_info.Name = "dgv_user_info";
            this.dgv_user_info.Size = new System.Drawing.Size(267, 31);
            this.dgv_user_info.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::emos_project.Properties.Resources.Shutdown_48px;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnslide
            // 
            this.btnslide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnslide.Image = global::emos_project.Properties.Resources.Menu_50px1;
            this.btnslide.Location = new System.Drawing.Point(1040, 7);
            this.btnslide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(30, 28);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // btnreport
            // 
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Image = global::emos_project.Properties.Resources.Land_Sales_40px;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(0, 429);
            this.btnreport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(237, 46);
            this.btnreport.TabIndex = 6;
            this.btnreport.Text = "الاراضي";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::emos_project.Properties.Resources.Home_50px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "الرئيسية";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnother
            // 
            this.btnother.FlatAppearance.BorderSize = 0;
            this.btnother.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnother.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnother.ForeColor = System.Drawing.Color.White;
            this.btnother.Image = global::emos_project.Properties.Resources.News_44px2;
            this.btnother.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnother.Location = new System.Drawing.Point(2, 606);
            this.btnother.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnother.Name = "btnother";
            this.btnother.Size = new System.Drawing.Size(237, 46);
            this.btnother.TabIndex = 7;
            this.btnother.Text = "التقارير";
            this.btnother.UseVisualStyleBackColor = true;
            this.btnother.Click += new System.EventHandler(this.btnother_Click);
            // 
            // btnnotific
            // 
            this.btnnotific.FlatAppearance.BorderSize = 0;
            this.btnnotific.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnnotific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotific.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotific.ForeColor = System.Drawing.Color.White;
            this.btnnotific.Image = global::emos_project.Properties.Resources.Exit_40px;
            this.btnnotific.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotific.Location = new System.Drawing.Point(2, 665);
            this.btnnotific.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnotific.Name = "btnnotific";
            this.btnnotific.Size = new System.Drawing.Size(237, 46);
            this.btnnotific.TabIndex = 5;
            this.btnnotific.Text = "خروج";
            this.btnnotific.UseVisualStyleBackColor = true;
            this.btnnotific.Click += new System.EventHandler(this.btnnotific_Click);
            // 
            // btnaccount
            // 
            this.btnaccount.FlatAppearance.BorderSize = 0;
            this.btnaccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccount.ForeColor = System.Drawing.Color.White;
            this.btnaccount.Image = global::emos_project.Properties.Resources.Paper_50px3;
            this.btnaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccount.Location = new System.Drawing.Point(-6, 550);
            this.btnaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(244, 50);
            this.btnaccount.TabIndex = 4;
            this.btnaccount.Text = "إدارة عقود الاراضي";
            this.btnaccount.UseVisualStyleBackColor = true;
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            // 
            // btnlease
            // 
            this.btnlease.FlatAppearance.BorderSize = 0;
            this.btnlease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnlease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlease.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlease.ForeColor = System.Drawing.Color.White;
            this.btnlease.Image = global::emos_project.Properties.Resources.News_44px;
            this.btnlease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlease.Location = new System.Drawing.Point(1, 490);
            this.btnlease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlease.Name = "btnlease";
            this.btnlease.Size = new System.Drawing.Size(237, 46);
            this.btnlease.TabIndex = 3;
            this.btnlease.Text = "ادارة العقود المنشات";
            this.btnlease.UseVisualStyleBackColor = true;
            this.btnlease.Click += new System.EventHandler(this.btnlease_Click);
            // 
            // btnunit
            // 
            this.btnunit.FlatAppearance.BorderSize = 0;
            this.btnunit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnunit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunit.ForeColor = System.Drawing.Color.White;
            this.btnunit.Image = global::emos_project.Properties.Resources.Real_Estate_44px;
            this.btnunit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnunit.Location = new System.Drawing.Point(1, 364);
            this.btnunit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnunit.Name = "btnunit";
            this.btnunit.Size = new System.Drawing.Size(237, 46);
            this.btnunit.TabIndex = 2;
            this.btnunit.Text = "المنشأت والوحدات";
            this.btnunit.UseVisualStyleBackColor = true;
            this.btnunit.Click += new System.EventHandler(this.btnunit_Click);
            // 
            // btncust
            // 
            this.btncust.FlatAppearance.BorderSize = 0;
            this.btncust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.ForeColor = System.Drawing.Color.White;
            this.btncust.Image = global::emos_project.Properties.Resources.Customer_44px;
            this.btncust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncust.Location = new System.Drawing.Point(1, 303);
            this.btncust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(237, 46);
            this.btncust.TabIndex = 1;
            this.btncust.Text = "العملاء";
            this.btncust.UseVisualStyleBackColor = true;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete_user.Image = global::emos_project.Properties.Resources.Waste_50pxee;
            this.btn_delete_user.Location = new System.Drawing.Point(167, 159);
            this.btn_delete_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(30, 28);
            this.btn_delete_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_delete_user.TabIndex = 6;
            this.btn_delete_user.TabStop = false;
            this.btn_delete_user.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btn_update_user
            // 
            this.btn_update_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_update_user.Image = global::emos_project.Properties.Resources.Edit_Account_50pxee;
            this.btn_update_user.Location = new System.Drawing.Point(105, 159);
            this.btn_update_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_user.Name = "btn_update_user";
            this.btn_update_user.Size = new System.Drawing.Size(30, 28);
            this.btn_update_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_update_user.TabIndex = 5;
            this.btn_update_user.TabStop = false;
            this.btn_update_user.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add_user.Image = global::emos_project.Properties.Resources.Add_User_Male_50pxee;
            this.btn_add_user.Location = new System.Drawing.Point(40, 159);
            this.btn_add_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(30, 28);
            this.btn_add_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_add_user.TabIndex = 2;
            this.btn_add_user.TabStop = false;
            this.btn_add_user.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::emos_project.Properties.Resources.Property_50px1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // circular_picturebox2
            // 
            this.circular_picturebox2.Image = global::emos_project.Properties.Resources.Ellipse_44px;
            this.circular_picturebox2.Location = new System.Drawing.Point(167, 72);
            this.circular_picturebox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circular_picturebox2.Name = "circular_picturebox2";
            this.circular_picturebox2.Size = new System.Drawing.Size(26, 24);
            this.circular_picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circular_picturebox2.TabIndex = 3;
            this.circular_picturebox2.TabStop = false;
            this.circular_picturebox2.Click += new System.EventHandler(this.circular_picturebox2_Click);
            // 
            // pic_user
            // 
            this.pic_user.Image = global::emos_project.Properties.Resources._1543181209054;
            this.pic_user.Location = new System.Drawing.Point(57, 8);
            this.pic_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(119, 87);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 1;
            this.pic_user.TabStop = false;
            this.pic_user.Click += new System.EventHandler(this.circular_picturebox1_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 724);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_main";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.menuVertical.ResumeLayout(false);
            this.infouser.ResumeLayout(false);
            this.infouser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.barra.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circular_picturebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.Button btnaccount;
        private System.Windows.Forms.Button btnlease;
        private System.Windows.Forms.Button btnunit;
        private System.Windows.Forms.Button btnother;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnnotific;
        private System.Windows.Forms.Panel infouser;
        private classes.circular_picturebox circular_picturebox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_delete_user;
        private System.Windows.Forms.PictureBox btn_update_user;
        private System.Windows.Forms.PictureBox btn_add_user;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelContainer;
        public classes.circular_picturebox pic_user;
        public System.Windows.Forms.Label lbl_user_name;
        public System.Windows.Forms.Label lbl_user_permission;
        public System.Windows.Forms.DataGridView dgv_user_info;
    }
}