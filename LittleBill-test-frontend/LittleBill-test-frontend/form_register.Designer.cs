
namespace LittleBill_test_frontend
{
    partial class form_register
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
            this.elipse_form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.form_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_top = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tbox_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 15;
            this.elipse_form.TargetControl = this;
            // 
            // form_drag
            // 
            this.form_drag.TargetControl = this;
            this.form_drag.TransparentWhileDrag = true;
            this.form_drag.UseTransparentDrag = true;
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
            this.pnl_top.Location = new System.Drawing.Point(665, -1);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.ShadowDecoration.Parent = this.pnl_top;
            this.pnl_top.Size = new System.Drawing.Size(135, 43);
            this.pnl_top.TabIndex = 9;
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
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_register
            // 
            this.btn_register.AutoRoundedCorners = true;
            this.btn_register.BorderRadius = 21;
            this.btn_register.CheckedState.Parent = this.btn_register;
            this.btn_register.CustomImages.Parent = this.btn_register;
            this.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_register.DisabledState.Parent = this.btn_register;
            this.btn_register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.HoverState.Parent = this.btn_register;
            this.btn_register.Location = new System.Drawing.Point(443, 337);
            this.btn_register.Name = "btn_register";
            this.btn_register.ShadowDecoration.Parent = this.btn_register;
            this.btn_register.Size = new System.Drawing.Size(282, 45);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "S\'enregistrer";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.lbl_title.Location = new System.Drawing.Point(442, 57);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(288, 25);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "S\'enregistrer sur LittleBill - Test";
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.lbl_description.Location = new System.Drawing.Point(442, 82);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(298, 36);
            this.lbl_description.TabIndex = 15;
            this.lbl_description.Text = "Bienvenue sur LittleBill - Test,\r\nN\'hésitez pas à vous enregistrer\r\n";
            // 
            // tbox_nom
            // 
            this.tbox_nom.BorderRadius = 6;
            this.tbox_nom.BorderThickness = 0;
            this.tbox_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_nom.DefaultText = "";
            this.tbox_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_nom.DisabledState.Parent = this.tbox_nom;
            this.tbox_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_nom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbox_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_nom.FocusedState.Parent = this.tbox_nom;
            this.tbox_nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_nom.ForeColor = System.Drawing.Color.White;
            this.tbox_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_nom.HoverState.Parent = this.tbox_nom;
            this.tbox_nom.IconLeft = global::LittleBill_test_frontend.Properties.Resources.user;
            this.tbox_nom.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tbox_nom.Location = new System.Drawing.Point(443, 121);
            this.tbox_nom.Name = "tbox_nom";
            this.tbox_nom.PasswordChar = '\0';
            this.tbox_nom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.tbox_nom.PlaceholderText = "nom";
            this.tbox_nom.SelectedText = "";
            this.tbox_nom.ShadowDecoration.Parent = this.tbox_nom;
            this.tbox_nom.Size = new System.Drawing.Size(282, 49);
            this.tbox_nom.TabIndex = 13;
            this.tbox_nom.TextOffset = new System.Drawing.Point(20, 0);
            this.tbox_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_KeyPress);
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
            this.tbox_password.Location = new System.Drawing.Point(443, 253);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '*';
            this.tbox_password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.tbox_password.PlaceholderText = "123+aze";
            this.tbox_password.SelectedText = "";
            this.tbox_password.ShadowDecoration.Parent = this.tbox_password;
            this.tbox_password.Size = new System.Drawing.Size(282, 49);
            this.tbox_password.TabIndex = 11;
            this.tbox_password.TextOffset = new System.Drawing.Point(20, 0);
            this.tbox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_KeyPress);
            // 
            // tbox_email
            // 
            this.tbox_email.BorderRadius = 6;
            this.tbox_email.BorderThickness = 0;
            this.tbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_email.DefaultText = "";
            this.tbox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_email.DisabledState.Parent = this.tbox_email;
            this.tbox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbox_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_email.FocusedState.Parent = this.tbox_email;
            this.tbox_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_email.ForeColor = System.Drawing.Color.White;
            this.tbox_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_email.HoverState.Parent = this.tbox_email;
            this.tbox_email.IconLeft = global::LittleBill_test_frontend.Properties.Resources.mail;
            this.tbox_email.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tbox_email.Location = new System.Drawing.Point(443, 188);
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.PasswordChar = '\0';
            this.tbox_email.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.tbox_email.PlaceholderText = "example@gmail.com";
            this.tbox_email.SelectedText = "";
            this.tbox_email.ShadowDecoration.Parent = this.tbox_email;
            this.tbox_email.Size = new System.Drawing.Size(282, 49);
            this.tbox_email.TabIndex = 10;
            this.tbox_email.TextOffset = new System.Drawing.Point(20, 0);
            this.tbox_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_KeyPress);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 25;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::LittleBill_test_frontend.Properties.Resources.nuagesjpg;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(16, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(420, 401);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 25;
            this.guna2PictureBox1.TabStop = false;
            // 
            // form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tbox_nom);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.tbox_email);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_register";
            this.Shown += new System.EventHandler(this.form_register_Shown);
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
        private Guna.UI2.WinForms.Guna2DragControl form_drag;
        private Guna.UI2.WinForms.Guna2TextBox tbox_email;
        private Guna.UI2.WinForms.Guna2Panel pnl_top;
        private Guna.UI2.WinForms.Guna2ControlBox btn_minimize;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private Guna.UI2.WinForms.Guna2TextBox tbox_password;
        private Guna.UI2.WinForms.Guna2TextBox tbox_nom;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}