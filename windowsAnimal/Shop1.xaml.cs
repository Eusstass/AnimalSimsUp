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

namespace AnimalSimsUp
{
    /// <summary>
    /// Interaktionslogik für Shop1.xaml
    /// </summary>
    public partial class Shop1 : UserControl
    {
        //AnimalSimsUp.windowsAnimal.shop2 shop2 = new AnimalSimsUp.windowsAnimal.shop2();
        //public static Shop1 shop1Window;
        public int shopIndex;

        public Shop1()
        {
            InitializeComponent();
            //shop1Window = this;
        }

        private void zurückButtonShop1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.mainWindow;
        }

        private void KaufenGehege1_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            shopIndex = 1;
        }

        private void KaufenGehege2_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            shopIndex = 2;
        }

        private void KaufenGehege3_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            shopIndex = 3;
        }

        private void KaufenGehege_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            shopIndex = 0;
        }
    }
}
