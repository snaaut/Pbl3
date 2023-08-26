namespace PBL3
{
    partial class FormPhuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhuKien));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTGBH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbLoaiNC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenPK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaPK = new Guna.UI2.WinForms.Guna2TextBox();
            this.butThemPK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butSuaPK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numSoLuongPK = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongPK)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 85);
            this.label2.TabIndex = 94;
            this.label2.Text = "Phụ Kiện";
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
            this.txtSearch.Location = new System.Drawing.Point(953, 279);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "Tìm Kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(266, 44);
            this.txtSearch.TabIndex = 95;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 501);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 197);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSoLuongPK);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.txtTGBH);
            this.groupBox1.Controls.Add(this.cbbLoaiNC);
            this.groupBox1.Controls.Add(this.txtTenPK);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.groupBox1.Location = new System.Drawing.Point(52, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(877, 240);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 113);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(167, 46);
            this.guna2HtmlLabel2.TabIndex = 114;
            this.guna2HtmlLabel2.Text = "Loại nhạc cụ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 49);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(177, 37);
            this.guna2HtmlLabel1.TabIndex = 113;
            this.guna2HtmlLabel1.Text = "Tên phụ kiện\r\n";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AutoRoundedCorners = true;
            this.txtGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtGiaBan.BorderRadius = 17;
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
            this.txtGiaBan.Location = new System.Drawing.Point(610, 105);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(203, 37);
            this.txtGiaBan.TabIndex = 101;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.AutoRoundedCorners = true;
            this.txtGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtGiaNhap.BorderRadius = 17;
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
            this.txtGiaNhap.Location = new System.Drawing.Point(610, 49);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(203, 37);
            this.txtGiaNhap.TabIndex = 100;
            // 
            // txtTGBH
            // 
            this.txtTGBH.AutoRoundedCorners = true;
            this.txtTGBH.BackColor = System.Drawing.Color.Transparent;
            this.txtTGBH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTGBH.BorderRadius = 17;
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
            this.txtTGBH.Location = new System.Drawing.Point(610, 165);
            this.txtTGBH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTGBH.Name = "txtTGBH";
            this.txtTGBH.PasswordChar = '\0';
            this.txtTGBH.PlaceholderText = "";
            this.txtTGBH.SelectedText = "";
            this.txtTGBH.Size = new System.Drawing.Size(203, 37);
            this.txtTGBH.TabIndex = 99;
            // 
            // cbbLoaiNC
            // 
            this.cbbLoaiNC.AutoRoundedCorners = true;
            this.cbbLoaiNC.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiNC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.cbbLoaiNC.BorderRadius = 17;
            this.cbbLoaiNC.BorderThickness = 2;
            this.cbbLoaiNC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiNC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiNC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiNC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiNC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLoaiNC.ItemHeight = 30;
            this.cbbLoaiNC.Location = new System.Drawing.Point(143, 112);
            this.cbbLoaiNC.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiNC.Name = "cbbLoaiNC";
            this.cbbLoaiNC.Size = new System.Drawing.Size(275, 36);
            this.cbbLoaiNC.TabIndex = 97;
            // 
            // txtTenPK
            // 
            this.txtTenPK.AutoRoundedCorners = true;
            this.txtTenPK.BackColor = System.Drawing.Color.Transparent;
            this.txtTenPK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTenPK.BorderRadius = 17;
            this.txtTenPK.BorderThickness = 2;
            this.txtTenPK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPK.DefaultText = "";
            this.txtTenPK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenPK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenPK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenPK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenPK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPK.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtTenPK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPK.Location = new System.Drawing.Point(143, 49);
            this.txtTenPK.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenPK.Name = "txtTenPK";
            this.txtTenPK.PasswordChar = '\0';
            this.txtTenPK.PlaceholderText = "";
            this.txtTenPK.SelectedText = "";
            this.txtTenPK.Size = new System.Drawing.Size(275, 37);
            this.txtTenPK.TabIndex = 96;
            // 
            // txtMaPK
            // 
            this.txtMaPK.AutoRoundedCorners = true;
            this.txtMaPK.BackColor = System.Drawing.Color.Transparent;
            this.txtMaPK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtMaPK.BorderRadius = 17;
            this.txtMaPK.BorderThickness = 2;
            this.txtMaPK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPK.DefaultText = "";
            this.txtMaPK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPK.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtMaPK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPK.Location = new System.Drawing.Point(384, 525);
            this.txtMaPK.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.PasswordChar = '\0';
            this.txtMaPK.PlaceholderText = "Mã PK";
            this.txtMaPK.SelectedText = "";
            this.txtMaPK.Size = new System.Drawing.Size(105, 37);
            this.txtMaPK.TabIndex = 95;
            this.txtMaPK.Visible = false;
            // 
            // butThemPK
            // 
            this.butThemPK.AutoRoundedCorners = true;
            this.butThemPK.BackColor = System.Drawing.Color.SlateGray;
            this.butThemPK.BorderRadius = 20;
            this.butThemPK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThemPK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThemPK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemPK.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemPK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThemPK.FillColor = System.Drawing.Color.SlateBlue;
            this.butThemPK.FillColor2 = System.Drawing.Color.Lavender;
            this.butThemPK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThemPK.ForeColor = System.Drawing.Color.Black;
            this.butThemPK.Location = new System.Drawing.Point(1017, 156);
            this.butThemPK.Margin = new System.Windows.Forms.Padding(4);
            this.butThemPK.Name = "butThemPK";
            this.butThemPK.Size = new System.Drawing.Size(145, 43);
            this.butThemPK.TabIndex = 110;
            this.butThemPK.Text = "Thêm ";
            this.butThemPK.Click += new System.EventHandler(this.butThemPK_Click_1);
            // 
            // butSuaPK
            // 
            this.butSuaPK.AutoRoundedCorners = true;
            this.butSuaPK.BackColor = System.Drawing.Color.SlateGray;
            this.butSuaPK.BorderRadius = 20;
            this.butSuaPK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSuaPK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSuaPK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaPK.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaPK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSuaPK.FillColor = System.Drawing.Color.SlateBlue;
            this.butSuaPK.FillColor2 = System.Drawing.Color.Lavender;
            this.butSuaPK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butSuaPK.ForeColor = System.Drawing.Color.Black;
            this.butSuaPK.Location = new System.Drawing.Point(1017, 218);
            this.butSuaPK.Margin = new System.Windows.Forms.Padding(4);
            this.butSuaPK.Name = "butSuaPK";
            this.butSuaPK.Size = new System.Drawing.Size(145, 43);
            this.butSuaPK.TabIndex = 111;
            this.butSuaPK.Text = "Sửa";
            this.butSuaPK.Click += new System.EventHandler(this.butSuaPK_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(483, 53);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(154, 46);
            this.guna2HtmlLabel3.TabIndex = 115;
            this.guna2HtmlLabel3.Text = "Giá nhập";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(483, 112);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(142, 47);
            this.guna2HtmlLabel4.TabIndex = 116;
            this.guna2HtmlLabel4.Text = "Giá bán";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(454, 172);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(183, 47);
            this.guna2HtmlLabel5.TabIndex = 117;
            this.guna2HtmlLabel5.Text = "Thời gian BH";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(167, 172);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(144, 47);
            this.guna2HtmlLabel6.TabIndex = 118;
            this.guna2HtmlLabel6.Text = "Số lượng";
            // 
            // numSoLuongPK
            // 
            this.numSoLuongPK.AutoRoundedCorners = true;
            this.numSoLuongPK.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuongPK.BorderRadius = 17;
            this.numSoLuongPK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuongPK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuongPK.ForeColor = System.Drawing.Color.Black;
            this.numSoLuongPK.Location = new System.Drawing.Point(318, 165);
            this.numSoLuongPK.Name = "numSoLuongPK";
            this.numSoLuongPK.Size = new System.Drawing.Size(100, 37);
            this.numSoLuongPK.TabIndex = 119;
            // 
            // FormPhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1286, 695);
            this.Controls.Add(this.butSuaPK);
            this.Controls.Add(this.butThemPK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaPK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhuKien";
            this.Text = "FormPhuKien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPK;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPK;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiNC;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtTGBH;
        private Guna.UI2.WinForms.Guna2GradientButton butThemPK;
        private Guna.UI2.WinForms.Guna2GradientButton butSuaPK;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuongPK;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}