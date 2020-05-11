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
using System.Windows.Shapes;

namespace CSharp.Net_FinalProject
{
    /// <summary>
    /// Interaction logic for RemovePart.xaml
    /// </summary>
    public partial class RemovePart : Window
    {
        public RemovePart()
        {
            var _mwViewModel = new MainWindowViewModel();
            DataContext = _mwViewModel;
            InitializeComponent();
        }

        private void cb_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb_part.Visibility = Visibility.Visible;
            var partType = cb_Type.SelectedIndex;
            switch (partType)
            {
                case 0:
                    cb_CPU.Visibility = Visibility.Visible;
                    cb_GPU.Visibility = Visibility.Collapsed;
                    cb_MB.Visibility = Visibility.Collapsed;
                    cb_RAM.Visibility = Visibility.Collapsed;
                    cb_Storage.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    cb_CPU.Visibility = Visibility.Collapsed;
                    cb_GPU.Visibility = Visibility.Visible;
                    cb_MB.Visibility = Visibility.Collapsed;
                    cb_RAM.Visibility = Visibility.Collapsed;
                    cb_Storage.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    cb_CPU.Visibility = Visibility.Collapsed;
                    cb_GPU.Visibility = Visibility.Collapsed;
                    cb_MB.Visibility = Visibility.Visible;
                    cb_RAM.Visibility = Visibility.Collapsed;
                    cb_Storage.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    cb_CPU.Visibility = Visibility.Collapsed;
                    cb_GPU.Visibility = Visibility.Collapsed;
                    cb_MB.Visibility = Visibility.Collapsed;
                    cb_RAM.Visibility = Visibility.Visible;
                    cb_Storage.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    cb_CPU.Visibility = Visibility.Collapsed;
                    cb_GPU.Visibility = Visibility.Collapsed;
                    cb_MB.Visibility = Visibility.Collapsed;
                    cb_RAM.Visibility = Visibility.Collapsed;
                    cb_Storage.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new PCContext())
            {
                var partType = cb_Type.SelectedIndex;
                switch (partType)
                {
                    case 0:
                        var c = (from i in context.CPUs where i.Name == cb_CPU.Text select i).FirstOrDefault();
                        context.CPUs.Remove(c);
                        MessageBox.Show("CPU has been removed.");
                        break;
                    case 1:
                        var g = (from i in context.GPUs where i.Name == cb_GPU.Text select i).FirstOrDefault();
                        context.GPUs.Remove(g);
                        MessageBox.Show("GPU has been removed.");
                        break;
                    case 2:
                        var m = (from i in context.MBs where i.Name == cb_MB.Text select i).FirstOrDefault();
                        context.MBs.Remove(m);
                        MessageBox.Show("MB has been removed.");
                        break;
                    case 3:
                        var r = (from i in context.RAMs where i.Name == cb_RAM.Text select i).FirstOrDefault();
                        context.RAMs.Remove(r);
                        MessageBox.Show("RAM has been removed.");
                        break;
                    case 4:
                        var s = (from i in context.Storages where i.Name == cb_Storage.Text select i).FirstOrDefault();
                        context.Storages.Remove(s);
                        MessageBox.Show("Storage has been removed.");
                        break;
                }

                context.SaveChanges();
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
