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
<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
        public mainWindowsControll()
        {
            InitializeComponent();


            //mainwindowControll = this;

            Global.futterProgressBarList.Add(this.Tier1Nahrung);
            Global.futterProgressBarList.Add(this.Tier2Nahrung);
            Global.futterProgressBarList.Add(this.Tier3Nahrung);
            Global.futterProgressBarList.Add(this.Tier4Nahrung);

            Global.pflegeProgressBarList.Add(this.Tier1Pflege);
            Global.pflegeProgressBarList.Add(this.Tier2Pflege);
            Global.pflegeProgressBarList.Add(this.Tier3Pflege);
            Global.pflegeProgressBarList.Add(this.Tier4Pflege);

            Global.liebeProgressBarList.Add(this.Tier1Liebe);
            Global.liebeProgressBarList.Add(this.Tier2Liebe);
            Global.liebeProgressBarList.Add(this.Tier3Liebe);
            Global.liebeProgressBarList.Add(this.Tier4Liebe);

        }
        private void gehegeSelect1(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex = 0;
        }

        private void gehegeSelect2(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex = 1;
        }

        private void gehegeSelect3(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex = 2;
        }

        private void gehegeSelect4(object sender, MouseButtonEventArgs e)
        {
            gehegeIndex = 3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }

<<<<<<< Updated upstream
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
=======
        private void fuettern_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < Global.TierList.Count; i++)
            {
                if (Global.TierList[i].position == gehegeIndex)
                {
                    Global.TierList[i].tier.futterValue += 40;

                    if (Global.TierList[i].tier.futterValue > 100)
                    {
                        Global.TierList[i].tier.futterValue = 100;
                    }
                    Global.futterProgressBarList[gehegeIndex].Value = Global.TierList[i].tier.futterValue;

                }

            }

>>>>>>> Stashed changes
        }

        private void Pflegen_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
            Global.tierList[gehegeIndex].pflegeValue += 40;
            if (Global.tierList[gehegeIndex].pflegeValue > 100)
            {
                Global.tierList[gehegeIndex].pflegeValue = 100;
            }
            Global.pflegeProgressBarList[gehegeIndex].Value = Global.tierList[gehegeIndex].pflegeValue;
=======

>>>>>>> Stashed changes
        }

        private void Streicheln_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
            Global.tierList[gehegeIndex].liebeValue += 40;
            if (Global.tierList[gehegeIndex].liebeValue > 100)
            {
                Global.tierList[gehegeIndex].liebeValue = 100;
            }
            Global.liebeProgressBarList[gehegeIndex].Value = Global.tierList[gehegeIndex].liebeValue;
=======

>>>>>>> Stashed changes
        }


    }
}
