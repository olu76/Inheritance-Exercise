using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class myBird : myAnimal
    {
        public myBird()
        {
            Eyes = 2;
            Head = 1;
            LegCount = 2;
            LandSeaAir = "Air";
        }

        public string Color { get; set; }
        public bool HasFeathers { get; set; }
        public int NoOfWings { get; set; }
        public bool DoesLayEggs { get; set; }
        }

    }

