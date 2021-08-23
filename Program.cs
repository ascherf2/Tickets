using System;
using System.IO;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
    
        {
            string file = "tickets.csv";
            string choice;
            do {
                // ask a question
                Console.WriteLine("1) Display tickets");
                Console.WriteLine("2) Enter tickets");
                Console.WriteLine("Enter any other key to quit");
                choice = Console.ReadLine();
                if (choice == "1") {
                    // display tickets
                    if (File.Exists(file)) {
                        StreamReader sr = new StreamReader(file);
                        sr.ReadLine();
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            string[] arr = line.Split(',');
                            Console.WriteLine("Ticket Id: {0}", arr[0]);
                            Console.WriteLine("Summary: {0}", arr[1]);
                            Console.WriteLine("Summary: {0}", arr[2]);
                            Console.WriteLine("Summary: {0}", arr[3]);
                            Console.WriteLine("Summary: {0}", arr[4]);
                            Console.WriteLine("Summary: {0}", arr[5]);
                            Console.WriteLine("Summary: {0}", arr[6]);

                            string[] arr2 = arr[6].Split('|');
                            Console.WriteLine("Watchers:");
                            for (int i = 0; i < arr2.Length; i++){
                                Console.WriteLine(arr2[i]);
                            }
                        }
                        sr.Close();
                    } else {
                        Console.WriteLine("Yo - there is no file!");
                    }
                } else if (choice == "2") {
                    // enter ticket
                    Console.WriteLine ("Enter Ticket ID:");
                    string ID = Console.ReadLine();

                    Console.WriteLine ("Enter Summary:");
                    string summary = Console.ReadLine();

                    Console.WriteLine ("Enter Ticket Status:");
                    string status = Console.ReadLine();

                    Console.WriteLine ("Enter Ticket Priority:");
                    string priority = Console.ReadLine();

                    Console.WriteLine ("Enter Sumitter of Ticket:");
                    string submitter = Console.ReadLine();

                    Console.WriteLine ("Enter Personel Assigned to Ticket:");
                    string assigned = Console.ReadLine();

                    Console.WriteLine ("Enter Who is Watching This Ticket:");
                    string watching = Console.ReadLine();

                    // TODO: Save data to file
                    StreamWriter sw = new StreamWriter(file, append:true);
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ID, summary, status, priority, submitter, assigned, watching);
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");            
        }
    }
}
