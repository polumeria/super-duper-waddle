using System;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security.Authentication.ExtendedProtection;
using System.Threading;
using System.Text.RegularExpressions; // \w \s \D

namespace forms
{
    internal class Program
    {
        public static Boolean checkstring(string actingstring)
        {
            // string s = "абвгдежзийклмнопрстуфхцчшщъыьэюя АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ-";
            string[] check = {actingstring};
            string pattern = @"\w \s \D";
            Regex r = new Regex(pattern);

            foreach (string s in check)  
            {  
                return r.IsMatch(s) ? true : false;  
            }
            throw new Exception("Вот сейчас очень неожиданно было");  
        }

        public static Boolean checkdata(string actingstring)
        {
            // string s = "абвгдежзийклмнопрстуфхцчшщъыьэюя АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ-";
            string[] check = {actingstring};
            string pattern = @"\w \s \D";
            Regex r = new Regex(pattern);

            foreach (string s in check)  
            {  
                return r.IsMatch(s) ? true : false;  
            }
            throw new Exception("Вот сейчас очень неожиданно было");  
        }

        public static Boolean checkemail(string actingstring)
        {
            // string s = "абвгдежзийклмнопрстуфхцчшщъыьэюя АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ-";
            string[] check = {actingstring};
            string pattern = @"\w \s \D";
            Regex r = new Regex(pattern);

            foreach (string s in check)  
            {  
                return r.IsMatch(s) ? true : false;  
            }
            throw new Exception("Вот сейчас очень неожиданно было");  
        }

        public static Boolean checknumber(string actingstring)
        {
            string[] check = {actingstring};
            string pattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}";
            Regex r = new Regex(pattern);

            foreach (string s in check)  
            {  
                return r.IsMatch(s) ? true : false;  
            }
            throw new Exception("Вот сейчас очень неожиданно было");  
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string actingstring;
            int positionname = 10;
            Random random = new Random();
            Boolean activeform = true;
            

            Console.SetCursorPosition(positionname + 24, 3);
            Console.WriteLine();
            Console.Write("Добро пожаловать! \nБудем очень благодарны, если вы примите участие в нашем анкетировании )");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();


            Console.Clear();
            Console.SetCursorPosition(positionname + 24, 3);
            Console.Write("Анкета");

            string path = "/forms/forms.txt";

            FileStream create = File.Create(path);
            FileStream open = File.Open(path, FileMode.Open);

