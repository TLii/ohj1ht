using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Timers;

namespace toMaatti
{
    public class Ajastin
    {

        public bool ajastinKaynnissa;
        public int alkuTunnit;
        public int alkuMinuutit;
        public int alkuSekunnit;
        public int ajastusSekunteina;
        public Timer ajastin;

        public Ajastin(int h = 0, int min = 0, int sek = 0)
        {
            tunnit = h;
            minuutit = min;
            sekunnit = sek;
            ajastin = new Timer(1000);
            ajastin.AutoReset = true;
        }

        /// <summary>
        /// Palauttaa ajastetun ajan sekunteina.
        /// </summary>
        /// <param name="tunnit">Ajastetut tunnit</param>
        /// <param name="minuutit">Ajastetut minuutit</param>
        /// <param name="sekunnit">Ajastetut sekunnit</param>
        /// <returns>Ajastettu aika sekunteina</returns>
        public static int ajastusSekunneiksi(int tunnit = 0, int minuutit = 0, int sekunnit = 0)
        {
            int aika = 0;
            aika += tunnit * 3600;
            aika += minuutit * 60;
            aika += sekunnit;
            return aika;
        }

        /// <summary>
        /// Palauttaa ajastetun sekuntiajan tunneiksi, minuuteiksi ja sekunneiksi.
        /// </summary>
        /// <param name="sek"></param>
        /// <returns>Ajan tunteina, minuutteina ja sekunteina, dictionaryna.</returns>
        public static Dictionary<string, int> ajastusLuettavaksi(int sek)
        {
            TimeSpan aika = TimeSpan.FromSeconds(sek);
            Dictionary<string, int> tulos = new Dictionary<string, int>();
            tulos.Add("t", aika.Hours);
            tulos.Add("min", aika.Minutes);
            tulos.Add("sek", aika.Seconds);
            return tulos;
        }

        /// <summary>
        /// Käynnistää ajastimen.
        /// </summary>
        public void aloita()
        {
            ajastusSekunteina = ajastusSekunneiksi(tunnit, minuutit, sekunnit);
            ajastin.Start();
            
        }
        public void pysayta()
        { }
    }
}
