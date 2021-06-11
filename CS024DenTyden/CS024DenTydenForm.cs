using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS024DenTyden
{
    public partial class CS024DenTydenForm : Form
    {
        public CS024DenTydenForm()
        {
            InitializeComponent();
        }

        /*public static string DenNazev(int cislo)
        {
            switch (cislo)
            {
                case 1: return "Pondělí";
                case 2: return "Úterý";
                case 3: return "Středa";
                case 4: return "Čtvrtek";
                case 5: return "Pátek";
                case 6: return "Sobota";
                case 7: return "Neděle";
                   
                default:
                    return "?";
                   
            }
        }*/
        public static string DenNazev2(int cislo)
        {
            string[] dny = { "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle"};
            return dny[cislo];
        }

        private void cisloDenTexBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cisloDneLabel.Text = DenNazev2(int.Parse(cisloDenTexBox.Text));
            }
            catch
            {

            }
        }

        
    }
    
}