            while (activeform)
            {
                
                // File.AppendAllText(path, "Введите ваше ФИО: " + actingstring);

                Console.SetCursorPosition(positionname + 1, 5);
                Console.Write("Ваши данные:");
                Console.SetCursorPosition(positionname + 1, 7);
                // Console.Write("Введите ваше ФИО: " + actingstring);
                Console.SetCursorPosition(positionname + 1, 8);
                try
                {
                    
                    actingstring = Console.ReadLine();
                    while (checkstring(actingstring))
                    {
                        Console.SetCursorPosition(positionname + 1, 8);
                        Console.Write("                    ");
                        Console.SetCursorPosition(positionname + 1, 7);
                        Console.Write("Введите ваше ФИО: ");
                        Console.SetCursorPosition(positionname + 1, 8);
                        actingstring = Console.ReadLine();
                        // File.AppendAllText(path, "Введите ваше ФИО: " + actingstring + " /n");
                    }
                    // File.AppendAllText(path, "Введите ваше ФИО: " + actingstring + " /n");
                    
                    Console.SetCursorPosition(positionname + 1, 9);
                    Console.Write("Введите вашу дату рождения: ");
                    Console.SetCursorPosition(positionname + 1, 10);
                    actingstring = Console.ReadLine();
                    while (checkstring(actingstring))
                    {
                        Console.SetCursorPosition(positionname + 1, 10);
                        Console.Write("                    "); 
                        Console.SetCursorPosition(positionname + 1, 9);
                        Console.Write("Введите вашу дату рождения: ");
                        Console.SetCursorPosition(positionname + 1, 10);
                        actingstring = Console.ReadLine();
                    }
                    // File.AppendAllText(path, "Введите вашу дату рождения: " + actingstring + " /n");


                    Console.SetCursorPosition(positionname + 1, 11);
                    Console.Write("Введите ваш номер телефона: ");
                    Console.SetCursorPosition(positionname + 1, 12);
                    actingstring = Console.ReadLine();
                    while (checknumber(actingstring))
                    {
                        Console.SetCursorPosition(positionname + 1, 12);
                        Console.Write("                    ");
                        Console.SetCursorPosition(positionname + 1, 11);
                        Console.Write("Введите ваш номер телефона: ");
                        Console.SetCursorPosition(positionname + 1, 12);
                        actingstring = Console.ReadLine();
                    }
                    // File.AppendAllText(path, "Введите ваш номер телефона: " + actingstring + " /n");

                    Console.SetCursorPosition(positionname + 1, 13);
                    Console.Write("Введите вашу почту: ");
                    Console.SetCursorPosition(positionname + 1, 14);
                    actingstring = Console.ReadLine();
                    while (checkstring(actingstring))
                    {
                        Console.SetCursorPosition(positionname + 1, 14);
                        Console.Write("                    ");
                        Console.SetCursorPosition(positionname + 1, 13);
                        Console.Write("Введите вашу почту: ");
                        Console.SetCursorPosition(positionname + 1, 14);
                        actingstring = Console.ReadLine();
                    }
                    // File.AppendAllText(path, "Введите вашу почту: " + actingstring + " /n");

                    Console.SetCursorPosition(positionname + 1, 16);
                    Console.Write("Ваш любимый сорт чая: ");
                    Console.SetCursorPosition(positionname + 1, 17);
                    actingstring = Console.ReadLine();
                    while (checkstring(actingstring))
                    {
                        Console.SetCursorPosition(positionname + 1, 17);
                        Console.Write("                    "); 
                        Console.SetCursorPosition(positionname + 1, 16);
                        Console.Write("Ваш любимый сорт чая: ");
                        Console.SetCursorPosition(positionname + 1, 17);
                        actingstring = Console.ReadLine();
                    }
                    // File.AppendAllText(path, "Ваш любимый сорт чая: " + actingstring + " /n");

                    Console.SetCursorPosition(positionname + 1, 18);
                    Console.Write("Вы верите в бога?");
                    Console.SetCursorPosition(positionname + 1, 19);
                    actingstring = Console.ReadLine();
                    while (actingstring != "да")
                    {
                        Console.Clear();
                        Console.SetCursorPosition(positionname + 15, 10);
                        Console.Write("НЕПРАВИЛЬНО");
                        Console.ReadKey();
                        Console.Clear();
                        Console.SetCursorPosition(positionname + 1, 12);
                        Console.Write("Вы верите в бога?");
                        Console.SetCursorPosition(positionname + 10, 14);
                        actingstring = Console.ReadLine();
                    }
                    // File.AppendAllText(path, "Вы верите в бога?: " + actingstring);
                    // open.Close();
                                      
                }
                catch (FormatException)
                {

                }
            }

            activeform = false;

            Console.Clear();
            Console.SetCursorPosition(positionname + 0, 8);
            Console.Write("Спасибо что приняли участие в нашем опросе! \n Ваши ответы были сохранены в нашу базу");
            Console.SetCursorPosition(positionname + 0, 11);
            Console.Write("Если вы хотите проосмотреть свои данные - нажмите Enter");
            Console.SetCursorPosition(positionname + 0, 13);
            Console.Write("Для выхода нажмите любую кнопку");
            while (Console.ReadKey().Key == ConsoleKey.Enter) 
            {
                Console.Clear();
                try 
                {
                    // string path = "/home/holodok/visual_studio/csharp_p/forms/forms.txt";
                    FileInfo fileInfo = new FileInfo(path);
                    if (fileInfo.Exists)
                    {
                        string readText = File.ReadAllText(path);
                        Console.WriteLine(readText); 
                    }
                    
                    Console.SetCursorPosition(positionname + 0, 10);
                    Console.Write("данная функция еще в разработке");
                    Console.SetCursorPosition(positionname + 0, 12);
                    Console.Write("для выхода из окна нажмите любую кнопку");
                }
                catch (FormatException)
                {

                }  
            }

            Console.SetCursorPosition(positionname + 0, 20);
            
        }
    }
}        
