using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Car> cars = new();
        TurboAzContext Context = new TurboAzContext();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var car in Context.Cars.ToList())
            {
                cars.Add(car);
            }

            CarListView.ItemsSource = cars;
            DataContext = this;

            List<string> bzmarka = new List<string>();
            foreach (var marka in Context.Markas.ToList())
            {
                bzmarka.Add(marka.MarkaName);
            }
            MarkaCBX.ItemsSource = bzmarka;

            List<string> bzcity = new List<string>();
            foreach (var sheher in Context.Shehers.ToList())
            {
                bzcity.Add(sheher.Sheher1);
            }
            CityCBX.ItemsSource = bzcity;

            List<string> bzacc = new List<string>();
            foreach (var acc in Context.SuretQutusus.ToList())
            {
                bzacc.Add(acc.SuretQutusu1);
            }
            AccBoxCBX.ItemsSource = bzacc;


            List<string> bzcolor = new List<string>();
            foreach (var color in Context.Rengs.ToList())
            {
                bzcolor.Add(color.Reng1);
            }
            ColorTBX.ItemsSource = bzcolor;

            List<string> bzfuel = new List<string>();
            foreach (var fuel in Context.Yanacags.ToList())
            {
                bzfuel.Add(fuel.Yanacag1);
            }
            fUELTYPETBX.ItemsSource = bzfuel;



        }





        private void MarkaCBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedMarkaname = MarkaCBX.SelectedItem.ToString();
            Marka marka = new Marka();
            foreach (var item in Context.Markas.ToList())
            {
                if (item.MarkaName == selectedMarkaname)
                {
                    marka = item;
                }
            }
            if (marka != null)
            {
                int selectedMarkaID = marka.Id + 2;
                var filteredModeller = Context.Models.Where(m => m.MarkaId == selectedMarkaID).ToList();
                List<string> bzmaasa = new List<string>();
                foreach (var item in filteredModeller)
                {
                    bzmaasa.Add(item.ModelName);
                }
                ModelCBX.ItemsSource = bzmaasa;
            }
        }
    }
}
