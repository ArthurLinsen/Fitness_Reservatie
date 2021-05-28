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
using Fitness_Domain.Business;

namespace Fitness_WPF_Moderator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller _controller;
        public MainWindow()
        {
            InitializeComponent();
            _controller = new Controller();

            List<Fitness_Domain.Business.Les> Soortles = _controller.getLessen();
            List<string> SoortLesStrings = new List<string>();
            foreach (Fitness_Domain.Business.Les item in Soortles)
            {
                SoortLesStrings.Add(item.Naam.ToString());
            }
            cbxLessen.ItemsSource = SoortLesStrings;
            cbxLessen.Items.Refresh();
        }

        private void btnVoegVrijeReservatieToe_Click(object sender, RoutedEventArgs e)
        {
            _controller.setReservatie(Convert.ToDateTime(dprDatum.SelectedDate), txtTijdstip.Text, cbxLessen.SelectedIndex);
        }
    }
}
