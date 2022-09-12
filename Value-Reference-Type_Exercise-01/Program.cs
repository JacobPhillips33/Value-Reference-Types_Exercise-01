using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Value_and_Reference_Types_Exercise_01
{
    public class Dog
    {
        public string name;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            #region Value Type TODOs 

            // DONE: Use the 3 value type variables that are already declared and initialized below
            double myDouble = .005;
            int myInteger = 10;
            string myString = "Hello World";

            // DONE: Write out each of these to the Conosle like so:
            // Console.WriteLine($"Before: {yourVariable}");

            Console.WriteLine($"Before: {myDouble}");
            Console.WriteLine($"Before: {myInteger}");
            Console.WriteLine($"Before: {myString}");

            // DONE: Use the ChangeValueType() function to "change the value type" for each variable
            // ChangeValueType(yourVariable);

            ChangeValueType(myDouble);
            ChangeValueType(myInteger);
            ChangeValueType(myString);

            AddSmallBreak();

            // Thought Experiment: What will the value of the original variable be after going through the ChangeValueType() method?
            // DONE: Double variable value = .005
            // DONE: Integer variable value = 10
            // DONE: String variable value = "Hello World"

            // Why:
            // Answer: Because value types copy the value and are not affected if you change the variable they grabbed the value from.

            // DONE: Write out the variable to the console after being passed through the ChangeValueType() function
            // Console.WriteLine($"Adjusted: {yourVariable}");

            Console.WriteLine($"Adjusted: {myDouble}");
            Console.WriteLine($"Adjusted: {myInteger}");
            Console.WriteLine($"Adjusted: {myString}");

            #endregion

            AddLargeBreak();

            #region Reference Type TODOs

            // DONE: Use the 4 reference type variables that are already declared and initialized below
            StringBuilder sb = new StringBuilder("The starting string's value."); //DONE
            List<int> myList = new List<int>() { 1, 2, 3 }; //DONE
            int[] myArray = new int[] { 4, 5, 6 };  //DONE
            Dog myDogObject = new Dog { name = "Lassy" };

            // DONE: Write out each of these to the Conosle. Remember to use a loop for the list and array!


            // Answer for sb 

            Console.WriteLine($"Before: {sb}");

            // Answer for myList 
            
            Console.Write($"Before: ");

            foreach (int num in myList)
            {
                Console.Write(num);
            }

            Console.WriteLine(); //Using this so that the below will be on a new line - there is probably a better way

            //Answer for myArray

            Console.Write("Before: ");

            foreach(int num in myArray)
            {
                Console.Write(num);
            }

            Console.WriteLine(); //Using this so that the below will be on a new line - there is probably a better way

            //Answer for myDogObject

            Console.WriteLine(myDogObject.name);



            // DONE: Use the ChangeReferenceType() function to "change the reference" for each variable

            ChangeReferenceType(sb);
            ChangeReferenceType(myList);
            ChangeReferenceType(myArray);
            ChangeReferenceType(myDogObject);

            // Thought Experiment: What will the value of the original variable be after going through the ChangeReferenceType() method?
            // DONE: StringBuilder variable value = "The ending string's value."
            // DONE: List<int> variable values = 100200300
            // DONE: int[] variable values = 400500600
            // DONE: Dog object variable's name = "A changed name"

            // Why:
            // Answer: Because reference types reference a value placeholder rather than copying the value directly. If you
                    // change the value in the placeholder, the reference type value will change because the value inside
                    // the placeholder that it is referencing has changed.


            // DONE: Write out the adjusted variables to the console after being passed through the ChangeReferenceType() function

            #endregion

            AddSmallBreak();


            //Answer for sb

            Console.WriteLine($"Adjusted: {sb}");


            //Answer for myList

            Console.Write("Adjusted: ");

            foreach(var num in myList)
            {
                Console.Write(num);
            }

            Console.WriteLine();


            //Answer for myArray

            Console.Write("Adjusted: ");

            foreach (var num in myArray)
            {
                Console.Write(num);
            }

            Console.WriteLine();


            //Answer for myDogObject

            Console.WriteLine($"Adjusted: {myDogObject.name}");


            AddLargeBreak();
        }






        #region Value Type TODO methods

        static void ChangeValueType(double x)
        {
            x = 1.125; // x's value has been changed to 1.125            
        }

        static void ChangeValueType(int x)
        {
            x = 100; // x's value has been changed to 100            
        }

        static void ChangeValueType(string x)
        {
            x = "A new value"; // x's value has been chaged to "A new value"
        }


        #endregion

        #region Reference Types TODO methods

        public static void ChangeReferenceType(StringBuilder sb)
        {
            sb.Remove(0, sb.Length);
            sb.Append("The ending string's value.");
        }

        public static void ChangeReferenceType(List<int> list)
        {
            list.RemoveAll(x => x < 4);
            list.Add(100);
            list.Add(200);
            list.Add(300);
        }

        public static void ChangeReferenceType(int[] arr)
        {
            arr[0] = 400;
            arr[1] = 500;
            arr[2] = 600;
        }

        public static void ChangeReferenceType(Dog dog)
        {
            dog.name = "A changed name";
        }

        #endregion

        #region Utility Methods

        public static void AddSmallBreak()
        {
            Console.WriteLine();
            Console.WriteLine("*********************************************************");
            Console.WriteLine();
        }

        public static void AddLargeBreak()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============================================================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion
    }
}
