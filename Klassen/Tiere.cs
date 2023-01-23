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
        private int _kosten = 300;
        private int _futterKosten = 70;
        private int _gewinn = 300;
        public Tiger() 
        {
            setArt();
            fKosten();
        }

        public override void setArt()
        {
            tierbild = imageTier;
            art = "Tiger";
            kosten=_kosten;
            gewinn = _gewinn;
        }
        public void fKosten() 
        {
            futterKosten = _futterKosten;
        }
    }
    class Giraffe : Tier 
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpeg", UriKind.Relative)));
        private int _kosten = 400;
        private int _futterKosten = 50;
        private int _gewinn = 250;
        public Giraffe() 
        {
            setArt();
            fKosten();
        }
        
        public override void setArt() 
        {
            tierbild = imageTier;
            art = "Giraffe";
            kosten = _kosten;
            gewinn = _gewinn;
        }
        public override void fKosten() 
        {
            futterKosten = _futterKosten;
        }
    }
    class Quokka : Tier
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));
        private int _kosten = 200;
        private int _futterKosten = 30;
        private int _gewinn = 200;
        public Quokka() 
        {
            setArt();
            fKosten();
            gewinn= _gewinn;
        }

        public override void setArt() 
        {
            tierbild = imageTier;
            art = "Quokka";
            kosten = _kosten;
        }
        public override void fKosten() 
        {
            futterKosten = _futterKosten;
        }
    }
    class Opossom : Tier 
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
        private int _kosten = 100;
        private int _futterKosten = 20;
        private int _gewinn = 150;
        public Opossom()
        {
            setArt();
            fKosten();
        }
        
        public override void setArt() 
        {
            tierbild = imageTier;
            art = "Opossom";
            kosten = _kosten;
            gewinn= _gewinn;
        }
        public override void fKosten() 
        {
            futterKosten = _futterKosten;
        }
    }
}
