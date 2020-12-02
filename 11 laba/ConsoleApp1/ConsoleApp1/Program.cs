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
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Player 
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team 
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////////////////////////////// TRAINING ///////////////////////////////////////////");
            //training
            string[] teams = { "Барселона", "Ливерпуль", "Бавария", "ПСЖ", "ЦСКА", "Ювентус", "БАТЭ" };
            var selectedTeams = teams.Where(t=>t.ToUpper().StartsWith("Б")).OrderBy(t=>t);
            Console.WriteLine("Elements starts with 'Б': ");
            foreach (string s in selectedTeams)
            {
                Console.WriteLine(s);
            }
            int number = (from t in teams where t.ToUpper().StartsWith("Б") select t).Count();
            Console.WriteLine($"Number of elements starts with 'Б' = {number}");
            Console.WriteLine("//////////////////////////////////////////////////");
            int[] array = { 1, 8, 4, 5, 7, 8, 124, 44, 29, 8, 8 };
            var maxElem = (from t in array select t).Max();
            var minElem = (from t in array select t).Min();
            Console.WriteLine($"maxElem = {maxElem}");
            Console.WriteLine($"minElem = {minElem}");
            Console.WriteLine("//////////////////////////////////////////////////");
            var count = (from t in array where t.Equals(8) select t).Count();
            Console.WriteLine($"Element equals 8 = {count}");
            Console.Write("Press ENTER to continue..."); Console.ReadLine();
            Console.WriteLine("////////////////////////////////////// TASK1 /////////////////////////////////////////");
            //task1
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] WinterAndSummerMonths = { "December", "January", "February", "June", "July", "August" };
            int n;
            Console.Write("Input length: ");
            n = Convert.ToInt32(Console.ReadLine());
            var selectedMonths = from m in months where m.Length == n orderby m select m;
            foreach (string s in selectedMonths) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var alphabetMonths = from m in months orderby m select m;
            foreach(string s in alphabetMonths) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var selected2Months = from m in months where m.Contains("u") && m.Length >= 4 select m;
            foreach (string s in selected2Months) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var selected3Months = from m in months where Array.IndexOf(WinterAndSummerMonths, m) != -1 select m;
            foreach (string s in selected3Months) 
            {
                Console.WriteLine(s);
            }
            Console.Write("Press ENTER to continue..."); Console.ReadLine();
            Console.WriteLine("////////////////////////////////////// TASK2-3 /////////////////////////////////////////");
            //task2-3
            /*House house = new House(223, 65, 55, 3, 3, "1st May", 10);
            Console.WriteLine(house.ToString());*/
            List<House> houses = new List<House>
            {
                new House(223, 65, 55, 3, 3, "1st May", 10),
                new House(224, 67, 55, 7, 3, "October street", 8),
                new House(225, 69, 55, 8, 3, "Pushkina", 3),
                new House(226, 60, 45, 1, 2, "1st May", 10),
                new House(227, 45, 55, 2, 2, "Sovetskaya", 11),
                new House(128, 52, 65, 3, 3, "1st May", 10),
                new House(229, 88, 45, 5, 1, "Sovetskaya", 11),
                new House(230, 71, 45, 4, 2, "9th May", 5),
                new House(331, 51, 65, 3, 3, "1st May", 10),
                new House(232, 99, 65, 3, 2, "9th May", 5),
                new House(233, 5, 65, 2, 3, "1st May", 10),
                new House(234, 11, 50, 9, 3, "Efima Kopyla", 2)
            };
            //список квартир, имеющих заданное число комнат
            Console.WriteLine("список квартир, имеющих заданное число комнат");
            int x;
            Console.Write("Input number of rooms: ");
            x = Convert.ToInt32(Console.ReadLine());
            var selectedByRooms = from h in houses where h.Rooms == x select h;
            foreach (var s in selectedByRooms) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------------------------------------------------");
            //пять первых квартир на заданной улице заданного дома
            Console.WriteLine("пять первых квартир на заданной улице заданного дома");
            string streetX;
            Console.Write("Input name of the street (variants: 1st May, October street, Pushkina, Sovetskaya, 9th May *!BE CAREFUL!*): ");
            streetX = Console.ReadLine();
            var selectedByStreet = (from h in houses where h.Street == streetX select h).Take(4);
            //var selectedByStreet = from h in houses where h.Street == streetX select h;
            foreach (var s in selectedByStreet) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------------------------------------------------");
            //количество квартир на определенной улице
            Console.WriteLine("количество квартир на определенной улице");
            string streetY;
            Console.Write("Input name of the street (variants: 1st May, October street, Pushkina, Sovetskaya, 9th May *!BE CAREFUL!*): ");
            streetY = Console.ReadLine();
            var roomsSelectedByStreet = (from h in houses where h.Street==streetY select h.Rooms).Sum();
            Console.WriteLine($"Number of rooms selected by {streetY} = {roomsSelectedByStreet}");
            Console.WriteLine("---------------------------------------------------------------------");
            //список квартир, имеющих заданное число комнат и расположенных на этаже, который находится в заданном промежутке
            Console.WriteLine("список квартир, имеющих заданное число комнат и расположенных на этаже, который находится в заданном промежутке");
            Console.Write("Input number of rooms: ");
            int roomsN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input floorBegin: ");
            int floorBegin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input floorEnd: ");
            int floorEnd = Convert.ToInt32(Console.ReadLine());
            var selectedByRoomsAndFloors = from h in houses where h.Floor >= floorBegin && h.Floor <= floorEnd && h.Rooms == roomsN select h;
            foreach (var s in selectedByRoomsAndFloors) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Press ENTER to continue..."); Console.ReadLine();
            Console.WriteLine("////////////////////////////////////// TASK4 /////////////////////////////////////////");
            //task4
            Console.WriteLine("список из первых 5 домов с трехкомнатными квартирами (упорядоченный)");
            var selectedByMyRequest2 = (from h in houses where h.Rooms == 3 orderby h.Id select h).Take(5);
            foreach (var s in selectedByMyRequest2) 
            {
                Console.WriteLine(s);
            }
            var selectedByMyRequest = (from h in houses where h.Rooms == 3 select h).Count();
            Console.WriteLine($"кол-во домов с трехкомнатными квартирами = {selectedByMyRequest}");
            Console.Write("Press ENTER to continue..."); Console.ReadLine();
            Console.WriteLine("////////////////////////////////////// TASK5 /////////////////////////////////////////");
            //task5
            List<Team> teams1 = new List<Team>()
            {
                new Team { Name = "Boston Celtics", Country = "USA" },
                new Team { Name = "CSKA", Country = "Russia"}
            };
            List<Player> players = new List<Player>()
            {
                new Player { Name = "Tatum", Team = "Boston Celtics" },
                new Player { Name = "Brown", Team = "Boston Celtics" },
                new Player { Name = "Kopyl", Team = "CSKA" }
            };
            var result = from pl in players join t in teams1 on pl.Team equals t.Name select new { Name = pl.Name, Team = pl.Team, Country = t.Country };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
            }
            /*var result = players.Join(teams, 
            p => p.Team, 
            t => t.Name, 
            (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country });*/
            Console.Write("Press ENTER to continue..."); Console.ReadLine();
        }
    }
}
