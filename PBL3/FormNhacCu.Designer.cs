namespace PBL3
{
    partial class FormNhacCu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhacCu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.butThemNC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butSuaNC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numSoLuongNC = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtTGBH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-10, 503);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1297, 191);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtSearch.BorderRadius = 21;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightSize = new System.Drawing.Size(35, 20);
            this.txtSearch.Location = new System.Drawing.Point(1009, 347);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(231, 44);
            this.txtSearch.TabIndex = 91;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 72);
            this.label2.TabIndex = 93;
            this.label2.Text = "Nhạc Cụ ";
            // 
            // txtTenNC
            // 
            this.txtTenNC.AutoRoundedCorners = true;
            this.txtTenNC.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTenNC.BorderRadius = 21;
            this.txtTenNC.BorderThickness = 2;
            this.txtTenNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNC.DefaultText = "";
            this.txtTenNC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtTenNC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNC.Location = new System.Drawing.Point(141, 30);
            this.txtTenNC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNC.Name = "txtTenNC";
            this.txtTenNC.PasswordChar = '\0';
            this.txtTenNC.PlaceholderText = "";
            this.txtTenNC.SelectedText = "";
            this.txtTenNC.Size = new System.Drawing.Size(220, 44);
            this.txtTenNC.TabIndex = 96;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.AutoRoundedCorners = true;
            this.txtGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtGiaNhap.BorderRadius = 21;
            this.txtGiaNhap.BorderThickness = 2;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.DefaultText = "";
            this.txtGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Location = new System.Drawing.Point(141, 94);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(220, 44);
            this.txtGiaNhap.TabIndex = 97;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AutoRoundedCorners = true;
            this.txtGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtGiaBan.BorderRadius = 20;
            this.txtGiaBan.BorderThickness = 2;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Location = new System.Drawing.Point(141, 153);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(220, 43);
            this.txtGiaBan.TabIndex = 98;
            // 
            // butThemNC
            // 
            this.butThemNC.AutoRoundedCorners = true;
            this.butThemNC.BackColor = System.Drawing.Color.SlateGray;
            this.butThemNC.BorderRadius = 20;
            this.butThemNC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThemNC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThemNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemNC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThemNC.FillColor = System.Drawing.Color.SlateBlue;
            this.butThemNC.FillColor2 = System.Drawing.Color.Lavender;
            this.butThemNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThemNC.ForeColor = System.Drawing.Color.Black;
            this.butThemNC.Location = new System.Drawing.Point(1053, 188);
            this.butThemNC.Margin = new System.Windows.Forms.Padding(4);
            this.butThemNC.Name = "butThemNC";
            this.butThemNC.Size = new System.Drawing.Size(145, 43);
            this.butThemNC.TabIndex = 103;
            this.butThemNC.Text = "Thêm ";
            this.butThemNC.Click += new System.EventHandler(this.butThemNC_Click);
            // 
            // butSuaNC
            // 
            this.butSuaNC.AutoRoundedCorners = true;
            this.butSuaNC.BackColor = System.Drawing.Color.SlateGray;
            this.butSuaNC.BorderRadius = 20;
            this.butSuaNC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSuaNC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSuaNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaNC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSuaNC.FillColor = System.Drawing.Color.SlateBlue;
            this.butSuaNC.FillColor2 = System.Drawing.Color.Lavender;
            this.butSuaNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butSuaNC.ForeColor = System.Drawing.Color.Black;
            this.butSuaNC.Location = new System.Drawing.Point(1053, 268);
            this.butSuaNC.Margin = new System.Windows.Forms.Padding(4);
            this.butSuaNC.Name = "butSuaNC";
            this.butSuaNC.Size = new System.Drawing.Size(145, 43);
            this.butSuaNC.TabIndex = 104;
            this.butSuaNC.Text = "Sửa ";
            this.butSuaNC.Click += new System.EventHandler(this.butSuaNC_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTenNC);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.numSoLuongNC);
            this.groupBox1.Controls.Add(this.txtTGBH);
            this.groupBox1.Controls.Add(this.cbbLoaiSP);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.groupBox1.Location = new System.Drawing.Point(130, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(836, 256);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(399, 37);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(207, 22);
            this.guna2HtmlLabel4.TabIndex = 115;
            this.guna2HtmlLabel4.Text = "Loại nhạc cụ";
            // 
            // numSoLuongNC
            // 
            this.numSoLuongNC.AutoRoundedCorners = true;
            this.numSoLuongNC.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuongNC.BorderColor = System.Drawing.Color.Navy;
            this.numSoLuongNC.BorderRadius = 18;
            this.numSoLuongNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuongNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuongNC.ForeColor = System.Drawing.Color.Black;
            this.numSoLuongNC.Location = new System.Drawing.Point(607, 153);
            this.numSoLuongNC.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuongNC.Name = "numSoLuongNC";
            this.numSoLuongNC.Size = new System.Drawing.Size(99, 39);
            this.numSoLuongNC.TabIndex = 118;
            this.numSoLuongNC.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            this.numSoLuongNC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTGBH
            // 
            this.txtTGBH.AutoRoundedCorners = true;
            this.txtTGBH.BackColor = System.Drawing.Color.Transparent;
            this.txtTGBH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTGBH.BorderRadius = 21;
            this.txtTGBH.BorderThickness = 2;
            this.txtTGBH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTGBH.DefaultText = "";
            this.txtTGBH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTGBH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTGBH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTGBH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTGBH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTGBH.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtTGBH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTGBH.Location = new System.Drawing.Point(607, 94);
            this.txtTGBH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTGBH.Name = "txtTGBH";
            this.txtTGBH.PasswordChar = '\0';
            this.txtTGBH.PlaceholderText = "";
            this.txtTGBH.SelectedText = "";
            this.txtTGBH.Size = new System.Drawing.Size(199, 44);
            this.txtTGBH.TabIndex = 104;
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.AutoRoundedCorners = true;
            this.cbbLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiSP.BorderColor = System.Drawing.Color.Navy;
            this.cbbLoaiSP.BorderRadius = 17;
            this.cbbLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLoaiSP.ItemHeight = 30;
            this.cbbLoaiSP.Location = new System.Drawing.Point(607, 30);
            this.cbbLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(197, 36);
            this.cbbLoaiSP.TabIndex = 105;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(7, 37);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(269, 22);
            this.guna2HtmlLabel1.TabIndex = 112;
            this.guna2HtmlLabel1.Text = "Tên nhạc cụ";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(399, 102);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(271, 36);
            this.guna2HtmlLabel6.TabIndex = 117;
            this.guna2HtmlLabel6.Text = "Thời gian bảo hành";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 102);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(164, 45);
            this.guna2HtmlLabel2.TabIndex = 113;
            this.guna2HtmlLabel2.Text = "Giá nhập ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(21, 163);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(181, 33);
            this.guna2HtmlLabel3.TabIndex = 114;
            this.guna2HtmlLabel3.Text = "Giá bán";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(408, 162);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(191, 33);
            this.guna2HtmlLabel5.TabIndex = 116;
            this.guna2HtmlLabel5.Text = "Số lượng";
            // 
            // FormNhacCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1280, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSuaNC);
            this.Controls.Add(this.butThemNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhacCu";
            this.Text = "FormNhacCu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNC;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private Guna.UI2.WinForms.Guna2GradientButton butThemNC;
        private Guna.UI2.WinForms.Guna2GradientButton butSuaNC;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTGBH;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuongNC;
    }
}