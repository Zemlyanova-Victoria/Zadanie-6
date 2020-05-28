using System;
using static System.Console;
using System.Collections.Generic;
using static System.Convert;


namespace ConsoleApp9
{

    class lib

    {
        public class Student

        {
            public string Id;

            public string FIO;

            public string Group;

            public string Data;

        }

        public List<Student> list = new List<Student>();

        public void add(string Id, string FIO, string Group, string Data)

        {
            list.Add(new Student() { Id = Id, FIO = FIO, Group = Group, Data = Data });
        }

        public void remov(string Id)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].Id == Id) list.RemoveAt(i);
            }
        }

        public void change(string Id, string FIO, string Group, string Data)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].Id == Id)

                {
                    list[i].FIO = FIO;

                    list[i].Group = Group;

                    list[i].Data = Data;

                }

            }

        }

        public void viv(string Id)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].Id == Id)

                {
                    Console.WriteLine(list[i].Id + " " + list[i].FIO + " " + list[i].Group + " " + list[i].Data);
                }
            }
        }
        public void year(string Id, int day1, int month1, int yea1)

        {
            int v1;
            int v2;
            int vozrast;
            string day = "";
            string month = "";
            string year = "";
            string data = "";

            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].Id == Id) 
                {
                    data = list[i].Data + "";
                }
            }

            v1 = data.IndexOf(".");
            v2 = data.LastIndexOf(".");

            for (int i = 0; i < v1; i++)
            {
                day = day + data[i];
            }

            for (int i = v1 + 1; i < v2; i++)
            {
                month = month + data[i];
            }

            for (int i = v2 + 1; i < data.Length; i++)
            {
                year = year + data[i];
            }
            Console.WriteLine("Дата рождения" + day + "." + month + "." + year);
            vozrast = yea1 - ToInt32(year);
            if (ToInt32(month) > month1) vozrast = vozrast - 1;

            else if (ToInt32(month) == month1)
                if (ToInt32(day) < day1) vozrast = vozrast - 1;
            Console.WriteLine("\nВозраст = " + vozrast);
        }

        public void show()

        {
            foreach (var i in list)

            {
                Console.WriteLine(i.FIO);

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            lib a = new lib();

            WriteLine("1 - Добавить студента.\n2 - Изменить данные о студенте.\n3 - Удалить студента.\n4 - Вывод всех студентов.");

            int n = ToInt32(ReadLine());

            while (n > 0)

            {

                if (n == 1)

                {
                    WriteLine("ID: "); string Id = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string Group = ReadLine();

                    WriteLine("Дата: "); string Data = ReadLine();

                    a.add(Id, FIO, Group, Data);

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 2)

                {
                    WriteLine("Введи ID и измененные данные: ");

                    WriteLine("ID: "); string Id = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string Group = ReadLine();

                    WriteLine("Дата: "); string Data = ReadLine();

                    a.change(Id, FIO, Group, Data);

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 3)

                {
                    WriteLine("Введи ID: ");

                    string Id = ReadLine();

                    a.remov(Id);

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 4)

                {
                    a.show();

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }
                else if (n == 5)

                {
                    WriteLine("Введи ID: ");
                    string Id = ReadLine();
                    a.viv(Id);
                    WriteLine("Введи действие: ");
                    n = ToInt32(ReadLine());
                }

                else if (n == 6)

                {
                    WriteLine("Введи ID: ");
                    string Id = ReadLine();
                    WriteLine("Введи дату: ");
                    WriteLine("День: ");
                    int day = ToInt32(ReadLine());
                    WriteLine("Месяц: ");
                    int month = ToInt32(ReadLine());
                    WriteLine("Год: ");
                    int year = ToInt32(ReadLine());
                    a.year(Id, day, month, year);
                    WriteLine("Введи действие: ");
                    n = ToInt32(ReadLine());
                }
            }
        }
    }
}



            

        

    









