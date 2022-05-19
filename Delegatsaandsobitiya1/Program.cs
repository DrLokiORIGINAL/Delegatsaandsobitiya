using System;

namespace Delegatsaandsobitiya1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            ShowMessage method = Show;
            student.Move(7, method);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
