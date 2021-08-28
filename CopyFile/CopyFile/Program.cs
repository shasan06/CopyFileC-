using System;
using System.IO;

namespace CopyFile
{
    class Program
    {

        static void Main(string[] args)
        {
            // Declare variables For Source File and Destination File Path.
            string source = ""; string destination = "";

            // Display title as the C# console Copy File app.
            Console.WriteLine("Console Copy File Project in C#\r");
            Console.WriteLine("--------------------------------\n");

            // Ask the user to type or paste Source File Path.
            Console.WriteLine("Paste the source File Full Path, and then press Enter");
            source = (Console.ReadLine());

            // Ask the user to type or paste the destination file full path.
            Console.WriteLine("Paste the Destination File full path, and then press Enter");
            destination = Console.ReadLine();

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tCopy - Copy File");
            Console.WriteLine("\tCancel - Cancel Copy");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "Copy":
                    Console.WriteLine($"Your Source File is: {source}");
                    Console.WriteLine($"Your Destination File is: {destination}");

                    // Console.WriteLine("Hello World!");

                   

                    string sourceFile = source;
                    string destinationFile = destination;
                    try
                    {
                        File.Copy(sourceFile, destinationFile, true);
                        //File.Open(destinationFile, FileMode.Open);
                        Console.WriteLine("Write Successfully");
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }
                    
                    break;


                case "Cancel":
                    Console.WriteLine($"Your request to cancel is executed.");
                    //Console.ReadKey();
                    break;

            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Copy File console app...");
            Console.ReadKey();
        }
    }
}

