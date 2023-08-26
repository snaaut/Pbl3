namespace PBL3
{
    partial class FormResetMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResetMK));
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butGuimaEmail = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaback = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtemail.BorderRadius = 20;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtemail.IconLeft")));
            this.txtemail.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtemail.Location = new System.Drawing.Point(718, 333);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(417, 75);
            this.txtemail.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(711, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 40);
            this.label1.TabIndex = 106;
            this.label1.Text = "Quên mật khẩu ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(713, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 29);
            this.label4.TabIndex = 108;
            this.label4.Text = "_____________________________";
            // 
            // butGuimaEmail
            // 
            this.butGuimaEmail.BorderRadius = 20;
            this.butGuimaEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butGuimaEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butGuimaEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butGuimaEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butGuimaEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butGuimaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuimaEmail.ForeColor = System.Drawing.Color.White;
            this.butGuimaEmail.Location = new System.Drawing.Point(718, 449);
            this.butGuimaEmail.Name = "butGuimaEmail";
            this.butGuimaEmail.Size = new System.Drawing.Size(417, 75);
            this.butGuimaEmail.TabIndex = 109;
            this.butGuimaEmail.Text = "Gửi mã qua Email";
            this.butGuimaEmail.Click += new System.EventHandler(this.butGuimaEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(716, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 25);
            this.label2.TabIndex = 110;
            this.label2.Text = "Vui lòng nhập địa chỉ email đã đăng ký của bạn.";
            // 
            // gunaback
            // 
            this.gunaback.BackColor = System.Drawing.Color.SlateGray;
            this.gunaback.BorderRadius = 21;
            this.gunaback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaback.FillColor = System.Drawing.Color.SlateGray;
            this.gunaback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.gunaback.Image = ((System.Drawing.Image)(resources.GetObject("gunaback.Image")));
            this.gunaback.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaback.Location = new System.Drawing.Point(709, 41);
            this.gunaback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaback.Name = "gunaback";
            this.gunaback.Size = new System.Drawing.Size(88, 87);
            this.gunaback.TabIndex = 120;
            this.gunaback.Click += new System.EventHandler(this.gunaback_Click);
            // 
            // FormResetMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1178, 636);
            this.Controls.Add(this.gunaback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butGuimaEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Name = "FormResetMK";
            this.Text = "FormResetMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button butGuimaEmail;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button gunaback;
    }
}