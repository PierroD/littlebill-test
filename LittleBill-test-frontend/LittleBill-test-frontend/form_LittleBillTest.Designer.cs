
namespace LittleBill_test_frontend
{
    partial class form_LittleBill_Test
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.pic_location = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_bg = new Guna.UI2.WinForms.Guna2Panel();
            this.sb_historique = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flp_historique = new System.Windows.Forms.FlowLayoutPanel();
            this.tbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_top = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pic_weather = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lbl_soleilSunset = new System.Windows.Forms.Label();
            this.lbl_soleilSunrise = new System.Windows.Forms.Label();
            this.lbl_soleil = new System.Windows.Forms.Label();
            this.lbl_ventOrientation = new System.Windows.Forms.Label();
            this.lbl_ventVitesse = new System.Windows.Forms.Label();
            this.lbl_vent = new System.Windows.Forms.Label();
            this.lbl_visibiliteLibelle = new System.Windows.Forms.Label();
            this.lbl_visibiliteDistance = new System.Windows.Forms.Label();
            this.lbl_visibilite = new System.Windows.Forms.Label();
            this.lbl_humiditeLibelle = new System.Windows.Forms.Label();
            this.lbl_humiditePourcentage = new System.Windows.Forms.Label();
            this.lbl_humidite = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_historique = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_location)).BeginInit();
            this.pnl_bg.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 15;
            this.elipse_form.TargetControl = this;
            // 
            // form_drag
            // 
            this.form_drag.TargetControl = this.pnl_bg;
            this.form_drag.TransparentWhileDrag = true;
            this.form_drag.UseTransparentDrag = true;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.lbl_date.Location = new System.Drawing.Point(22, 12);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 21);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ville.ForeColor = System.Drawing.Color.White;
            this.lbl_ville.Location = new System.Drawing.Point(39, 44);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(49, 25);
            this.lbl_ville.TabIndex = 1;
            this.lbl_ville.Text = "Ville";
            this.lbl_ville.Click += new System.EventHandler(this.lbl_ville_Click);
            // 
            // pic_location
            // 
            this.pic_location.Image = global::LittleBill_test_frontend.Properties.Resources.Location;
            this.pic_location.ImageRotate = 0F;
            this.pic_location.Location = new System.Drawing.Point(9, 44);
            this.pic_location.Name = "pic_location";
            this.pic_location.ShadowDecoration.Parent = this.pic_location;
            this.pic_location.Size = new System.Drawing.Size(24, 24);
            this.pic_location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_location.TabIndex = 2;
            this.pic_location.TabStop = false;
            // 
            // pnl_bg
            // 
            this.pnl_bg.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bg.BackgroundImage = global::LittleBill_test_frontend.Properties.Resources.background_image;
            this.pnl_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_bg.Controls.Add(this.sb_historique);
            this.pnl_bg.Controls.Add(this.tbox_search);
            this.pnl_bg.Controls.Add(this.pnl_top);
            this.pnl_bg.Controls.Add(this.guna2GradientPanel1);
            this.pnl_bg.Controls.Add(this.flp_historique);
            this.pnl_bg.Controls.Add(this.lbl_search);
            this.pnl_bg.Controls.Add(this.btn_historique);
            this.pnl_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bg.Location = new System.Drawing.Point(0, 0);
            this.pnl_bg.Name = "pnl_bg";
            this.pnl_bg.ShadowDecoration.Parent = this.pnl_bg;
            this.pnl_bg.Size = new System.Drawing.Size(1264, 681);
            this.pnl_bg.TabIndex = 3;
            // 
            // sb_historique
            // 
            this.sb_historique.AutoRoundedCorners = true;
            this.sb_historique.BindingContainer = this.flp_historique;
            this.sb_historique.BorderRadius = 6;
            this.sb_historique.FillOffset = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.sb_historique.HoverState.Parent = null;
            this.sb_historique.InUpdate = false;
            this.sb_historique.LargeChange = 10;
            this.sb_historique.Location = new System.Drawing.Point(1241, 63);
            this.sb_historique.Name = "sb_historique";
            this.sb_historique.Padding = new System.Windows.Forms.Padding(0);
            this.sb_historique.PressedState.Parent = this.sb_historique;
            this.sb_historique.ScrollbarSize = 15;
            this.sb_historique.Size = new System.Drawing.Size(15, 584);
            this.sb_historique.TabIndex = 9;
            this.sb_historique.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.sb_historique.Visible = false;
            this.sb_historique.ValueChanged += new System.EventHandler(this.sb_quotes_ValueChanged);
            // 
            // flp_historique
            // 
            this.flp_historique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flp_historique.Location = new System.Drawing.Point(703, 63);
            this.flp_historique.Name = "flp_historique";
            this.flp_historique.Size = new System.Drawing.Size(536, 584);
            this.flp_historique.TabIndex = 6;
            this.flp_historique.Visible = false;
            // 
            // tbox_search
            // 
            this.tbox_search.BorderRadius = 20;
            this.tbox_search.BorderThickness = 0;
            this.tbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_search.DefaultText = "";
            this.tbox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_search.DisabledState.Parent = this.tbox_search;
            this.tbox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_search.FocusedState.Parent = this.tbox_search;
            this.tbox_search.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tbox_search.ForeColor = System.Drawing.Color.White;
            this.tbox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_search.HoverState.Parent = this.tbox_search;
            this.tbox_search.IconLeft = global::LittleBill_test_frontend.Properties.Resources.search;
            this.tbox_search.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tbox_search.IconLeftSize = new System.Drawing.Size(24, 24);
            this.tbox_search.Location = new System.Drawing.Point(312, 48);
            this.tbox_search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.tbox_search.PlaceholderText = "Lyon";
            this.tbox_search.SelectedText = "";
            this.tbox_search.ShadowDecoration.Parent = this.tbox_search;
            this.tbox_search.Size = new System.Drawing.Size(230, 45);
            this.tbox_search.TabIndex = 5;
            this.tbox_search.TextOffset = new System.Drawing.Point(20, 0);
            this.tbox_search.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.tbox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_search_KeyPress);
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
            this.pnl_top.Location = new System.Drawing.Point(1131, -2);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.ShadowDecoration.Parent = this.pnl_top;
            this.pnl_top.Size = new System.Drawing.Size(135, 43);
            this.pnl_top.TabIndex = 8;
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
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 25;
            this.guna2GradientPanel1.Controls.Add(this.pic_weather);
            this.guna2GradientPanel1.Controls.Add(this.lbl_temperature);
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.lbl_soleilSunset);
            this.guna2GradientPanel1.Controls.Add(this.lbl_soleilSunrise);
            this.guna2GradientPanel1.Controls.Add(this.lbl_soleil);
            this.guna2GradientPanel1.Controls.Add(this.lbl_ventOrientation);
            this.guna2GradientPanel1.Controls.Add(this.lbl_ventVitesse);
            this.guna2GradientPanel1.Controls.Add(this.lbl_vent);
            this.guna2GradientPanel1.Controls.Add(this.lbl_visibiliteLibelle);
            this.guna2GradientPanel1.Controls.Add(this.lbl_visibiliteDistance);
            this.guna2GradientPanel1.Controls.Add(this.lbl_visibilite);
            this.guna2GradientPanel1.Controls.Add(this.lbl_humiditeLibelle);
            this.guna2GradientPanel1.Controls.Add(this.lbl_humiditePourcentage);
            this.guna2GradientPanel1.Controls.Add(this.lbl_humidite);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(44, 112);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(615, 535);
            this.guna2GradientPanel1.TabIndex = 7;
            // 
            // pic_weather
            // 
            this.pic_weather.FillColor = System.Drawing.Color.Transparent;
            this.pic_weather.Image = global::LittleBill_test_frontend.Properties.Resources._13n;
            this.pic_weather.ImageRotate = 0F;
            this.pic_weather.Location = new System.Drawing.Point(268, 18);
            this.pic_weather.Name = "pic_weather";
            this.pic_weather.ShadowDecoration.Parent = this.pic_weather;
            this.pic_weather.Size = new System.Drawing.Size(85, 85);
            this.pic_weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_weather.TabIndex = 18;
            this.pic_weather.TabStop = false;
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_temperature.ForeColor = System.Drawing.Color.White;
            this.lbl_temperature.Location = new System.Drawing.Point(0, 467);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(615, 32);
            this.lbl_temperature.TabIndex = 17;
            this.lbl_temperature.Text = "13°C";
            this.lbl_temperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(299, 109);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(18, 336);
            this.guna2VSeparator1.TabIndex = 16;
            // 
            // lbl_soleilSunset
            // 
            this.lbl_soleilSunset.AutoSize = true;
            this.lbl_soleilSunset.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_soleilSunset.ForeColor = System.Drawing.Color.White;
            this.lbl_soleilSunset.Location = new System.Drawing.Point(427, 388);
            this.lbl_soleilSunset.Name = "lbl_soleilSunset";
            this.lbl_soleilSunset.Size = new System.Drawing.Size(63, 25);
            this.lbl_soleilSunset.TabIndex = 15;
            this.lbl_soleilSunset.Text = "21h45";
            // 
            // lbl_soleilSunrise
            // 
            this.lbl_soleilSunrise.AutoSize = true;
            this.lbl_soleilSunrise.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_soleilSunrise.ForeColor = System.Drawing.Color.White;
            this.lbl_soleilSunrise.Location = new System.Drawing.Point(431, 363);
            this.lbl_soleilSunrise.Name = "lbl_soleilSunrise";
            this.lbl_soleilSunrise.Size = new System.Drawing.Size(53, 25);
            this.lbl_soleilSunrise.TabIndex = 14;
            this.lbl_soleilSunrise.Text = "8h30";
            // 
            // lbl_soleil
            // 
            this.lbl_soleil.AutoSize = true;
            this.lbl_soleil.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soleil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_soleil.Location = new System.Drawing.Point(416, 326);
            this.lbl_soleil.Name = "lbl_soleil";
            this.lbl_soleil.Size = new System.Drawing.Size(82, 37);
            this.lbl_soleil.TabIndex = 13;
            this.lbl_soleil.Text = "Soleil";
            // 
            // lbl_ventOrientation
            // 
            this.lbl_ventOrientation.AutoSize = true;
            this.lbl_ventOrientation.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lbl_ventOrientation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_ventOrientation.Location = new System.Drawing.Point(436, 129);
            this.lbl_ventOrientation.Name = "lbl_ventOrientation";
            this.lbl_ventOrientation.Size = new System.Drawing.Size(37, 23);
            this.lbl_ventOrientation.TabIndex = 12;
            this.lbl_ventOrientation.Text = "ESE";
            // 
            // lbl_ventVitesse
            // 
            this.lbl_ventVitesse.AutoSize = true;
            this.lbl_ventVitesse.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_ventVitesse.ForeColor = System.Drawing.Color.White;
            this.lbl_ventVitesse.Location = new System.Drawing.Point(414, 97);
            this.lbl_ventVitesse.Name = "lbl_ventVitesse";
            this.lbl_ventVitesse.Size = new System.Drawing.Size(91, 32);
            this.lbl_ventVitesse.TabIndex = 11;
            this.lbl_ventVitesse.Text = "8 km/h";
            // 
            // lbl_vent
            // 
            this.lbl_vent.AutoSize = true;
            this.lbl_vent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_vent.Location = new System.Drawing.Point(416, 60);
            this.lbl_vent.Name = "lbl_vent";
            this.lbl_vent.Size = new System.Drawing.Size(70, 37);
            this.lbl_vent.TabIndex = 10;
            this.lbl_vent.Text = "Vent";
            // 
            // lbl_visibiliteLibelle
            // 
            this.lbl_visibiliteLibelle.AutoSize = true;
            this.lbl_visibiliteLibelle.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lbl_visibiliteLibelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_visibiliteLibelle.Location = new System.Drawing.Point(100, 395);
            this.lbl_visibiliteLibelle.Name = "lbl_visibiliteLibelle";
            this.lbl_visibiliteLibelle.Size = new System.Drawing.Size(67, 23);
            this.lbl_visibiliteLibelle.TabIndex = 9;
            this.lbl_visibiliteLibelle.Text = "Normal";
            // 
            // lbl_visibiliteDistance
            // 
            this.lbl_visibiliteDistance.AutoSize = true;
            this.lbl_visibiliteDistance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_visibiliteDistance.ForeColor = System.Drawing.Color.White;
            this.lbl_visibiliteDistance.Location = new System.Drawing.Point(98, 363);
            this.lbl_visibiliteDistance.Name = "lbl_visibiliteDistance";
            this.lbl_visibiliteDistance.Size = new System.Drawing.Size(81, 32);
            this.lbl_visibiliteDistance.TabIndex = 8;
            this.lbl_visibiliteDistance.Text = "10 km";
            // 
            // lbl_visibilite
            // 
            this.lbl_visibilite.AutoSize = true;
            this.lbl_visibilite.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibilite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_visibilite.Location = new System.Drawing.Point(79, 326);
            this.lbl_visibilite.Name = "lbl_visibilite";
            this.lbl_visibilite.Size = new System.Drawing.Size(119, 37);
            this.lbl_visibilite.TabIndex = 7;
            this.lbl_visibilite.Text = "Visibilité";
            // 
            // lbl_humiditeLibelle
            // 
            this.lbl_humiditeLibelle.AutoSize = true;
            this.lbl_humiditeLibelle.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lbl_humiditeLibelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_humiditeLibelle.Location = new System.Drawing.Point(100, 129);
            this.lbl_humiditeLibelle.Name = "lbl_humiditeLibelle";
            this.lbl_humiditeLibelle.Size = new System.Drawing.Size(70, 23);
            this.lbl_humiditeLibelle.TabIndex = 6;
            this.lbl_humiditeLibelle.Text = "Humide";
            // 
            // lbl_humiditePourcentage
            // 
            this.lbl_humiditePourcentage.AutoSize = true;
            this.lbl_humiditePourcentage.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_humiditePourcentage.ForeColor = System.Drawing.Color.White;
            this.lbl_humiditePourcentage.Location = new System.Drawing.Point(109, 97);
            this.lbl_humiditePourcentage.Name = "lbl_humiditePourcentage";
            this.lbl_humiditePourcentage.Size = new System.Drawing.Size(61, 32);
            this.lbl_humiditePourcentage.TabIndex = 5;
            this.lbl_humiditePourcentage.Text = "30%";
            // 
            // lbl_humidite
            // 
            this.lbl_humidite.AutoSize = true;
            this.lbl_humidite.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbl_humidite.Location = new System.Drawing.Point(79, 60);
            this.lbl_humidite.Name = "lbl_humidite";
            this.lbl_humidite.Size = new System.Drawing.Size(127, 37);
            this.lbl_humidite.TabIndex = 4;
            this.lbl_humidite.Text = "Humidité";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.White;
            this.lbl_search.Location = new System.Drawing.Point(338, 18);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(175, 25);
            this.lbl_search.TabIndex = 4;
            this.lbl_search.Text = "Recherche une ville";
            // 
            // btn_historique
            // 
            this.btn_historique.BorderRadius = 20;
            this.btn_historique.CheckedState.Parent = this.btn_historique;
            this.btn_historique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historique.CustomImages.Parent = this.btn_historique;
            this.btn_historique.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_historique.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_historique.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_historique.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_historique.DisabledState.Parent = this.btn_historique;
            this.btn_historique.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_historique.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historique.ForeColor = System.Drawing.Color.White;
            this.btn_historique.HoverState.Parent = this.btn_historique;
            this.btn_historique.Image = global::LittleBill_test_frontend.Properties.Resources.history;
            this.btn_historique.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_historique.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_historique.Location = new System.Drawing.Point(861, 12);
            this.btn_historique.Name = "btn_historique";
            this.btn_historique.ShadowDecoration.Parent = this.btn_historique;
            this.btn_historique.Size = new System.Drawing.Size(193, 45);
            this.btn_historique.TabIndex = 0;
            this.btn_historique.Text = "Historique";
            this.btn_historique.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // form_LittleBill_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pic_location);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.pnl_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_LittleBill_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Little Bill Test";
            this.Load += new System.EventHandler(this.form_LittleBill_Test_Load);
            this.Shown += new System.EventHandler(this.form_LittleBill_Test_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_location)).EndInit();
            this.pnl_bg.ResumeLayout(false);
            this.pnl_bg.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
        private Guna.UI2.WinForms.Guna2DragControl form_drag;
        private Guna.UI2.WinForms.Guna2PictureBox pic_location;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label lbl_date;
        private Guna.UI2.WinForms.Guna2Panel pnl_bg;
        private Guna.UI2.WinForms.Guna2TextBox tbox_search;
        private System.Windows.Forms.Label lbl_search;
        private Guna.UI2.WinForms.Guna2Button btn_historique;
        private Guna.UI2.WinForms.Guna2Panel pnl_top;
        private Guna.UI2.WinForms.Guna2ControlBox btn_minimize;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label lbl_soleilSunset;
        private System.Windows.Forms.Label lbl_soleilSunrise;
        private System.Windows.Forms.Label lbl_soleil;
        private System.Windows.Forms.Label lbl_ventOrientation;
        private System.Windows.Forms.Label lbl_ventVitesse;
        private System.Windows.Forms.Label lbl_vent;
        private System.Windows.Forms.Label lbl_visibiliteLibelle;
        private System.Windows.Forms.Label lbl_visibiliteDistance;
        private System.Windows.Forms.Label lbl_visibilite;
        private System.Windows.Forms.Label lbl_humiditeLibelle;
        private System.Windows.Forms.Label lbl_humiditePourcentage;
        private System.Windows.Forms.Label lbl_humidite;
        private System.Windows.Forms.FlowLayoutPanel flp_historique;
        private System.Windows.Forms.Label lbl_temperature;
        private Guna.UI2.WinForms.Guna2VScrollBar sb_historique;
        private Guna.UI2.WinForms.Guna2PictureBox pic_weather;
    }
}

