using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    class House
    {

        private readonly int id;
        private int flatNumber;
        private int square;
        private int floor;
        private static int rooms;
        private string street;
        private const string type = "Block";
        private int age;

        public int Number
        {
            get { return flatNumber; }
            set { if (flatNumber > 0 && flatNumber < 9999) { flatNumber = value; } }
        }
        public int Square
        {
            get { return square; }
            set
            {
                if (value < 0)
                {
                    square = 0;
                }
                else if (value > 100)
                {
                    square = 100;
                }
                else
                {
                    square = value;
                }
            }
        }
        
        public int Floor
        {
            get { return floor; }
            set { if (floor > 0 && floor < 25) { floor = value; } }
        }
        public int Rooms
        {
            get { return rooms; }
            set { if (rooms > 0 && rooms < 6) { rooms = value; } }
        }
        //public int Id
        //{
        //    get { return id; }
        //    set { if (id > 0 && id < 4) { id = value; } }
        //}
        //конструкторы

        public House()
        {
            id = 4;
            flatNumber = 25;
            square = 55;
            floor = 3;
            
            street = "Lenina";
            age = 15;
        }
        public House(int idx, int flatNumberr)
        {
            id = idx;
            flatNumber = flatNumberr;
            square = 44;
            floor = 6;

            street = "Lenina";
            age = 15;
        }
        public House(int idx, int flatNumberr, int squaree, int floorr, int roomss, string streett)
        {
            id = GetHashCode();
            flatNumber = flatNumberr;
            square = squaree;
            floor = floorr;

            street = streett;
        }


        private House(int i, int f, string str)
        {
            id = i;
            flatNumber = f;
            street = str;
        }

        static House()
        {
            rooms = 3;
            Console.WriteLine("Rooms are static.");
            House One = new House(5, 55, "Mira");
            Console.WriteLine("{0},{1},{2}",One.id,One.flatNumber,One.street);
        }


        public override bool Equals(object obj)
        {
            if (obj is House && obj !=null)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {id.ToString()}; Flat №{flatNumber.ToString()}; Square: {square.ToString()} m^2; Floor: {floor.ToString()}; Rooms: {rooms.ToString()}; Street: {street}; Type:{type}.";
        }

        public static string GetByRooms()
        {
            string _var = "";
            int standart = 3;
            if (rooms==standart) 
            {
                //_var = $"ID: {id.ToString()}";
                _var = "*";
            }
            return _var;
        }

        public string GetByRoomsAndFloors() 
        {
            string _var = "";
            int standart = 3;
            if (rooms==standart && floor > 3 && floor < 10) 
            {
                _var = $"Street: {street}";
            }
            return _var;
        }


        public string GetByAge()
        {
            string _var = "";
            if (age > 10 && age < 20)
            {
                _var = $"Age: {age.ToString()}";
            }
            return _var;
        }
    }
}
