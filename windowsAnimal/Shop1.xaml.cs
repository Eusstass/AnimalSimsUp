using AnimalSimsUp.Klassen;
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
        public int positionGehege = 0;
        public Shop1()
        {
            InitializeComponent();
            
             //shop1Window = this;
        }
        
        //Der Zurück Knopf
        private void zurückButtonShop1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.mainWindow;
            
        }

        //Die Kauf Buttons
        private void KaufenGehege1_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 0;
        }

        private void KaufenGehege2_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 1;
        }

        private void KaufenGehege3_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 2;
        }

        private void KaufenGehege_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 3;
        }

        //Die Verkauf Buttons
        private void VerkaufenGehege1_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 0;
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == this.positionGehege)
                {
                    Global.TierList.RemoveAt(i);
                }
            }
        }
    }
}
