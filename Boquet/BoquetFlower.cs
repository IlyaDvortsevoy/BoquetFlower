using System;
using System.Collections.Generic;

namespace Boquet
{
    public class BoquetFlower
    {
        public string BoquetName { get; set; }
        public string Flower { get; set; }

        //TODO: sort BuquetsFlower list firts by boquet name and then by flower name.
        //TODO: do this task with and without LINQ grouping 
        public static BoquetFlower[] GetList()
        {
            #region buquets init
            var boquets = new List<BoquetFlower>
            {
                new BoquetFlower
                {
                    BoquetName = "Boquet 1",
                    Flower = "sunflower"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 2",
                    Flower = "tulip"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 3",
                    Flower = "gladiolis"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 4",
                    Flower = "larkspur"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 1",
                    Flower = "daisy"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 2",
                    Flower = "rose"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 3",
                    Flower = "lily"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 4",
                    Flower = "lilac"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 1",
                    Flower = "daffodil"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 2",
                    Flower = "orchid"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 3",
                    Flower = "snapdragon"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 4",
                    Flower = "iris"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 1",
                    Flower = "larkspur"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 3",
                    Flower = "aster"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 4",
                    Flower = "dahlia"
                },
                new BoquetFlower
                {
                    BoquetName = "Boquet 3",
                    Flower = "protea"
                }
            };
            #endregion

            return boquets.ToArray();
        }

        public static void Print(IEnumerable<BoquetFlower> flowers)
        {
            foreach (var boquetFlower in flowers)
            {
                Console.WriteLine($"{boquetFlower.BoquetName} : {boquetFlower.Flower}");
            }
        }
    }
}