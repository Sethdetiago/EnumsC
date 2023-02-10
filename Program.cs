using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsC
{
    //Enums should be at the namespace level so they can be referenced by the whole project
    //Enums contain immutable constants
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul=12, Aug, Sep, Oct, Nov, Dec};
    //can set first(or any) value and the rest will increment from there
    //used to create a library to be used consistently accross classes
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Month jan = Month.Jan;
            Month a = Month.Jan;
            Console.WriteLine(jan ==a); //prints "true"
            Console.WriteLine((int)jan); //prints 1
            Console.WriteLine((int)Month.Apr); //prints 4
            Console.WriteLine((int)Month.Aug);  //prints 13


            Console.ReadKey();
        }
    }
}
