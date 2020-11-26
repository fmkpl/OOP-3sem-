using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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



    public class Boss
    {
        private string name;
        private int status;
        private int power;


        //delegates
        public delegate void Obnovlenie(int value);
        public delegate void TurnOn(int stat);

        //events
        public event Obnovlenie Upgrade;
        public event TurnOn Trnon;

        //status 1 = turned on, status 2 = turned off
        public Boss(string str, int st, int pow)
        {
            name = str;
            status = st;
            power = pow;
        }

        public void UpgradeBoss(int newpower) 
        {
            power = newpower;
        }
        public void TurnOnBoss(int newstatus) 
        {
            status = newstatus;
        }
        public void OnOffMode(int searchPower, int newStatus) 
        {
            if (power > searchPower) 
            {
                Upgrade?.Invoke(searchPower + 100);
                Trnon?.Invoke(newStatus);
            }
        }

    }
    class Program
    {


        // advanced functions
        public static void WriteUpgrade(int upgrade)
        {
            Console.WriteLine($"Boss was upgraded to {upgrade}.");
        }

        public static void WriteTurnOn(int value)
        {
            Console.WriteLine($"Boss is {value}.");
        }

        public static string DeletePunctuation(string str)
        {
            for (int i = 0; i < str.Length; ++i)
                if (str[i] == '.' || str[i] == ',' || str[i] == '!' || str[i] == '?' || str[i] == ';' || str[i] == ':') str = str.Remove(i, 1);
            Console.WriteLine(str);
            return str;
        }

        public static string Symbol(string str)
        {
            Console.WriteLine("Please, enter any one symbol.");
            char symbol = (char)Console.Read();
            str += symbol;
            Console.WriteLine(str);
            return str;
        }

        public static string ToUpper(string str)
        {
            str = str.ToUpper();
            Console.WriteLine(str);
            return str;
        }

        public static string SpaceDelete(string str)
        {
            for (int i = 0; i < str.Length; ++i)
                if (str[i] == ' ') str = str.Remove(i, 1);
            Console.WriteLine(str);
            return str;
        }

        public static string ToLowwer(string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
            return str;
        }

        static void Main(string[] args)
        {
            //9 LABA
            Console.WriteLine("9 LABA");
            Console.WriteLine("////////////////////////////// DELEGATES ///////////////////// EVENTS ///////////////////////////// LAMBDA ///////////////////////////////////////////////");

            Boss boss1 = new Boss("Pudge", 1, 400);
            Boss boss2 = new Boss("Ricky", 1, 300);
            Boss boss3 = new Boss("Sven", 1, 500);
            Boss boss4 = new Boss("Dazzle", 1, 200);

            boss1.Trnon += new Boss.TurnOn(boss1.TurnOnBoss);
            boss1.Trnon += new Boss.TurnOn(WriteTurnOn);

            boss2.Upgrade += new Boss.Obnovlenie(boss2.UpgradeBoss);
            boss2.Upgrade += new Boss.Obnovlenie(WriteUpgrade);

            Boss.Obnovlenie obn = new Boss.Obnovlenie(boss3.UpgradeBoss);
            obn += (int integer) => { Console.WriteLine($"Boss power upgraded to {integer}"); };

            boss3.Upgrade += obn;
            boss3.Trnon += new Boss.TurnOn(boss3.TurnOnBoss);


            boss4.Upgrade += new Boss.Obnovlenie(boss4.UpgradeBoss);
            boss4.Trnon += delegate (int value)
            {
                boss4.TurnOnBoss(value);
                WriteTurnOn(value);
            };

            boss1.OnOffMode(300,0);
            boss2.OnOffMode(400,0);
            boss3.OnOffMode(600,1);
            boss4.OnOffMode(100,0);

            string text = "My Name Is Efim and I Study Programming in BSTU.";
            Func<string, string> fc = new Func<string, string>(DeletePunctuation);
            fc += Symbol;
            fc += ToUpper;
            fc += SpaceDelete;
            fc += ToLowwer;

            fc(text);

            Console.ReadKey();
        }

        
    }
}
