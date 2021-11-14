using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_RPM2
{
    class Class1
    {
        static void Main(string[] args)
        {
            oblast teacher = new oblast();
            teacher.name = "Puchinsky Timur Aleksandrovich";
            teacher.dolzhnost = "(Учитель)";
            teacher.Create();
            teacher.lesson = 1;
            teacher.Lesson();

            oblast student = new oblast();
            student.name = "Ivanov Ivan Sergeevich";
            student.group = "(3-2П9)";
            student.Create();
            student.otchislenie = 1;
            student.Otchislenie();

            oblast kadrovik = new oblast();
            kadrovik.name = "Smirnov Alex Ivanovich";
            kadrovik.dolzhnost = "(Кадровик)";
            kadrovik.Create();
            kadrovik.Teachers = 3;
            kadrovik.NewTeachers();
            kadrovik.Students = 2;
            kadrovik.NewStudents();
            //kadrovik.OnnewTeacher();

            Console.ReadKey();
        }
    }
}
