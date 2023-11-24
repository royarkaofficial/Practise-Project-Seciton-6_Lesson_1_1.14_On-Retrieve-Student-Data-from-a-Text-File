using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specifed the path to the text file
            string filePath = "E:/Phase 2/Practise Project Sec 6_Last_Date_28_Nov/students.txt";

            // Check if the file exists or not
            if (File.Exists(filePath))
            {
                // Read all lines from the file that are present
                string[] lines = File.ReadAllLines(filePath);

                // Display each student's data on the file
                foreach (var line in lines)
                {
                    // Split the line into name and ID
                    string[] data = line.Split(',');

                    // Check if the line has the expected format or not
                    if (data.Length == 2)
                    {
                        string name = data[0].Trim();
                        string id = data[1].Trim();

                        // Display the student data which is retrived from the file
                        Console.WriteLine($"Name: {name}, ID: {id}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data format: {line}");
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            Console.ReadKey();
        }
    }
}
