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

namespace Fitness_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //fields
        private Controller _controller;
        public MainWindow()
        {
            InitializeComponent();
            _controller = new Controller();

            cbxLid.ItemsSource = _controller.getLeden();
            cbxLid.Items.Refresh();

            cbxLes.ItemsSource = _controller.getLessen();
            cbxLes.Items.Refresh();

            cbxCategorie.ItemsSource = _controller.getCategories();
            cbxCategorie.Items.Refresh();

            cbxReservatie.ItemsSource = _controller.getReservaties();
            cbxReservatie.Items.Refresh();

            cbxFitnessClub.ItemsSource = _controller.getFitnessClubs();
            cbxFitnessClub.Items.Refresh();

            cbxFitnessClubGeeftLes.ItemsSource = _controller.getFitnessClubGeeftLes();
            cbxFitnessClubGeeftLes.Items.Refresh();
        }
        private void btnVoegLidToe_Click(object sender, RoutedEventArgs e)
        {
            Lid lid = new Lid(txtFamilieNaam.Text, txtVoornaam.Text, Convert.ToDateTime(dpkGeboortedatum.SelectedDate), txtAdres.Text, Convert.ToInt32(txtPostcode.Text), txtGemeente.Text, txtTelefoonnummer.Text, txtEmailadres.Text, txtRijksregisternummer.Text);
            //_controller.setLid(lid);
        }
    }
}
