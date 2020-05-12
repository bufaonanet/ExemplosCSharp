using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder";

            try
            {
                var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (var item in folders)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred: " + e.Message);                
            }

        }

        static void Arquivos()
        {
            string origem = @"C:\temp\file1.txt";
            string destino = @"C:\temp\file2.txt";

            try
            {
                FileInfo sourceFile = new FileInfo(origem);
                sourceFile.CopyTo(destino);

                string[] linhas = File.ReadAllLines(origem);

                foreach (var linha in linhas)
                {
                    Console.WriteLine(linha);
                }

                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred: " + e.Message);
                Console.ReadKey();
            }
        }
        static void Bloco()
        {
            string origem = @"C:\temp\file1.txt";


            try
            {
                using (StreamReader sr = File.OpenText(origem))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Escrevendo()
        {
            string origem = @"C:\temp\file1.txt";
            string destino = @"C:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(origem);

                using (StreamWriter sw = File.AppendText(destino))
                {
                    foreach (var line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
