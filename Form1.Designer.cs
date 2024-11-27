namespace Bai3
{
    partial class frmDangKy
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
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.btn_Ho = new System.Windows.Forms.Button();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.lbl_Ho = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.btn_Ten = new System.Windows.Forms.Button();
            this.btn_HovaTen = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.chk_Thethao = new System.Windows.Forms.CheckBox();
            this.chk_Phim = new System.Windows.Forms.CheckBox();
            this.chk_Dulich = new System.Windows.Forms.CheckBox();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lal_NgaySinh = new System.Windows.Forms.Label();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_HoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_HoTen.Location = new System.Drawing.Point(0, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(800, 47);
            this.lbl_HoTen.TabIndex = 0;
            this.lbl_HoTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_HoTen.DoubleClick += new System.EventHandler(this.lbl_HoTen_DoubleClick);
            // 
            // btn_Ho
            // 
            this.btn_Ho.Location = new System.Drawing.Point(109, 315);
            this.btn_Ho.Name = "btn_Ho";
            this.btn_Ho.Size = new System.Drawing.Size(75, 23);
            this.btn_Ho.TabIndex = 1;
            this.btn_Ho.Text = "Họ Lót";
            this.btn_Ho.UseVisualStyleBackColor = true;
            this.btn_Ho.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(155, 79);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(603, 22);
            this.txt_Ho.TabIndex = 2;
            // 
            // lbl_Ho
            // 
            this.lbl_Ho.AutoSize = true;
            this.lbl_Ho.Location = new System.Drawing.Point(90, 79);
            this.lbl_Ho.Name = "lbl_Ho";
            this.lbl_Ho.Size = new System.Drawing.Size(42, 16);
            this.lbl_Ho.TabIndex = 3;
            this.lbl_Ho.Text = "Họ lót";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(93, 139);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(31, 16);
            this.lbl_Ten.TabIndex = 4;
            this.lbl_Ten.Text = "Tên";
            // 
            // txt_Ten
            // 
            this.txt_Ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_Ten.Location = new System.Drawing.Point(155, 133);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(603, 22);
            this.txt_Ten.TabIndex = 5;
            // 
            // btn_Ten
            // 
            this.btn_Ten.Location = new System.Drawing.Point(231, 315);
            this.btn_Ten.Name = "btn_Ten";
            this.btn_Ten.Size = new System.Drawing.Size(90, 25);
            this.btn_Ten.TabIndex = 6;
            this.btn_Ten.Text = "Tên";
            this.btn_Ten.UseVisualStyleBackColor = true;
            this.btn_Ten.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_HovaTen
            // 
            this.btn_HovaTen.Location = new System.Drawing.Point(376, 316);
            this.btn_HovaTen.Name = "btn_HovaTen";
            this.btn_HovaTen.Size = new System.Drawing.Size(86, 24);
            this.btn_HovaTen.TabIndex = 7;
            this.btn_HovaTen.Text = "Họ và Tên";
            this.btn_HovaTen.UseVisualStyleBackColor = true;
            this.btn_HovaTen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(210, 382);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(129, 41);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát chương trình";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // chk_Thethao
            // 
            this.chk_Thethao.AutoSize = true;
            this.chk_Thethao.Location = new System.Drawing.Point(23, 21);
            this.chk_Thethao.Name = "chk_Thethao";
            this.chk_Thethao.Size = new System.Drawing.Size(82, 20);
            this.chk_Thethao.TabIndex = 9;
            this.chk_Thethao.Text = "Thể thao";
            this.chk_Thethao.UseVisualStyleBackColor = true;
            // 
            // chk_Phim
            // 
            this.chk_Phim.AutoSize = true;
            this.chk_Phim.Location = new System.Drawing.Point(142, 21);
            this.chk_Phim.Name = "chk_Phim";
            this.chk_Phim.Size = new System.Drawing.Size(84, 20);
            this.chk_Phim.TabIndex = 10;
            this.chk_Phim.Text = "Phim ảnh";
            this.chk_Phim.UseVisualStyleBackColor = true;
            // 
            // chk_Dulich
            // 
            this.chk_Dulich.AutoSize = true;
            this.chk_Dulich.Location = new System.Drawing.Point(278, 21);
            this.chk_Dulich.Name = "chk_Dulich";
            this.chk_Dulich.Size = new System.Drawing.Size(73, 20);
            this.chk_Dulich.TabIndex = 11;
            this.chk_Dulich.Text = "Du Lịch";
            this.chk_Dulich.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(98, 11);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 20);
            this.rad_Nam.TabIndex = 12;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(188, 11);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(45, 20);
            this.rad_Nu.TabIndex = 13;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Nam);
            this.groupBox1.Controls.Add(this.rad_Nu);
            this.groupBox1.Location = new System.Drawing.Point(149, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 37);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_Thethao);
            this.groupBox2.Controls.Add(this.chk_Phim);
            this.groupBox2.Controls.Add(this.chk_Dulich);
            this.groupBox2.Location = new System.Drawing.Point(149, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 63);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sở thích";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lal_NgaySinh
            // 
            this.lal_NgaySinh.AutoSize = true;
            this.lal_NgaySinh.Location = new System.Drawing.Point(65, 171);
            this.lal_NgaySinh.Name = "lal_NgaySinh";
            this.lal_NgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lal_NgaySinh.TabIndex = 17;
            this.lal_NgaySinh.Text = "Ngày sinh";
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Location = new System.Drawing.Point(549, 315);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(94, 28);
            this.btn_Xuat.TabIndex = 18;
            this.btn_Xuat.Text = "Xuất Thông TIn";
            this.btn_Xuat.UseVisualStyleBackColor = true;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.lal_NgaySinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_HovaTen);
            this.Controls.Add(this.btn_Ten);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.lbl_Ho);
            this.Controls.Add(this.txt_Ho);
            this.Controls.Add(this.btn_Ho);
            this.Controls.Add(this.lbl_HoTen);
            this.Name = "frmDangKy";
            this.Text = "DangKy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangKy_FormClosing);
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.Click += new System.EventHandler(this.frmDangKy_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Button btn_Ho;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.Label lbl_Ho;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Button btn_Ten;
        private System.Windows.Forms.Button btn_HovaTen;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.CheckBox chk_Thethao;
        private System.Windows.Forms.CheckBox chk_Phim;
        private System.Windows.Forms.CheckBox chk_Dulich;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lal_NgaySinh;
        private System.Windows.Forms.Button btn_Xuat;
    }
}

