using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * (Compile-ready) code that displays C#'s basic structure
 * with commented notes to help understand basic concepts. Please ask
 * questions regarding simnilarities and differences between C# and Java
 * as a strong understanding of C# will be crucial to writing Image Processing
 * code in the coming year.
 * 
 * -Manan
 */
namespace basics
{
    class Notes
    {
        /**
         * Variables and their respective declarations
         */
        short myShort;
        int myInt;
        long myLong = 2L;
        uint myUnInt = 2U;
        ushort myUnShort;
        ulong myUnLong = 2UL;
        byte myByte;
        sbyte mySByte;
        float myFloat = 2.0f;
        double myDouble = 2.0D;
        decimal myDecimal = 2.0M; //long double
        bool myBool = true; //does not accept number

        /*
         * Nullable value-types: allows null to be assigned
         * to a value-type
         */
        int? myint = null;

        /*
         * Checking for overflow
         *  => this takes time but sometimes is necessary
         */

        int c = checked(30 + 40); //checks expression for overflow and throws System.OverflowException
        /*
         * You can also use checked as
         *  checked{ code here... }
         */

        int d = unchecked(30 + 40); //don't check expression

        /*
         * Types of notation:
         */
        uint t = 0xFF00FF00; //hex notation
        double scinotation = 1.0E-20f; //scientific notation

        /**
         * Variable modifiers (like public/private/etc. in Java)
         */
        public readonly int myConst;    // Const, initialised once at runtime.
        public const int myConst = 1;   // Const, initialised at compile time
        public static int myStaticInt;  // static class/struct variable
        public int myInt;               // Accessible everywhere
        protected int myInt;            // Accessible only to derived classes
        private int myInt;              // Accessible only inside the class/struct
        internal int myInt;             // Accessible only inside the assembly(exe/dll)
        public volatile int myInt;      // Not optimized for accessing regularly in multiple threads

        /**
         * Converting variables to strings:
         */
        static bool test = true;
        string ds = test.ToString(); //this works for all variables

        /**
         * Converting variables from strings:
         */

        int x = Convert.ToInt32("10");
        static string value = Double.MinValue.ToString();
        static double number;

        /*
        if (Double.TryParse(value, out number))
           Console.WriteLine(number);
        else
           Console.WriteLine("{0} is outside the range of a Double.", 
                             value);

        value = Double.MaxValue.ToString();
        if (Double.TryParse(value, out number))
           Console.WriteLine(number);
        else
           Console.WriteLine("{0} is outside the range of a Double.",
                             value);
        * The example displays the following output: 
        *   -1.79769313486232E+308 is outside the range of the Double type. 
        *   1.79769313486232E+308 is outside the range of the Double type.  
        */

        /**
         * Looping & Loguc
         *  - this is very similar to Java so you shouldn't have much to change
         *  - be sure to follow common C# standards
         */

        /* 
        1) if-else statements
        
        if (myNumber){} //BAD: cannot use if(myNumber) to test if != 0 (C++ can)
        else if (myBool && myNumber != 0){}
        else if (myObj != null || !myBool){}
        else {}
        
        
        2) ternary operators
        
        myInt = myBool ? 0 : 10;
        myInt = myObj == null ? 0 : 10
        
        
        3) the null coalescing operator
        
        int y = myint ?? -1; //if myInt != null, return myInt else -1 where int? myInt;
        myString = str ?? ""; //if str is null, use default value provided otherwise use str
        myObj2 = myObj ?? new MyClass();

        
        4) switch statements
            - can use int, string, char or enum
            - IMPORTANT: can't fall through the next case, must use break, return or goto
         
        switch(myString)
        {
        case "one":
            goto case "two";
        case "two":
            break;
        default:
            break;
        }

        
       5) while loops
        
        while(!okay){ break; }
        do { continue; } while(!okay)

       
       6) for loops
        
        for (int i = 0; i < count; ++i){}

       
       7) for-each loops
            - cannot modify collection
            - uses explicit cast for each item
        
        foreach (str in myStringArray)
        foreach (int value in array)
        foreach (int item in myIEnum)
        foreach (int value in Enumerable.Range(0, 100)) //Enumerable requires LINQ
        
        
        */
    }
}