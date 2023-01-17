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
using AnimalSimsUp.windowsAnimal;


namespace AnimalSimsUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
   
    public partial class MainWindow : Window
    {
        public static windowsAnimal.mainWindowsControll mainWindow = new mainWindowsControll();
        public static windowsAnimal.shop2 shop2Window = new windowsAnimal.shop2();
        public static Shop1 shop1Window = new Shop1();
        public static MainWindow AppWindow;
        public MainWindow()
        {
            InitializeComponent();
            this.contentControlAnimal.Content = mainWindow;
            AppWindow = this;
        }


    }
}
