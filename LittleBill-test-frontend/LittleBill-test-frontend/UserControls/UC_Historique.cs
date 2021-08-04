using Guna.UI2.WinForms;
using LittleBill_test_frontend.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBill_test_frontend.UserControls
{
    public partial class UC_Historique : UserControl
    {
        private HistoriqueItem item;
        public UC_Historique(HistoriqueItem item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void btn_deleteHistorique_Click(object sender, EventArgs e)
        {
            HistoriqueHelpers.DeleteFromHistorique(this.item);
            Control parent = Parent;
            while (!(parent is Form))
                parent = parent.Parent;
            Guna2Button btn_historique = (Guna2Button)parent.Controls.Find("btn_historique", true).FirstOrDefault();
            btn_historique.PerformClick();
            btn_historique.PerformClick();
        }

        private void UC_Historique_Load(object sender, EventArgs e)
        {
            lbl_ville.Text = this.item.weather.name;
            lbl_temperature.Text = $"{this.item.weather.main.temp}°C";
        }

        private Color temperatureColor(double temperature)
        {
            switch (temperature)
            {
                case double t when (t > 15):
                    return Color.LimeGreen;
                case double t when (t > 25):
                    return Color.OrangeRed;
                case double t when (t > 40):
                    return Color.Red;
                case double t when (t < 15):
                    return Color.LightBlue;
                default:
                    return Color.DarkBlue;
            }
        }

    }
}
