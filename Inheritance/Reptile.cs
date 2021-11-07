using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : myAnimal
    {


        public Reptile()
        {
            Eyes = 2;
            Head = 1;
            LegCount = 2;
            LandSeaAir = "Land";
        }
        public bool IsScaly { get; set; }
        public int NoOfLegs { get; set; }
        public bool IsOvaparious { get; set; }
        public bool IsColdBlooded { get; set; }

        }
    }

