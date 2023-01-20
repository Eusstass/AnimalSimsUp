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

namespace AnimalSimsUp.Klassen
{
    class Tiger: Tier
    {
        private BitmapImage imageTier =  new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/tiger.jpg", UriKind.Relative)));
        public override void setArt()
        {
            tierbild = imageTier;
            art = "Tiger";
        }
        public void fKosten() { }
    }
    class Giraffe : Tier 
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpeg", UriKind.Relative)));
        public void setArt() 
        {
            tierbild = imageTier;
            art = "Giraffe";
        }
        public void fKosten() { }
    }
    class Quokka : Tier
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));
        public void setArt() 
        {
            tierbild = imageTier;
            art = "Quokka";
        }
        public void fKosten() { }
    }
    class Opossom : Tier 
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
        public void setArt() 
        {
            tierbild = imageTier;
            art = "Opossom";
        }
        public void fKosten() { }
    }
}
