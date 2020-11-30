using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/////////////////////////////////////// 10 LABA/////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////// COLLECTIONS //////////////////////////////////////////////");

            Console.WriteLine("/////////////////////////////////////// TASK1 ////////////////////////////////////////////"); 

            Softwares<Software> mySoftwareCollection = new Softwares<Software>(
                new Software("Security","Kaspersky",2400,false), 
                new Software("Study","Visual Studio",4000,false),
                new Software("Security","Windows Security",1000,true),
                new Software("Game","Unity3D",4500,false),
                new Software("Work","Kompas3D",2200,false));
            mySoftwareCollection[2].TurnOff();
            mySoftwareCollection[1].TurnOn();
            //mySoftwareCollection[3].TurnOff();
            mySoftwareCollection[4].PlusSize(8000);
            Console.WriteLine("---------------- ADD -------------------------");
            mySoftwareCollection.Add(new Software("Work","Microsoft Word",1000,true));
            foreach (var i in mySoftwareCollection) 
            {
                Console.WriteLine($"Purpose: {i.Purpose}\nName: {i.Name}\nSize: {i.Size}\nStatus: {i.Status}\n");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------- after first REMOVE ------------------------------");
            mySoftwareCollection.Remove(mySoftwareCollection[5]);
            foreach (var i in mySoftwareCollection)
            {
                Console.WriteLine($"Purpose: {i.Purpose}\nName: {i.Name}\nSize: {i.Size}\nStatus: {i.Status}\n");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------- after second REMOVE ------------------------------");
            mySoftwareCollection.Remove(mySoftwareCollection[3]);
            foreach (var i in mySoftwareCollection)
            {
                Console.WriteLine($"Purpose: {i.Purpose}\nName: {i.Name}\nSize: {i.Size}\nStatus: {i.Status}\n");
            }
            Console.WriteLine();


            /*mySoftwareCollection[0].Size = 50000;
            int result = mySoftwareCollection[0].Size;
            Console.WriteLine($"result = {result}");*/

            Console.WriteLine("------------------------- IndexOf -----------------------------------");
            int index = mySoftwareCollection.IndexOf(mySoftwareCollection[2]);
            Console.WriteLine($"Index of VS in collection = {index}");
            Console.WriteLine();

            Console.WriteLine("/////////////////////////////////////// TASK2 ////////////////////////////////////////////");
            SortedList<string, int> NBAPlayers = new SortedList<string, int> { { "Jayson Tatum", 1998 },
                { "Jaylen Brown", 1996}, {"Marcus Smart", 1994 },{"Kemba Walker", 1990 },{ "Robert Williams", 1997} };

            //a
            foreach (var i in NBAPlayers) Console.WriteLine($"Name of player: {i.Key}  Year of birth: {i.Value}");
            Console.WriteLine();
            //b
            RemoveNCountInSortedList(ref NBAPlayers);
            foreach (var i in NBAPlayers) Console.WriteLine($"Name of player: {i.Key}  Year of birth: {i.Value}");
            Console.WriteLine();
            //c
            NBAPlayers.Add("Efim Kopyl", 2002);
            NBAPlayers.Add("Roma Bagry", 2001);
            //d
            List<int> yearForGreat = new List<int>();
            foreach (var i in NBAPlayers) yearForGreat.Add(i.Value);
            //e
            foreach (var i in yearForGreat) Console.Write(i + " ");
            Console.WriteLine();
            //f
            if (yearForGreat.Find(i => i == 2002) != default(int)) Console.WriteLine("SortedList has player with 2002 year.");
            Console.WriteLine();

            Console.WriteLine("/////////////////////////////////////// TASK3 ////////////////////////////////////////////");

            ObservableCollection<Software> softwareShow = new ObservableCollection<Software> { mySoftwareCollection[0], mySoftwareCollection[1], mySoftwareCollection[2] };

            softwareShow.CollectionChanged += CollectionChange;
            softwareShow.CollectionChanged += CollectionChange;

            softwareShow.Add(mySoftwareCollection[3]);
            softwareShow.Remove(new Software("Security", "Kaspersky", 2400, false));
            Console.ReadLine();
        }
        public static void RemoveNCountInSortedList(ref SortedList<string, int> dc)
        {
            List<string> str = new List<string>();
            foreach (var it in dc)
            {
                str.Add(it.Key);
            }
            Console.WriteLine("Enter number of elements for remove:");
            int count = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            foreach (var i in str)
            {
                if (n < count) dc.Remove(i);
                n++;
            }
        }

        public static void CollectionChange(object obj, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
            Console.WriteLine("Action for this event: {0}", e.Action);
             
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:"); 
                foreach (var p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine();
            
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                 
                Console.WriteLine("Here are the NEW items:"); 
                foreach (var p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}
