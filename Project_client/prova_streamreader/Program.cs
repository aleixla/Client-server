﻿using System;
using System.IO;

namespace prova_streamreader
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\\code\\ixla\\test\\Project\\Project_client\\prova_streamreader\\Myclient_server.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is some text");
                    sw.WriteLine("to test");
                    sw.WriteLine("Reading");
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            
        }
    }
}