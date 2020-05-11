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
    /// Interaction logic for AddPart.xaml
    /// </summary>
    public partial class AddPart : Window
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new PCContext())
            {
                var partType = cb_Type.SelectedIndex;
                switch (partType)
                {
                    case 0:
                        context.CPUs.Add
                            (
                                new CPU()
                                {
                                    Brand = tb_Brand.Text,
                                    Name = tb_Name.Text,
                                    Cost = Int32.Parse(tb_Cost.Text)
                                }
                            );
                        MessageBox.Show("CPU has been added.");
                        break;
                    case 1:
                        context.GPUs.Add
                            (
                                new GPU()
                                {
                                    Brand = tb_Brand.Text,
                                    Name = tb_Name.Text,
                                    Cost = Int32.Parse(tb_Cost.Text)
                                }
                            );
                        MessageBox.Show("GPU has been added.");
                        break;
                    case 2:
                        context.MBs.Add
                            (
                                new MB()
                                {
                                    Brand = tb_Brand.Text,
                                    Name = tb_Name.Text,
                                    Cost = Int32.Parse(tb_Cost.Text)
                                }
                            );
                        MessageBox.Show("Motherboard has been added.");
                        break;
                    case 3:
                        context.RAMs.Add
                            (
                                new RAM()
                                {
                                    Brand = tb_Brand.Text,
                                    Name = tb_Name.Text,
                                    Cost = Int32.Parse(tb_Cost.Text)
                                }
                            );
                        MessageBox.Show("Memory has been added.");
                        break;
                    case 4:
                        context.Storages.Add
                            (
                                new Storage()
                                {
                                    Brand = tb_Brand.Text,
                                    Name = tb_Name.Text,
                                    Cost = Int32.Parse(tb_Cost.Text)
                                }
                            );
                        MessageBox.Show("Storage has been added.");
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
