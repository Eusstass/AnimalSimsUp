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

namespace AnimalSimsUp.windowsAnimal
{
    /// <summary>
    /// Interaktionslogik für shop2.xaml
    /// </summary>
    public partial class shop2 : UserControl
    {
        //public static shop2 shop2Window;
        //Shop1 shop1 = null;
        public shop2()
        {
            InitializeComponent();

            //shop2Window = this;
            //shop1 = Shop1.shop1Window;
        }

        private void zurückButtonShop1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }
    }
}
