using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
     class Access_Modifiers
    {
        private int x = 10;
        public int y = 20;
        protected int z = 30;

        public static  void Methodss()
        {
            Access_Modifiers access= new Access_Modifiers(); // to access the private field
            Console.WriteLine(access.x);
            Console.WriteLine(access.z);
        }
    } 
}
