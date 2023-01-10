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
        List<Rectangle> rectangleList = new List<Rectangle>();
        int anzahl = 4;
        public mainWindowsControll()
        {
            InitializeComponent();
            rectangleList.Add(TierBild1Rect);
            rectangleList.Add(TierBild2Rect);
            rectangleList.Add(TierBild3Rect);
            rectangleList.Add(TierBild4Rect);
        }

        /// <summary>
        /// Erstellt ein neues Tier Gehege falls nötig
        /// </summary>
        public void createNewAnimalShelter()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 300;
            rectangle.Height = 300;
            rectangle.Name = $"TierBild{anzahl}Rect";
            //rectangle.Margin = new Thickness(rectangleList[anzahl - 4].Margin.Left, rectangleList[anzahl - 4].Margin.Top + 500, 0, 0);
            rectangle.Margin = new Thickness(800, 800, 0, 0);
            rectangleList.Add(rectangle);
            gridMain.Children.Add(rectangle);
            anzahl++;
        }

        private void neuesTier_Click(object sender, RoutedEventArgs e)
        {
            createNewAnimalShelter();
        }
    }
}
