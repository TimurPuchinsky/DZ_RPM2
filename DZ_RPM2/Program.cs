using System;
using System.Collections.Generic;

namespace DZ_RPM2
{
    public class oblast
    {
        public string name;
        public string dolzhnost;
        public string group;
        public string urok;
        public string otchislenie123;
        internal int lesson;
        internal int otchislenie;
        //public event EventHandler CreateNew;
        public delegate void kadrovik();
        public event kadrovik CreatingNew;
        internal int Teachers;
        internal int Students;

        Random rnd = new Random();
        public void Teacher(string n, string d)
        {
            name = n;
            dolzhnost = d;
        }
        public void Student(string n, string g)
        {
            name = n;
            group = g;
        }
        public void Kadrovik(string n, string d)
        {
            name = n;
            dolzhnost = d;

            //void NewTeachers()
            //{
            //    for (int i = 0; i < Teachers; i++)
            //    {
            //        CreatingNew?.DynamicInvoke("{name} {dolzhnost}");
            //    }
            //}
        }
        public void NewTeachers()
        {
            int lesson = rnd.Next(1, 2);
            if (lesson == 1)
            {
                urok = "(ведёт лекцию)";
            }
            else
            {
                urok = "";
            }

            for (int i = 0; i < Teachers; i++)
            {
                Console.WriteLine($"(Учитель) {urok}");
            }
        }
        public void NewStudents()
        {
            int group = rnd.Next(1, 2);
            if (group == 1)
            {
                otchislenie123 = "(подаёт заявление на отчисление)";
            }
            else if (group == 2)
            {
                otchislenie123 = "";
            }

            for (int i = 0; i < Students; i++)
            {
                Console.WriteLine($"(Студент) {otchislenie123}");
            }
        }
        public void Create()
        {
            Console.WriteLine($"{name} {dolzhnost}{group}");
        }
        public void Lesson()
        {
            if (lesson > 0)
                Console.WriteLine("   (ведёт лекцию)");
        }
        public void Otchislenie()
        {
            if (otchislenie > 0)
                Console.WriteLine("   (подаёт заявление на отчисление)");
        }
        //public void OnnewTeacher()
        //{
        //    int teacher = rnd.Next(1, 3);
        //    int lesson = rnd.Next(1, 2);
        //    if (teacher == 1 & lesson == 1)
        //    {
        //        Console.WriteLine($"1 (Учитель)");
        //    }
        //    else if (teacher == 1 & lesson == 2)
        //    {
        //        Console.WriteLine($"1 (Учитель)");
        //        Console.WriteLine("   (ведёт лекцию)");
        //    }
        //    else if (teacher == 2 & lesson == 1)
        //    {
        //        Console.WriteLine($"2 (Учитель)");
        //    }
        //    else if (teacher == 2 & lesson == 2)
        //    {
        //        Console.WriteLine($"2 (Учитель)");
        //        Console.WriteLine("   (ведёт лекцию)");
        //    }
        //    else if (teacher == 3 & lesson == 1)
        //    {
        //        Console.WriteLine($"3 (Учитель)");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"3 (Учитель)");
        //        Console.WriteLine("   (ведёт лекцию)");
        //    }
        //}
        //public void OnnewStudent()
        //{
        //    int student = rnd.Next(1, 3);
        //    int otchislenie1 = rnd.Next(1, 2);
        //    int otchislenie2 = rnd.Next(1, 3);
        //    int otchislenie3 = rnd.Next(1, 4);
        //    if (student == 1 & otchislenie1 == 1)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //    }
        //    else if (student == 1 & otchislenie1 == 2)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //    }
        //    else if (student == 2 & otchislenie2 == 1)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine($"2 (3-1П11)");
        //    }
        //    else if (student == 2 & otchislenie2 == 2)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"2 (3-1П11)");
        //    }
        //    else if (student == 2 & otchislenie2 == 3)
        //    {
        //        Console.WriteLine($"2 (2-2П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"2 (3-1П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //    }
        //    else if (student == 3 & otchislenie3 == 1)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine($"2 (3-1П11)");
        //        Console.WriteLine($"3 (4-1П9)");
        //    }
        //    else if (student == 3 & otchislenie3 == 2)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"2 (3-1П11)");
        //        Console.WriteLine($"3 (4-1П9)");
        //    }
        //    else if (student == 3 & otchislenie3 == 3)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"2 (3-1П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"3 (4-1П9)");
        //    }
        //    else if (student == 3 & otchislenie3 == 4)
        //    {
        //        Console.WriteLine($"1 (2-2П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"2 (3-1П11)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //        Console.WriteLine($"3 (4-1П9)");
        //        Console.WriteLine("   (подаёт заявление на отчисление)");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"3 (Учитель)");
        //        Console.WriteLine("   (ведёт лекцию)");
        //    }
        //}
    }
}
