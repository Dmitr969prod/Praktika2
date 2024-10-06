using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Device
    {
        string brand;
        string model;

        public Device( string brand="", string model = "")
        {
            this.brand = brand;
            this.model = model;
        }

        public string Brand 
        { 
            set { this.brand = value; }
            get { return this.brand; }
        }

        public string Model
        {
            set { this.model = value; }
            get { return this.model; }
        }

        public virtual void print()
        {
            Console.WriteLine($"Brand: {brand}\nModel:{model}");
        }
    }

    public class PersonalComputer : Device
    {
        int RAM;
        int storage;
        
        public PersonalComputer(string brand, string model, int RAM, int storage):base(brand, model)
        {
            this.RAM = RAM;
            this.storage = storage;
        }

        public int Ram
        {
            set { RAM = value; }
            get { return RAM; }
        }

        public int Storage
        {
            set { storage = value; }
            get { return storage; }

        }

        public override void print()
        {
            base.print();
            Console.WriteLine($"RAM: {RAM}\nstorage: {storage}");
        }
    }
}
