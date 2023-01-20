using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimsUp.Klassen
{
    class Tiger: Tier
    {
        public override void setArt(string art)
        {
            art = "Tiger";
        }
<<<<<<< Updated upstream
    }
    class Giraffe : Tier 
    {
        public override void setArt(string art)
        {
            art = "Giraffe";
        }
    }
    class Quokka : Tier
    {
        public override void setArt(string art)
        {
            art = "Quokka";
        }
    }
    class Opossom : Tier 
    {
        public override void setArt(string art)
        {
            art = "Opossom";
        }
    
=======
        public override void fKosten()
        {
            futterKosten = 50;
        }
    }
    class Giraffe : Tier 
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpeg", UriKind.Relative)));
        public override void setArt() 
        {
            tierbild = imageTier;
            art = "Giraffe";
        }
        public override void fKosten()
        {
            futterKosten = 50;
        }
    }
    class Quokka : Tier
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));
        public override void setArt() 
        {
            tierbild = imageTier;
            art = "Quokka";
        }
        public override void fKosten()
        {
            futterKosten = 50;
        }
    }
    class Opossom : Tier 
    {
        private BitmapImage imageTier = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
        public override void setArt() 
        {
            tierbild = imageTier;
            art = "Opossom";
        }
        public override void fKosten()
        {
            futterKosten = 50;
        }
>>>>>>> Stashed changes
    }
}
