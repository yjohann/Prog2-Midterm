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

            List<string> listOfBooks = new List<string> { "\"Meditations\" by Marcus Aurelius", 
                                                            "\"Discourses\" by Epictitus",
                                                           "\"Letters from a Stoic\" by Lucius Seneca",
                                                           "\"Art of War\" by Lao Tzu", 
                                                           "\"Ego is the Enemy\" by Ryan Holiday"};// list of books

            List<string> borrowedBooks = new List<string>();

            List<string> borrowStudentNames = new List<string>();

            List<string> borrowBookTitles = new List<string>();

            List<string> requestStatus = new List<string>();

            string[] status = { "Pending", "Approved", "Declined"};
            string[] statusLib = { "Available", "Borrowed" };

            int counter;

            
            
             
            while(!validInput) 
            {
                Console.WriteLine($"\nWelcome to the Library\n");
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
                            Console.Write("\nWhat do you want to do?\n ");
                            Console.WriteLine("\n1. View Available Books\n");
                            Console.WriteLine("\n2. Borrow Books\n");
                            Console.WriteLine("\n3. View Borrowed Books\n");
                            Console.WriteLine("\n4. Return Books\n");
                            Console.WriteLine("\n5. Logout\n");

                            Console.Write("PRESS the number and press ENTER: ");
                            string input3 = Console.ReadLine().ToLower();
                            Console.ReadKey();
                            Console.Clear();


                            if (int.TryParse(input3, out int options))
                            {
                                switch (options)   //STUDENT
                                {
                                    case 1:
                                        counter = 0;
                                        Console.WriteLine("\nThe available books are:");
                                        foreach (string books in listOfBooks)
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}. {books}\n");
                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 2: // BORROWING BOOKS
                                        counter = 0;
                                        Console.WriteLine("\nThe available books are:");
                                        foreach (string books in listOfBooks)
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}. {books}\n");
                                        }

                                        Console.WriteLine("What book do you want to borrow?\n");
                                        Console.Write("Enter the number: ");
                                         
                                        
                                        if (int.TryParse(Console.ReadLine(), out int bookNumber))//borrrowing books
                                        {
                                            
                                            if (bookNumber > 0 && bookNumber <= listOfBooks.Count )
                                            {
                                                Console.Write("Please input your NAME: ");
                                                string studentInput1 = Console.ReadLine().ToUpper();
                                                Console.Write("Please input the Book Title: ");
                                                string studentInput2 = Console.ReadLine();

                                                borrowStudentNames.Add(studentInput1);
                                                borrowBookTitles.Add(listOfBooks[bookNumber - 1]);
                                                requestStatus.Add("Pending");
                                               
                                                Console.WriteLine($"\nThe request to borrow \"{listOfBooks[bookNumber-1]}\" has been sent to the librarian!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nERROR!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nINVALID INPUT!");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 3:
                                        Console.WriteLine("\nStudent Request Books:\n");
                                        counter= 0;
                                        for( int counter1 =0; counter1 < borrowStudentNames.Count; counter1++)
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}.{borrowStudentNames[counter1]} is borrowing {borrowBookTitles[counter1]} || STATUS: {requestStatus[counter1]}");
                                        }

                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 4:
                                        Console.WriteLine("\nList of borrowed Books:");
                                        counter = 0;
                                        for(int counter1 = 0; counter1< borrowedBooks.Count; counter1++)
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}. {borrowedBooks[counter1]} ");

                                        }

                                        Console.Write("\nWhat book would you like to return? Enter the NUMBER: ");

                                        if (int.TryParse(Console.ReadLine(), out int bookReturn))// returning books
                                        {
                                            if(bookReturn > 0 && bookReturn <= borrowedBooks.Count)
                                            {
                                               string returnedBook = borrowedBooks[bookReturn-1 ];
                                                borrowedBooks.RemoveAt(bookReturn-1 );
                                                listOfBooks.Add(returnedBook);

                                                 for(int counter1 = 0; counter1 < borrowBookTitles.Count; counter1++)
                                                 {
                                                    if (borrowBookTitles[counter1] == returnedBook)
                                                    {
                                                        borrowBookTitles.RemoveAt(counter1);
                                                        borrowStudentNames.RemoveAt(counter1);
                                                        requestStatus.RemoveAt(counter1);
                                                        break; 
                                                    }
                                                 }
                                                Console.WriteLine($"The book {returnedBook} has been successfully returned!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("INVALID INPUT!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("ERROR!");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 5:
                                        validInput = false;
                                        login = false;
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.WriteLine("ERROR!");
                                        break;

                                }
                            }

                       
                        }
                        else if (userInput == 2)    //LIBRARIAN
                        {
                            Console.WriteLine("What do you want to do? ");
                            Console.WriteLine("\n1. Add New Books\n");
                            Console.WriteLine("\n2. View All Books\n");
                            Console.WriteLine("\n3. View Pending Borrow Request\n");
                            Console.WriteLine("\n4. Approve || Decline Requests\n");
                            Console.WriteLine("\n5. Logout\n");

                            Console.Write("PRESS the number: ");
                            string input3 = Console.ReadLine().ToLower();

                            Console.ReadKey();
                            Console.Clear();

                            if (int.TryParse(input3, out int options))
                            {
                                switch (options)
                                {
                                    case 1:
                                        Console.WriteLine("\nADDING BOOK TO THE LIBRARY!\n");
                                        Console.Write("\nTitle of the Book: ");

                                        string bookTitle = Console.ReadLine();
                                        Console.Write("\nAuthor of the Book: ");
                                        string bookAuthor = Console.ReadLine();

                                        listOfBooks.Add($"\"{bookTitle}\" by {bookAuthor}");

                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 2:
                                        Console.WriteLine("\nAvailable books: \n");
                                        counter = 0;
                                        foreach(string book in listOfBooks)
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}. {book}\n");
                                        }
                                        counter = 0;
                                        Console.WriteLine("\nSTATUS of  books: \n");
                                        for (int counter1 = 0; counter1 < borrowStudentNames.Count; counter1++)
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}.{borrowStudentNames[counter1]} is borrowing {borrowBookTitles[counter1]} || STATUS: {requestStatus[counter1]}\n");
                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 3:
                                        Console.WriteLine("\nPending Borrow Requests\n");
                                        counter = 0;
                                        for (int counter1 = 0; counter1 < borrowStudentNames.Count; counter1++)
                                        {
                                            
                                            
                                                counter++;
                                                Console.WriteLine($"\n{counter}.{borrowStudentNames[counter1]} is borrowing {borrowBookTitles[counter1]} || STATUS: {requestStatus[counter1]}\n");
                                            
                                           
                                        }

                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 4:             //APPROVAL OF BOOK REQUESTS
                                        Console.WriteLine("\nPending Borrow Requests\n");
                                        counter = 0;
                                        for(int counter1 = 0; counter1 < borrowStudentNames.Count; counter1++ )
                                        {
                                            counter++;
                                            Console.WriteLine($"\n{counter}. {borrowStudentNames[counter1]} is requesting {borrowBookTitles[counter1]} || STATUS:{requestStatus[counter1]}\n");
                                        }

                                        Console.Write("\nEnter the number of the request to review: ");
                                        if (int.TryParse(Console.ReadLine(), out int requestNum) && requestNum > 0 && requestNum <= borrowStudentNames.Count)
                                        {
                                            Console.Write("\nPRESS A to \"Approve\" and D to \"Decline\": ");
                                            string userInput2 = Console.ReadLine().ToUpper();

                                            if (userInput2 == "A")
                                            {
                                                requestStatus[requestNum - 1] = "Borrowed";
                                                //
                                                borrowedBooks.Add(borrowBookTitles[requestNum - 1]);

                                                for (int counter1 = 0; counter1 < listOfBooks.Count; counter1++)
                                                {
                                                    if (listOfBooks[counter1] == borrowBookTitles[requestNum -1])
                                                    {
                                                        listOfBooks.RemoveAt(counter1);
                                                        break;
                                                    }
                                                }
                                                Console.WriteLine($"\nThe request for the book has been Approved!\n");
                                                

                                            }
                                            else if (userInput2 == "D")
                                            {
                                                requestStatus[requestNum - 1] = "Declined";
                                                Console.WriteLine($"\nThe request for the book has been Declined!\n");
                                            }
                                            
                                          
                                        }
                                        else
                                        {
                                            Console.WriteLine("INVALID INPUT!");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        

                                       

                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    case 5:
                                        validInput = false;
                                        login = false;
                                        Console.Clear();
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
