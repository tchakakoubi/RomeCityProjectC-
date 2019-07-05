using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RomeCity
{
    /// <summary>
    /// Interaktionslogik für Diagramm.xaml
    /// </summary>
    public partial class Diagramm : Page
    {
        public Diagramm()
        {
            InitializeComponent();

            Spaß spaß = new Spaß();

            DataContext = new spaßViewModel(spaß);
           

        }
    }

    internal class spaßViewModel
    {
        public List<Spaß> Spaß { get; private set; }

        public spaßViewModel(Spaß spaß)
        {
            Spaß = new List<Spaß>();
            Spaß.Add(spaß);
        }
    }

    internal class Spaß
    {
        public string Titulo { get; private set; }
       

        public int Prozent { get; private set; }

        public Spaß()
        {
            Titulo = " Spaß Actuel";
           
            Prozent = CalcularPorcentag();

        }

        private int CalcularPorcentag()
        {
            return 47;          // calcul 
        }
    }
}
