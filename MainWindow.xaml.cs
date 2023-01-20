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
        public static MainWindow AppWindow;
        public MainWindow()
        {
            InitializeComponent();
            this.contentControlAnimal.Content = mainWindow;
            AppWindow = this;

            //Image Controll 
            shop2Window.Gehege1Image.Stretch = Stretch.Fill;
            shop2Window.Gehege2Image.Stretch = Stretch.Fill;
            shop2Window.Gehege3Image.Stretch = Stretch.Fill;
            shop2Window.GehegeImage.Stretch = Stretch.Fill;
            shop2Window.Gehege1Image.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
            shop2Window.Gehege2Image.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));
            shop2Window.Gehege3Image.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpeg", UriKind.Relative)));
            shop2Window.GehegeImage.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/tiger.jpg", UriKind.Relative)));
        }


    }
}
