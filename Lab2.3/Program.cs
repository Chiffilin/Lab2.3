using System;

namespace Lab2._3
{
    class Program
    {


        static void Main(string[] args)
        {
            int a, b,c,p;
            double S;
                Console.WriteLine("Lab2.Task3");                                //ввывод текста 
            Console.WriteLine("S=sqrt(p * (p - a) * (p - b) * (p - c))");
            Console.WriteLine("Введите целое число a");
            while (!int.TryParse(Console.ReadLine(), out a))                //проверка на ввод переменных
            {
                Console.WriteLine("Ошибка ввода! Введите целое число a");
            }
            Console.WriteLine("Введите целое число b");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число b");   //проверка на ввод переменных
            }
            Console.WriteLine("Введите целое число c");
            while (!int.TryParse(Console.ReadLine(), out c))                //проверка на ввод переменных
            {
                Console.WriteLine("Ошибка ввода! Введите целое число c");
            }
            p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            Console.WriteLine("Ответ:" + S);

        }
        
    }
    class ProgramLog
    {
        System.IO.FileStream logFile = null;
        void OpenLog(System.IO.FileInfo fileName, System.IO.FileMode mode) { }

        void WriteLog()
        {
            if (!this.logFile.CanWrite)
            {
                throw new System.InvalidOperationException("Logfile cannot be read-only");
            }
            // Else write data to the log and return.
        }
    }
}
