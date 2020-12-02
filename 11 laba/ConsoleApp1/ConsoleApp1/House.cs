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
    partial class House
    {
        private int id;
        private int flatNumber;
        private int square;
        private int floor;
        private int rooms;
        private string street;
        private const string type = "Block";
        private int age; //years
        public House() 
        {
            id = 1;
            flatNumber = 11;
            square = 44;
            floor = 1;
            rooms = 2;
            street = "Lenina";
            age = 5;
        }
        public House(int _id, int _flatNumber, int _square, int _floor, int _rooms, string _street, int _age) 
        {
            id = _id;
            flatNumber = _flatNumber;
            square = _square;
            floor = _floor;
            rooms = _rooms;
            street = _street;
            age = _age;
        }
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
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
        public string Street 
        {
            get { return street; }
            set { street = value; }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {id.ToString()};\nFlat №{flatNumber.ToString()};\nSquare: {square.ToString()} m^2;\nFloor: {floor.ToString()};\nRooms: {rooms.ToString()};\nStreet: {street};\nType: {type}.\nAge: {age}.\n";
        }
        

       
    }
    
}
