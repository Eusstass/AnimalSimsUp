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

namespace AnimalSimsUp.windowsAnimal
{
    /// <summary>
    /// Interaktionslogik für mainWindowsControll.xaml
    /// </summary>
    public partial class mainWindowsControll : UserControl
    {
        public mainWindowsControll()
        {
            InitializeComponent();            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }

        //Wenn ein Tier selectet wird
        private void Tier1Image_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == 0)
                {
                    selectetAnimal.Content = Global.TierList[i].tier.art + " Gehege 1";
                }
            }
        }

        private void Tier2Image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == 1)
                {
                    selectetAnimal.Content = Global.TierList[i].tier.art + " Gehege 2";
                }
            }
        }

        private void Tier3Image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == 2)
                {
                    selectetAnimal.Content = Global.TierList[i].tier.art + " Gehege 3";
                }
            }
        }

        private void Tier4Image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == 3)
                {
                    selectetAnimal.Content = Global.TierList[i].tier.art + " Gehege 4";
                }
            }
        }
    }
}
