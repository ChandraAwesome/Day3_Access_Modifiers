using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_with_oops
{
    public class Constructer
    {
      private  string car;  //Encapsulation

        public string Car
        {
            get { return car; }
            set { car = value; }
        }


        public Constructer(string model) // Parameterized Constructer
        {
            car = model;
        }

        public class Animals : Inheritance_Animals
        {
            public string Breed = "white tiger";
        }
      
    }

    public class Kaksha
    {
        //int x = 10;
        //int y;
        //private int z = 100;

        //public Kaksha(Kaksha value) // Copy Constructor
        //{
        //    int a = x;
        //    y = 20;
        //    z = value.z;
        //}

        //public Kaksha(int x, int y, int z) //Instance Constrcter
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.z = z;
        //}

        static Kaksha()
        {
             Console.WriteLine("Static Constructor"); 
        }

        public void normalmethod() 
        {
            Console.WriteLine("Normal Method");
        }

        private Kaksha() 
        {
        }
        public static int x;
        public static void PrivateMethod()
        {
            Console.WriteLine(x);
        }
    }
}
