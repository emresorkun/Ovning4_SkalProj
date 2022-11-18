using System;
using System.Collections;
using System.ComponentModel;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// TESTTEST
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            List<string> theList = new List<string>();
            bool loopT=false;
            while (loopT==false)
            {
                
                Console.WriteLine("please enter a word with a + or - in the begining");
                string input= Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                Console.WriteLine(value);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Adding {value} to the list. The list has {theList.Count} members and the capacity of the list is {theList.Capacity}");
                        
                        
                        break;
                    case '-':
                        Console.WriteLine("minus");
                        if(theList.Count > 0)
                        {
                            if (theList.Contains(value))
                            {
                                theList.Remove(value);
                                Console.WriteLine($"Deleting {value} from the list. The list has {theList.Count} members and the capacity of the list is {theList.Capacity}");

                            }
                        }
                        else
                        {
                            Console.WriteLine("the list is empty, directing to the main menu");
                            loopT=true;
                        }
                        break;
                    default:
                        Console.WriteLine("enter - or +");
                        break;
                          
                }
                Console.WriteLine("enter any value to continue adding-subtrackting. Wish to exit? please type xX");

                string exitCode = Console.ReadLine();
                if (exitCode == "xX")
                {
                    Console.WriteLine("You are being directed to the main menu");
                    loopT = true;
                
                }
                else
                {

                    loopT = false;
                    
                        };
            }
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             // DO WHILE? DONE
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             // ADD.LIST??
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             
             * As a default case, tell them to use only + or -
             //easy
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            var queue=new Queue<string>();
            //propbabaly queue will be empty when created but just checking if it is empty or not?
            if (queue.Count>0)
            {
                queue.Clear();
            }
            else
            {
                queue.Enqueue("Kalle");

                queue.Enqueue("Greta");
                queue.Dequeue();
                queue.Enqueue("Stina");
                queue.Dequeue();
            }
            static void Print(Queue queue)
            {
                foreach (string item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            
            

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

