using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var Animal = new myAnimal();
            var Parrot = new myBird();

            var Lizard = new Reptile();
            {

                Parrot.Color = "Black";
                Parrot.HasFeathers = true;
                Parrot.NoOfWings = 2;
                Parrot.DoesLayEggs = true;



                Lizard.IsScaly = true;
                Lizard.NoOfLegs = 2;
                Lizard.IsOvaparious = true;
                Lizard.IsColdBlooded = true;
            }

            var myAnimal = new myAnimal[] { Parrot, Lizard };

            foreach(var animal in myAnimal)
            {
                Console.WriteLine($"Eyes:{animal.Eyes} ");
                Console.WriteLine($"Head : {animal.Head} ");
                Console.WriteLine($"It has {animal.LegCount} Legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
            }





            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
