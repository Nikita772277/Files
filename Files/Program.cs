using Files;

WorkWithFile workwithfile=new WorkWithFile();
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Создание файла");
    Console.WriteLine($"2) перемещение файла");
    Console.WriteLine($"3) создание множества файлов");
    Console.WriteLine($"4) Удаление");
    Console.WriteLine($"5) Добавление текста");
    Console.WriteLine($"6) Удалить несколько файлов");
    Console.WriteLine();
}
void Menu()
{
    while (true)
    {
        GetMenu();
        string enter = Console.ReadLine();
        bool chek = int.TryParse(enter, out int result);
        if (result == 1)
        {
            workwithfile.CreatFile();
        }
        else if (result == 2)
        {
            workwithfile.FileMoving();
        }
        else if (result == 3)
        {
            workwithfile.MultipleFilesCreat();
        }
        else if (result == 4)
        {
            workwithfile.DeleteFile();
        }
        else if (result == 5)
        {
            workwithfile.Wrate();
        }
        else if (result == 6)
        {
            workwithfile.MultipleFilesDelete();
        }
        else { Console.WriteLine($"Выберите пункт из меню"); }
    }
}
Menu();
//workwithfile.StreamWriter();