using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong2
{
    public class App
    {
        Animals animals = new Animals("Dog","Giraffe", "Penguin","Parrot","Gorilla");
    
        public void Run()
        {
            Console.WriteLine("Which Animal Would You Like?");
            Console.WriteLine($"1.{animals._Dog}");
            Console.WriteLine($"2.{animals._Giraffe}");
            Console.WriteLine($"3.{animals._Penguin}");
            Console.WriteLine($"4.{animals._Parrot}");
            Console.WriteLine($"5.{animals._Gorilla}");
            

        }

        

    }

    
}
