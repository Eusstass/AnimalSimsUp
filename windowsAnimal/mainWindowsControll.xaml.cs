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
        //Shop1 shop1 = new Shop1();
        //public static mainWindowsControll mainwindowControll;
        public int gehegeIndex;


        public mainWindowsControll()
        {
            InitializeComponent();


            //mainwindowControll = this;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }

        private void gehegeSelect1(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex= 0;
        }

        private void gehegeSelect2(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex= 1;
        }

        private void gehegeSelect3(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex= 2;
        }

        private void gehegeSelect4(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex= 3;
        }

        private void fuettern_Click(object sender, RoutedEventArgs e)
        {
            Global.tierList[gehegeIndex].futterValue += 40;
            if (Global.tierList[gehegeIndex].futterValue > 100)
            {
                Global.tierList[gehegeIndex].futterValue = 100;
            }
            Global.futterProgressBarList[gehegeIndex].Value = Global.tierList[gehegeIndex].futterValue;
        }

        private void Pflegen_Click(object sender, RoutedEventArgs e)
        {
            Global.tierList[gehegeIndex].pflegeValue += 40;
            if (Global.tierList[gehegeIndex].pflegeValue > 100)
            {
                Global.tierList[gehegeIndex].pflegeValue = 100;
            }
            Global.pflegeProgressBarList[gehegeIndex].Value = Global.tierList[gehegeIndex].pflegeValue;
        }

        private void Streicheln_Click(object sender, RoutedEventArgs e)
        {
            Global.tierList[gehegeIndex].liebeValue += 40;
            if (Global.tierList[gehegeIndex].liebeValue > 100)
            {
                Global.tierList[gehegeIndex].liebeValue = 100;
            }
            Global.liebeProgressBarList[gehegeIndex].Value = Global.tierList[gehegeIndex].liebeValue;
        }


    }
}
