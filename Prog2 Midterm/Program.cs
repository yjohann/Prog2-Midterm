using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            bool login = false; 
            List<string> listOfStudents = new List<string> { "Chris", "Yuan", "Eudrick", "Ross", "Luis" }; ;

            List<string> listOfLibrarian = new List<string> { "Rose", "Gilbs" };
            
            Console.WriteLine($"Welcome to the Library");
            Console.WriteLine();

            while(!validInput) 
            {
                Console.Write($"Please enter your role: 1 for student. || 2 for librarian. ");

                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    if (userInput == 1)
                    {
                        Console.Write("\nPlease enter your name: ");
                        String input1 = Console.ReadLine().ToLower();

                        bool nameFound = false;
                        foreach (string student in listOfStudents)
                        {
                            if (student.ToLower() == input1)
                            {
                                nameFound = true;
                                break;
                               
                            }
                        }

                        if (nameFound)
                        {
                            login = true;
                            validInput = true;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\n ERROR! Name not found!\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (userInput == 2) 
                    {
                        Console.Write("\nPlease enter your name: ");
                        String input2 = Console.ReadLine().ToLower();

                        bool nameFound = false;
                        foreach (string librarian in listOfLibrarian)
                        {
                            if (librarian.ToLower() == input2)
                            {
                                nameFound = true;
                                break;
                            }
                        }

                        if (nameFound)
                        {
                            login = true;
                            validInput = true;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\n ERROR! Name not found!\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nINVALID INPUT!\n");
                        Console.ReadKey();
                        Console.Clear();
                    }


                    while (login)
                    {
                        if(userInput == 1)
                        {
                            Console.Write("What do you want to do? ");
                            Console.WriteLine("\n1. View Available Books\n");
                            Console.WriteLine("\n2. Borrow Books\n");
                            Console.WriteLine("\n3. View Borrowed Books\n");
                            Console.WriteLine("\n4. Return Books\n");
                            Console.WriteLine("\n5. Logout\n");

                            Console.Write("PRESS the number: ");
                            string input3 = Console.ReadLine().ToLower();

                            if (int.TryParse(input3, out int options))
                            {
                                switch (options)
                                {
                                    case 1:
                                        Console.WriteLine("HI");
                                        break;

                                    case 2:

                                        break;

                                    case 3:

                                        break;

                                    case 4:

                                        break;

                                    case 5:
                                        login = false;
                                        break;

                                    default:
                                        Console.WriteLine("ERROR!");
                                        break;

                                }
                            }

                       
                        }
                        else if (userInput == 2)
                        {
                            Console.Write("What do you want to do? ");
                            Console.WriteLine("\n1. Add New Books\n");
                            Console.WriteLine("\n2. View All Books\n");
                            Console.WriteLine("\n3. View Pending Borrow Request\n");
                            Console.WriteLine("\n4. Approve || Decline Requests\n");
                            Console.WriteLine("\n5. Logout\n");

                            Console.Write("PRESS the number: ");
                            string input3 = Console.ReadLine().ToLower();

                            if (int.TryParse(input3, out int options))
                            {
                                switch (options)
                                {
                                    case 1:
                                        Console.WriteLine("Hello");
                                        break;

                                    case 2:

                                        break;

                                    case 3:

                                        break;

                                    case 4:

                                        break;

                                    case 5:
                                        login = false;
                                        break;

                                    default:
                                        Console.WriteLine("ERROR!");
                                        break;

                                }
                            }




                        }
                        else
                        {
                            Console.WriteLine("\nINVALID INPUT!\n");
                            Console.ReadKey();
                            Console.Clear();
                        }  
                    }

                }
                else
                {
                    Console.WriteLine("\nINVALID INPUT!\n");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

           

           





        }
    }
}
