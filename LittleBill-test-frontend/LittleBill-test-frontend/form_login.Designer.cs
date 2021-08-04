
namespace LittleBill_test_frontend
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
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_top = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tbox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_mail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_register = new System.Windows.Forms.LinkLabel();
            this.form_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.elipse_form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.lbl_description.Location = new System.Drawing.Point(459, 93);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(298, 36);
            this.lbl_description.TabIndex = 22;
            this.lbl_description.Text = "Bienvenue sur LittleBill - Test,\r\nConnectez-vous pour accéder à l\'application\r\n";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.lbl_title.Location = new System.Drawing.Point(461, 68);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(288, 25);
            this.lbl_title.TabIndex = 21;
            this.lbl_title.Text = "Se connecter sur LittleBill - Test";
            // 
            // btn_login
            // 
            this.btn_login.AutoRoundedCorners = true;
            this.btn_login.BorderRadius = 21;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.DisabledState.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(467, 324);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(282, 45);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "Se connecter";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Transparent;
            this.pnl_top.BorderRadius = 20;
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.CustomizableEdges.BottomRight = false;
            this.pnl_top.CustomizableEdges.TopLeft = false;
            this.pnl_top.CustomizableEdges.TopRight = false;
            this.pnl_top.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnl_top.Location = new System.Drawing.Point(665, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.ShadowDecoration.Parent = this.pnl_top;
            this.pnl_top.Size = new System.Drawing.Size(135, 43);
            this.pnl_top.TabIndex = 16;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_minimize.HoverState.Parent = this.btn_minimize;
            this.btn_minimize.IconColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(10, 6);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Parent = this.btn_minimize;
            this.btn_minimize.Size = new System.Drawing.Size(65, 29);
            this.btn_minimize.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BorderRadius = 15;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FillColor = System.Drawing.Color.Red;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(91, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            // 
            // tbox_password
            // 
            this.tbox_password.BorderRadius = 6;
            this.tbox_password.BorderThickness = 0;
            this.tbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_password.DefaultText = "";
            this.tbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_password.DisabledState.Parent = this.tbox_password;
            this.tbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_password.FocusedState.Parent = this.tbox_password;
            this.tbox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_password.ForeColor = System.Drawing.Color.White;
            this.tbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_password.HoverState.Parent = this.tbox_password;
            this.tbox_password.IconLeft = global::LittleBill_test_frontend.Properties.Resources.password;
            this.tbox_password.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tbox_password.Location = new System.Drawing.Point(467, 241);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '*';
            this.tbox_password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.tbox_password.PlaceholderText = "123+aze";
            this.tbox_password.SelectedText = "";
            this.tbox_password.ShadowDecoration.Parent = this.tbox_password;
            this.tbox_password.Size = new System.Drawing.Size(282, 49);
            this.tbox_password.TabIndex = 18;
            this.tbox_password.TextOffset = new System.Drawing.Point(20, 0);
            this.tbox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_KeyPress);
            // 
            // tbox_mail
            // 
            this.tbox_mail.BorderRadius = 6;
            this.tbox_mail.BorderThickness = 0;
            this.tbox_mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_mail.DefaultText = "";
            this.tbox_mail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_mail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_mail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_mail.DisabledState.Parent = this.tbox_mail;
            this.tbox_mail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_mail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbox_mail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_mail.FocusedState.Parent = this.tbox_mail;
            this.tbox_mail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_mail.ForeColor = System.Drawing.Color.White;
            this.tbox_mail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_mail.HoverState.Parent = this.tbox_mail;
            this.tbox_mail.IconLeft = global::LittleBill_test_frontend.Properties.Resources.user;
            this.tbox_mail.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tbox_mail.Location = new System.Drawing.Point(466, 171);
            this.tbox_mail.Name = "tbox_mail";
            this.tbox_mail.PasswordChar = '\0';
            this.tbox_mail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.tbox_mail.PlaceholderText = "nom d\'utilisateur";
            this.tbox_mail.SelectedText = "";
            this.tbox_mail.ShadowDecoration.Parent = this.tbox_mail;
            this.tbox_mail.Size = new System.Drawing.Size(282, 49);
            this.tbox_mail.TabIndex = 17;
            this.tbox_mail.TextOffset = new System.Drawing.Point(20, 0);
            this.tbox_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_KeyPress);
            // 
            // lbl_register
            // 
            this.lbl_register.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.LinkColor = System.Drawing.Color.White;
            this.lbl_register.Location = new System.Drawing.Point(498, 405);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(229, 16);
            this.lbl_register.TabIndex = 23;
            this.lbl_register.TabStop = true;
            this.lbl_register.Text = "Pas encore de compte ? S\'enregister";
            this.lbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_register_LinkClicked);
            // 
            // form_drag
            // 
            this.form_drag.TargetControl = this;
            this.form_drag.TransparentWhileDrag = true;
            this.form_drag.UseTransparentDrag = true;
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 15;
            this.elipse_form.TargetControl = this;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.tbox_mail);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_login";
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2TextBox tbox_password;
        private Guna.UI2.WinForms.Guna2TextBox tbox_mail;
        private Guna.UI2.WinForms.Guna2Panel pnl_top;
        private Guna.UI2.WinForms.Guna2ControlBox btn_minimize;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private System.Windows.Forms.LinkLabel lbl_register;
        private Guna.UI2.WinForms.Guna2DragControl form_drag;
        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
    }
}