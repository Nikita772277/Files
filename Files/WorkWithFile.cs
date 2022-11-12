using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class WorkWithFile
    {
        //private string file = @"C:\Users\Студент 3\Desktop\1\file.txt";
        //private string file2 = @"C:\Users\Студент 3\Desktop\2\index.txt";
        public void CreatFile() 
        {
            Console.WriteLine($"В какую папку добавить файл");
            string name=Console.ReadLine();
            Console.WriteLine($"Введите название файла");
            string enter=Console.ReadLine();
            string file = $@"C:\Users\Студент 3\Desktop\{name}\{enter}.txt";
            FileInfo fileInf = new FileInfo(file);
            if (!fileInf.Exists)
            {
                using (fileInf.Create())
                {
                    Console.WriteLine($"Файл создан");
                }
                
            }
            else { Console.WriteLine($"Такой файл уже существует"); }

        }
        public void FileMoving()
        {
            Console.WriteLine($"Из какой папки переместить файл");
            string wherefrom = Console.ReadLine();
            Console.WriteLine($"В какую папку переместить файла");
            string destination = Console.ReadLine();
            Console.WriteLine($"Введите название файла");
            string text=Console.ReadLine();
            string file = $@"C:\Users\Студент 3\Desktop\{wherefrom}\{text}.txt";
            string file2 = $@"C:\Users\Студент 3\Desktop\{destination}\{text}.txt";
            FileInfo fileinf =new FileInfo(file);
            if (fileinf.Exists)
            {
                fileinf.MoveTo(file2);
                Console.WriteLine($"Файл перемещён");
            }
            else
            {
                Console.WriteLine($"Такой файл уже существует в папке назначения");
            }
        }
        public void MultipleFilesCreat()
        {
            Console.WriteLine($"Сколько добавить файлов");
            string enter = Console.ReadLine();
            bool ent = int.TryParse(enter, out int a);
            if (ent == true)
            {
                for (int i = 0; i < a; i++)
                {
                    string file3 = $@"C:\Users\Студент 3\Desktop\2\file{i}.txt";
                    FileInfo fileInf = new FileInfo(file3);
                    fileInf.Create();
                }
                Console.WriteLine($"Создано {a} файлов");
            }
            else
            {
                Console.WriteLine($"Вы ввели не число");
            }
        }
        public void MultipleFilesDelete()
        {
            Console.WriteLine($"Сколько добавить файлов");
            string enter = Console.ReadLine();
            bool ent = int.TryParse(enter, out int a);
            if (ent == true)
            {
                for (int i = 0; i < a; i++)
                {
                    string file3 = $@"C:\Users\Студент 3\Desktop\2\file{i}.txt";
                    FileInfo fileInf = new FileInfo(file3);
                    fileInf.Delete();
                }
                Console.WriteLine($"удалено {a} файлов");
            }
            else { Console.WriteLine($"Вы ввели не число"); }
        }
        public void DeleteFile()
        {
            Console.WriteLine($"Название паки из которой вы хотите удалить файл");
            string folder=Console.ReadLine();
            Console.WriteLine($"Введите название файла который вы хотите удалить");
            string enter=Console.ReadLine();
            string file = $@"C:\Users\Студент 3\Desktop\{folder}\{enter}.txt";
            FileInfo fileInf = new FileInfo(file);
            if (fileInf.Exists)
            {
                fileInf.Delete();
                Console.WriteLine($"Файл удалён");
            }
            else { Console.WriteLine($"Нет файла с таким названием"); }
        }
        public async void Wrate()
        {
            Console.WriteLine($"В какой папке файл");
            string folder = Console.ReadLine();
            Console.WriteLine($"В какой файл записать данные");
            string enter = Console.ReadLine();
            Console.WriteLine($"Что добавить в файл");
            string text = Console.ReadLine(); 
            string file = $@"C:\Users\Студент 3\Desktop\{folder}\{enter}.txt";
            using (FileStream fileStream=new FileStream(file, FileMode.Open))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                await fileStream.WriteAsync(buffer, 0, buffer.Length);
                Console.WriteLine("текст записан в файл");
            }
            using (FileStream fileStream = File.OpenRead(file));
        }
        public async void StreamWriter()
        {
            Console.WriteLine($"В какой папке файл");
            string folder = Console.ReadLine();
            Console.WriteLine($"В какой файл записать данные");
            string enter = Console.ReadLine();
            string file = $@"C:\Users\Студент 3\Desktop\{folder}\{enter}.txt";
            Console.WriteLine($"Какой текст добавить в файл");
            string text = Console.ReadLine();
            using(StreamWriter writer = new StreamWriter(file, true))
            {
                await writer.WriteLineAsync(text);
            }
            //using (StreamWriter writer = new StreamWriter(file, true))
            //{
            //    await writer.WriteLineAsync("Addition");
            //    await writer.WriteAsync("4,5");
            //}
        }
    }
}
