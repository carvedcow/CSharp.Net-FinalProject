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

namespace CSharp.Net_FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var _mwViewModel = new MainWindowViewModel();
            //_mwViewModel.FirstName = "John";
            DataContext = _mwViewModel;
            //_mwViewModel.FirstName = "Mark";
            //_mwViewModel.OnPropertyChanged(nameof(_mwViewModel.FirstName));
            InitializeComponent();
        }

        // On Load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        // Resets all combobox selected items to null
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            List<ComboBox> cbList = new List<ComboBox>();
            cbList.Add(cb_CPU);
            cbList.Add(cb_GPU);
            cbList.Add(cb_MB);
            cbList.Add(cb_RAM);
            cbList.Add(cb_Storage);
            foreach (ComboBox cb in cbList)
            {
                cb.SelectedItem = null;
            }
        }

        // Add Part Button
        private void AddPart_Click(object sender, RoutedEventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Closed += Window_Closed;
            addPart.Show();

        }

        

        // Edit Part Button
        private void EditPart_Click(object sender, RoutedEventArgs e)
        {
            EditPart editPart = new EditPart();
            editPart.Show();
        }

        // Remove Part Button
        private void RemovePart_Click(object sender, RoutedEventArgs e)
        {
            RemovePart removePart = new RemovePart();
            removePart.Closed += Window_Closed;
            removePart.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //refresh data bindings
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int totalCost = 0;
            if (cb_CPU.SelectedValue != null)
            {
                totalCost += Int32.Parse(cb_CPU.SelectedValue.ToString());
            }

            if (cb_GPU.SelectedValue != null)
            {
                totalCost += Int32.Parse(cb_GPU.SelectedValue.ToString());
            }

            if (cb_MB.SelectedValue != null)
            {
                totalCost += Int32.Parse(cb_MB.SelectedValue.ToString());
            }

            if (cb_RAM.SelectedValue != null)
            {
                totalCost += Int32.Parse(cb_RAM.SelectedValue.ToString());
            }

            if (cb_Storage.SelectedValue != null)
            {
                totalCost += Int32.Parse(cb_Storage.SelectedValue.ToString());
            }

            lb_TotalCost.Content = totalCost;
        }
    }
}
