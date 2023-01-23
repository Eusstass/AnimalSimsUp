using System;
using System.Collections.Generic;
using System.IO;
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
using AnimalSimsUp.Klassen;
using AnimalSimsUp.windowsAnimal;


namespace AnimalSimsUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
   
    public partial class MainWindow : Window
    {
        //Init der einzelnen Views
        public static windowsAnimal.mainWindowsControll mainWindow = new mainWindowsControll();
        public static windowsAnimal.shop2 shop2Window = new windowsAnimal.shop2();
        public static Shop1 shop1Window = new Shop1();
        public static windowsAnimal.shop3 shop3Window = new shop3();
        public static MainWindow AppWindow;
        public static windowsAnimal.gameOverScreen gameOverScreen = new windowsAnimal.gameOverScreen();
        public static windowsAnimal.nachWindow nachtWindow = new windowsAnimal.nachWindow();
        public MainWindow()
        {

            InitializeComponent();
            this.contentControlAnimal.Content = mainWindow;
            AppWindow = this;
            

            //Init der Geheg List 
            Gehege gehege1 = new Gehege(0);
            Gehege gehege2 = new Gehege(1);
            Gehege gehege3 = new Gehege(2);
            Gehege gehege4 = new Gehege(3);

            //Init der Main Window Image List
            Global.mainWindowImages.Add(mainWindow.Tier1Image);
            Global.mainWindowImages.Add(mainWindow.Tier2Image);
            Global.mainWindowImages.Add(mainWindow.Tier3Image);
            Global.mainWindowImages.Add(mainWindow.Tier4Image);

            Global.shop1Images.Add(shop1Window.Gehege1Image);
            Global.shop1Images.Add(shop1Window.Gehege2Image);
            Global.shop1Images.Add(shop1Window.Gehege3Image);
            Global.shop1Images.Add(shop1Window.GehegeImage);


            //Image Controll 
            shop2Window.Gehege1Image.Stretch = Stretch.Fill;
            shop2Window.Gehege2Image.Stretch = Stretch.Fill;
            shop2Window.Gehege3Image.Stretch = Stretch.Fill;
            shop2Window.GehegeImage.Stretch = Stretch.Fill;
            shop2Window.Gehege1Image.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
            shop2Window.Gehege2Image.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));
            shop2Window.Gehege3Image.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpeg", UriKind.Relative)));
            shop2Window.GehegeImage.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/tiger.jpg", UriKind.Relative)));
            shop3Window.autoFeederImage.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/autoFeeder.png", UriKind.Relative)));
            shop3Window.autoRehinigungImage.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/reihigunsRoboter.jfif", UriKind.Relative)));

            //ProgressBar Init
            Global.progressBarsFutter.Add(mainWindow.Tier1Nahrung);
            Global.progressBarsLiebe.Add(mainWindow.Tier1Liebe);
            Global.progressBarsPflege.Add(mainWindow.Tier1Pflege);
            Global.progressBarsFutter.Add(null);
            Global.progressBarsLiebe.Add(null);
            Global.progressBarsPflege.Add(null);
            Global.progressBarsFutter.Add(null);
            Global.progressBarsLiebe.Add(null);
            Global.progressBarsPflege.Add(null);
            Global.progressBarsFutter.Add(null);
            Global.progressBarsLiebe.Add(null);
            Global.progressBarsPflege.Add(null);

            for (int i = 0; i < Global.mainWindowImages.Count(); i++)
            {               
                Global.mainWindowImages[i].Stretch = Stretch.Fill;
                Global.shop1Images[i].Stretch = Stretch.Fill;  
            }

            //Geld und Zeit werden gezetzt
            mainWindow.UhrAnzeigen.Content = Convert.ToString(Global.Zeit).Replace(",",":") + " Uhr";
            mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";

            //Das erste Tier wird Initialisiert
            Global.TierList.Add(new GehegeSafe(0, new Opossom()));
            Global.GehegeList[0].tierGehege = Global.TierList[0].tier;
            Global.mainWindowImages[0].Source = Global.GehegeList[0].tierGehege.tierbild;
            Global.shop1Images[0].Source = Global.GehegeList[0].tierGehege.tierbild;

        }


    }
}
