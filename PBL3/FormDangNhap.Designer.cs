namespace PBL3
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panelBody = new System.Windows.Forms.Panel();
            this.lbQuenMK = new System.Windows.Forms.Label();
            this.butDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.butViewMK = new Guna.UI2.WinForms.Guna2Button();
            this.butDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.butHideMK = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.SlateGray;
            this.panelBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBody.BackgroundImage")));
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBody.Controls.Add(this.lbQuenMK);
            this.panelBody.Controls.Add(this.butDangKy);
            this.panelBody.Controls.Add(this.butViewMK);
            this.panelBody.Controls.Add(this.butDangNhap);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.txtTenDangNhap);
            this.panelBody.Controls.Add(this.label4);
            this.panelBody.Controls.Add(this.txtMatKhau);
            this.panelBody.Controls.Add(this.butHideMK);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(984, 511);
            this.panelBody.TabIndex = 8;
            // 
            // lbQuenMK
            // 
            this.lbQuenMK.AutoSize = true;
            this.lbQuenMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuenMK.Location = new System.Drawing.Point(741, 348);
            this.lbQuenMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuenMK.Name = "lbQuenMK";
            this.lbQuenMK.Size = new System.Drawing.Size(89, 13);
            this.lbQuenMK.TabIndex = 130;
            this.lbQuenMK.Text = "Quên mật khẩu ?";
            this.lbQuenMK.Click += new System.EventHandler(this.lbQuenMK_Click);
            // 
            // butDangKy
            // 
            this.butDangKy.BorderRadius = 20;
            this.butDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDangKy.ForeColor = System.Drawing.Color.White;
            this.butDangKy.Location = new System.Drawing.Point(645, 294);
            this.butDangKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDangKy.Name = "butDangKy";
            this.butDangKy.Size = new System.Drawing.Size(274, 42);
            this.butDangKy.TabIndex = 129;
            this.butDangKy.Text = "Đăng ký";
            this.butDangKy.Click += new System.EventHandler(this.butDangKy_Click);
            // 
            // butViewMK
            // 
            this.butViewMK.Animated = true;
            this.butViewMK.BackColor = System.Drawing.Color.Transparent;
            this.butViewMK.BorderColor = System.Drawing.Color.Transparent;
            this.butViewMK.BorderRadius = 8;
            this.butViewMK.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.butViewMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butViewMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butViewMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butViewMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butViewMK.FillColor = System.Drawing.Color.White;
            this.butViewMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butViewMK.ForeColor = System.Drawing.Color.White;
            this.butViewMK.Image = ((System.Drawing.Image)(resources.GetObject("butViewMK.Image")));
            this.butViewMK.ImageSize = new System.Drawing.Size(25, 25);
            this.butViewMK.Location = new System.Drawing.Point(883, 205);
            this.butViewMK.Name = "butViewMK";
            this.butViewMK.Size = new System.Drawing.Size(31, 30);
            this.butViewMK.TabIndex = 127;
            this.butViewMK.UseTransparentBackground = true;
            this.butViewMK.Click += new System.EventHandler(this.buttoneyes1_Click);
            // 
            // butDangNhap
            // 
            this.butDangNhap.BorderRadius = 20;
            this.butDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDangNhap.ForeColor = System.Drawing.Color.White;
            this.butDangNhap.Location = new System.Drawing.Point(645, 248);
            this.butDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDangNhap.Name = "butDangNhap";
            this.butDangNhap.Size = new System.Drawing.Size(274, 42);
            this.butDangNhap.TabIndex = 97;
            this.butDangNhap.Text = "Đăng nhập ";
            this.butDangNhap.Click += new System.EventHandler(this.butDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(740, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTenDangNhap.BorderRadius = 20;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTenDangNhap.IconLeft")));
            this.txtTenDangNhap.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtTenDangNhap.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtTenDangNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenDangNhap.Location = new System.Drawing.Point(645, 142);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtTenDangNhap.PlaceholderText = "Tên đăng nhập ";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(278, 49);
            this.txtTenDangNhap.TabIndex = 92;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtMatKhau.BorderRadius = 20;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMatKhau.IconLeft")));
            this.txtMatKhau.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtMatKhau.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtMatKhau.Location = new System.Drawing.Point(645, 195);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(278, 49);
            this.txtMatKhau.TabIndex = 94;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // butHideMK
            // 
            this.butHideMK.Animated = true;
            this.butHideMK.BackColor = System.Drawing.Color.Transparent;
            this.butHideMK.BorderRadius = 8;
            this.butHideMK.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.butHideMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butHideMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butHideMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butHideMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butHideMK.FillColor = System.Drawing.Color.White;
            this.butHideMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butHideMK.ForeColor = System.Drawing.Color.White;
            this.butHideMK.Image = ((System.Drawing.Image)(resources.GetObject("butHideMK.Image")));
            this.butHideMK.ImageSize = new System.Drawing.Size(25, 25);
            this.butHideMK.Location = new System.Drawing.Point(883, 205);
            this.butHideMK.Name = "butHideMK";
            this.butHideMK.Size = new System.Drawing.Size(31, 30);
            this.butHideMK.TabIndex = 128;
            this.butHideMK.UseTransparentBackground = true;
            this.butHideMK.Click += new System.EventHandler(this.butHideMK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(666, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 21);
            this.label4.TabIndex = 96;
            this.label4.Text = "__________________________________";
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.butDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panelBody);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private Guna.UI2.WinForms.Guna2Button butViewMK;
        private Guna.UI2.WinForms.Guna2Button butDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2Button butHideMK;
        private Guna.UI2.WinForms.Guna2Button butDangKy;
        private System.Windows.Forms.Label lbQuenMK;
    }
}