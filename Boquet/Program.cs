using System;
using System.Linq;

namespace Boquet
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoquet = BoquetFlower.GetList();

            firstBoquet.OrderBy(boquet => boquet.BoquetName).ThenBy(boquet => boquet.Flower);

            BoquetFlower.Print(firstBoquet);

            Console.WriteLine();

            var secondBoquet = BoquetFlower.GetList();

            secondBoquet.GroupBy(boquet => boquet.BoquetName)
                .OrderBy(boquet => boquet.Key)
                .SelectMany(boquet => boquet.OrderBy(boquetFlower => boquetFlower.Flower));

            BoquetFlower.Print(secondBoquet);
        }
    }
}
