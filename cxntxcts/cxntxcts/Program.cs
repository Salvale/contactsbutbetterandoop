using System;
using System.Collections.Generic;

namespace cxntxcts
{
    class Program
    {

        public class contact
        {
            public string name;
            public long number;
            public string email;

            public contact(string givenname, long phonenumber, string personalemail)
            {
                name = givenname;
                number = phonenumber;
                email = personalemail;
            }
        }
        public static List<contact> contax = new List<contact>();
        static void Main()
        {
            create("mary", 7804301372, "m.sue@tormail.com");
            create("satan", 6666666666, "l.satan@hotmail.com");
            create("redacted", 0000000000, "r.edacted@redac.ted");
            int a = 0;
            while (a < 89379349)
            {
                draw();
            }
        }
        static void draw()
        {
            Console.WriteLine("Welcome to your contact list sir");
            Console.WriteLine("1: Display the names of all your contacts");
            Console.WriteLine("2: Search for contact");
            Console.WriteLine("3: Edit contact");
            Console.WriteLine("4: Add new contact");
            Console.WriteLine("5: Remove contact");
            Console.WriteLine("6: Shut down");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (input == 1)
            {
                for (int i = 0; i < contax.Count; i++)
                {
                    Console.WriteLine(contax[i].name);
                }
            }
            else if (input == 2)
            {
                Console.Write("Search for: ");
                string searched = Console.ReadLine();
                bool finded = false; //bool to detect whether search was successful
                for (int i = 0; i < contax.Count; i++)
                {
                    bool present = trySearch(searched, i);
                    if (present)
                    {
                        //write all info if found
                        Console.WriteLine("Name: " + contax[i].name);
                        Console.WriteLine("Email: " + contax[i].number);
                        Console.WriteLine("Phone: " + contax[i].email);
                        finded = true;
                    }
                }
                if (!finded)
                {
                    //if not found, do nothing
                    Console.WriteLine(searched + " not found!");
                }
            }
            else if (input == 3)
            {
                //search for user input
                Console.Write("Search for: ");
                string searched = Console.ReadLine();
                bool finded = false;
                for (int i = 0; i < contax.Count; i++)
                {
                    bool present = trySearch(searched, i);
                    if (present)
                    {
                        finded = true;
                        //change info if found
                        Console.WriteLine(searched + " was found!");
                        Console.Write("Print the new name: ");
                        string newname = Console.ReadLine();
                        Console.Write("Print the new email: ");
                        string newmail = Console.ReadLine();
                        Console.Write("Print the new phone number: ");
                        long newnumb = Convert.ToInt64(Console.ReadLine());
                        contax[i].name = newname;
                        contax[i].email = newmail;
                        contax[i].number = newnumb;
                        break;
                    }
                }
                if (!finded)
                {
                    //do nothing if not found 
                    Console.WriteLine(searched + " not found!");
                }
            }
            else if (input == 4)
            {
                
                Console.Write("Print the new name: ");
                string newname = Console.ReadLine();
                Console.Write("Print the new email: ");
                string newmail = Console.ReadLine();
                Console.Write("Print the new phone number: ");
                long newnumb = Convert.ToInt32(Console.ReadLine());
                //call creation function
                create(newname, newnumb, newmail);
            }
            else if (input == 5)
            {
                
                Console.Write("Search for: ");
                string searched = Console.ReadLine();
                bool finded = false;
                for (int i = 0; i < contax.Count; i++)
                {
                    bool present = trySearch(searched, i);
                    if (present)
                    {
                        contax.RemoveAt(i);
                        finded = true; 
                    }
                }
                if (!finded)
                { //you know what this does by now
                    Console.WriteLine(searched + " not found!");
                }
            }
            else if (input == 6)
            { // a  a a
                System.Environment.Exit(0);
            } else
            {
                Console.WriteLine("not a valid input");
            }
        }
        static void create(string name, long number, string mail)
        {
            contact newt = new contact(name, number, mail);
            contax.Add(newt);
        }
        static bool trySearch(string tryfor, int index)
        { //detect if list contains a value equivalent to user input string 
            if (contax[index].name == tryfor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
