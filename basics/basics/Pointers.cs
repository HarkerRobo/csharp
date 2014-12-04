using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Used in the pointer lecture. Remember unsafe!
 */
namespace basics
{
    //used in unsafeFunction()
    class Point { public int x, y; }

    class Pointers
    {

        static unsafe void Main(string[] args) {
            //Pointers can only be used in unsafe code
            int temp = 3;
            int* ptr = &temp; 
            int*[] arrayPtr;    //array of pointers to ints
            char* charPtr;      //pointer to a char
            void* voidPtr;
            *ptr = 2;           //dereferencing

            unsafeFunction();
        }

        unsafe static void unsafeFunction()
        {
            //Pinning Variables --
            //prevents garbage collector from changing address of a variable
            //can only use in unsafe context
            
            // pt is a managed variable, subject to garbage collection.
            Point pt = new Point();

            // Using fixed allows the address of pt members to be
            // taken, and "pins" pt so it isn't relocated.
            fixed (int* p = &pt.x)
            {
                *p = 1;
            }
            Console.WriteLine(pt.x); //now changed to 1
        }
    }
}
