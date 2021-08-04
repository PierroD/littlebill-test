using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleBill_test_frontend.Colors;
using LittleBill_test_frontend.Helpers;
using LittleBill_test_frontend.Models.WeatherModel;
using LittleBill_test_frontend.Properties;
using LittleBill_test_frontend.UserControls;
using LittleBill_test_frontend_library;

namespace LittleBill_test_frontend
{
    public partial class form_LittleBill_Test : Form
    {
        private Form opener;
        private int historiqueSize = 10;
        public form_LittleBill_Test(Form parentform)
        {
            InitializeComponent();
            opener = parentform;
        }

        private void form_LittleBill_Test_Load(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            flp_historique.Visible = !flp_historique.Visible;
            sb_historique.Visible = !sb_historique.Visible;
            refreshHistoriquePanel();
        }

        private void tbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && StringHelper.isNotNullOrEmpty(tbox_search.Text))
                SearchCity(tbox_search.Text);
        }


        private void form_LittleBill_Test_Shown(object sender, EventArgs e)
        {
            changeOpenerVisibility();
            SearchCity("Lyon");
            LoadHistorique();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            HistoriqueHelpers.SaveHistorique();
            changeOpenerVisibility();
        }

        private void sb_quotes_ValueChanged(object sender, EventArgs e)
        {
            if ((sb_historique.Value >= sb_historique.Maximum - sb_historique.ScrollbarSize) && (this.historiqueSize <= HistoriqueHelpers.Count()))
            {
                this.historiqueSize += 10;
                refreshHistoriquePanel();
            }
        }

        private void refreshHistoriquePanel()
        {
            flp_historique.Controls.Clear();
            var historique = HistoriqueHelpers.GetAll();
            for (int i = 0; i < this.historiqueSize; i++)
            {
                if (i < HistoriqueHelpers.Count())
                    flp_historique.Controls.Add(new UC_Historique(historique.ElementAt(i)));
            }
        }

        private void changeOpenerVisibility()
        {
            this.opener.Visible = !this.opener.Visible;
        }

        private void LoadHistorique()
        {
            HistoriqueHelpers.LoadHistoriqe();
        }

        private async void SearchCity(string cityName)
        {
            dynamic weather = await Library.Search(cityName);

            lbl_ville.Text = $"{weather.name}, {weather.sys.country}";
            lbl_date.Text = DateTime.Today.ToLongDateString();

            lbl_humiditePourcentage.Text = $"{weather.main.humidity}%";
            lbl_humiditeLibelle.Text = humiditeStatus(weather.main.humidity);

            lbl_ventVitesse.Text = $"{weather.wind.speed} km/h";
            lbl_ventOrientation.Text = directionVent(weather.wind.deg);

            double visibilite = weather.visibility / 1000;
            lbl_visibiliteDistance.Text = $"{visibilite} km";
            lbl_visibiliteLibelle.Text = visibiliteStatus(visibilite);

            lbl_soleilSunrise.Text = timestampToString(weather.sys.sunrise);
            lbl_soleilSunset.Text = timestampToString(weather.sys.sunset);

            lbl_temperature.Text = $"{weather.main.temp}°C";
            lbl_temperature.ForeColor = temperatureColor(weather.main.temp);


            pic_weather.Image = (Bitmap)Resources.ResourceManager.GetObject(weather.weather[0].icon);
            HistoriqueHelpers.AddToHistorique(weather);
            refreshHistoriquePanel();
        }


        private string humiditeStatus(int humidite)
        {
            switch (humidite)
            {
                case int h when (h > 30):
                    return "Humide";
                case int h when (h > 60):
                    return "Très Humide";
                case int h when (h < 30):
                    return "Sec";
                default:
                    return "Trop sec";
            }
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

        private string timestampToString(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp).ToString(@"hh\:mm").Replace(":", "h");
        }

        private string visibiliteStatus(double visibilite)
        {
            switch (visibilite)
            {
                case double n when (n >= 7):
                    return "Normale";
                case double n when (n >= 5):
                    return "Moyenne";
                default:
                    return "Mauvaise";
            }
        }

        private string directionVent(double degre)
        {
            int val = (int)((degre / 22.5) + 0.5);
            string[] windDirection = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSO", "SO", "OSO", "O", "ONO", "NO", "NNO" };
            return windDirection[(val % 16)];
        }

        private void lbl_ville_Click(object sender, EventArgs e)
        {

        }
    }
}
