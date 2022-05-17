using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123_LESSON2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Minion.RunTest();
            Console.ReadLine();
        }
    }

    #region Minion enum
    enum MinionHeight
    {
        Short,
        Average,
        Tall
    }
    #endregion

    #region Minion Class
    class Minion
    { 
        public int Mischievousness { get;}
        public string Name { get; }
        public MinionHeight Height { get; }


        public Minion(
            string name,
            MinionHeight height,
            int mischieviousness)
        { 
            Name = name;
            Height = height;
            Mischievousness = mischieviousness;
        }

        public override string ToString()
        {
            return $"{Name} is {Height} and mischievous level: {Mischievousness}";
        }

        public static void RunTest()
        {
            Minion minion1 = new Minion("Kelvin", MinionHeight.Average, 4);
            Console.WriteLine(minion1);
            Console.WriteLine();
            Minion minion2 = new Minion("Evelyn", MinionHeight.Short, 100);
            Console.WriteLine(minion2);


            //list
            List<Minion> minions = new List<Minion>();                  //empty list
            Minion minion3 = new Minion("Norbert", MinionHeight.Tall, 7); //new object
            minions.Add(minion3);                                       // add minion3 to list
            minions.Add(new Minion("Melvin", MinionHeight.Average, 5));// anonymous object (did not name it)

            //creating another list
            List<Minion> original = new List<Minion>() { minion1,minion2}; // create a list with 2 objects
            minions.AddRange(original);                                    //add a collection of object
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            //display all the minions
            Console.WriteLine(String.Join("\n",minions));

            //see all the tall minions
            Console.WriteLine("All the tall minions: ");
            foreach (Minion minion in minions)
            {
                if (minion.Height == MinionHeight.Tall)
                {
                    Console.WriteLine(minion);
                }
            }
        }

    }
    #endregion
}

