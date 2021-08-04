
namespace LittleBill_test_frontend.UserControls
{
    partial class UC_Historique
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.elipse_uc = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_ville = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.btn_deleteHistorique = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.elipse_panel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipse_uc
            // 
            this.elipse_uc.BorderRadius = 20;
            this.elipse_uc.TargetControl = this;
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ville.ForeColor = System.Drawing.Color.White;
            this.lbl_ville.Location = new System.Drawing.Point(67, 15);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(49, 25);
            this.lbl_ville.TabIndex = 2;
            this.lbl_ville.Text = "Ville";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperature.ForeColor = System.Drawing.Color.White;
            this.lbl_temperature.Location = new System.Drawing.Point(272, 15);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(42, 25);
            this.lbl_temperature.TabIndex = 3;
            this.lbl_temperature.Text = "0°C";
            // 
            // btn_deleteHistorique
            // 
            this.btn_deleteHistorique.CheckedState.Parent = this.btn_deleteHistorique;
            this.btn_deleteHistorique.CustomImages.Parent = this.btn_deleteHistorique;
            this.btn_deleteHistorique.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteHistorique.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteHistorique.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteHistorique.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteHistorique.DisabledState.Parent = this.btn_deleteHistorique;
            this.btn_deleteHistorique.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteHistorique.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteHistorique.ForeColor = System.Drawing.Color.White;
            this.btn_deleteHistorique.HoverState.Parent = this.btn_deleteHistorique;
            this.btn_deleteHistorique.Image = global::LittleBill_test_frontend.Properties.Resources.close_history;
            this.btn_deleteHistorique.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_deleteHistorique.ImageOffset = new System.Drawing.Point(-7, 0);
            this.btn_deleteHistorique.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_deleteHistorique.Location = new System.Drawing.Point(445, 7);
            this.btn_deleteHistorique.Name = "btn_deleteHistorique";
            this.btn_deleteHistorique.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_deleteHistorique.ShadowDecoration.Parent = this.btn_deleteHistorique;
            this.btn_deleteHistorique.Size = new System.Drawing.Size(40, 40);
            this.btn_deleteHistorique.TabIndex = 4;
            this.btn_deleteHistorique.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deleteHistorique.Click += new System.EventHandler(this.btn_deleteHistorique_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.guna2Panel1.BorderRadius = 26;
            this.guna2Panel1.Controls.Add(this.btn_deleteHistorique);
            this.guna2Panel1.Controls.Add(this.lbl_ville);
            this.guna2Panel1.Controls.Add(this.lbl_temperature);
            this.guna2Panel1.Location = new System.Drawing.Point(18, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(499, 54);
            this.guna2Panel1.TabIndex = 5;
            // 
            // elipse_panel
            // 
            this.elipse_panel.BorderRadius = 20;
            this.elipse_panel.TargetControl = this.guna2Panel1;
            // 
            // UC_Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_Historique";
            this.Size = new System.Drawing.Size(530, 67);
            this.Load += new System.EventHandler(this.UC_Historique_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_uc;
        private System.Windows.Forms.Label lbl_ville;
        private Guna.UI2.WinForms.Guna2CircleButton btn_deleteHistorique;
        private System.Windows.Forms.Label lbl_temperature;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse elipse_panel;
    }
}
