using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp2
{
    public static class Logger
    {
        public static void Log(ArgumentException ex, bool fileLogger, bool consoleLogger)
        {
            if (fileLogger) { FileLogger(ex); }
            if (consoleLogger)
            {
                if (ex is InvalidTestingNameException)
                    ConsoleLogger(ex as InvalidTestingNameException);
                else if (ex is InvalidNumberOfQuestionsException)
                    ConsoleLogger(ex as InvalidNumberOfQuestionsException);
            }

        }

        private static void FileLogger(Exception ex)
        {
            string error = $"{DateTime.Now}, INFO: {ex.Message}";
            using (StreamWriter file = new StreamWriter(@"D:\log.txt"/*, false, Encoding.Default*/))
            {
                file.WriteLine(error);
                file.Close();
            }
        }

        private static void ConsoleLogger(InvalidNumberOfQuestionsException ex)
        {
            Console.WriteLine($"\n\tОшибка");
            Console.WriteLine($"Сообщение: {ex.Message}");
            Console.WriteLine($"Неправильное имя: {ex.Value}");
            Console.WriteLine("-> Место возникновения: {0}", ex.TargetSite);
            foreach (DictionaryEntry d in ex.Data)
                Console.WriteLine("-> {0} {1}", d.Key, d.Value);
        }
        private static void ConsoleLogger(InvalidTestingNameException ex)
        {
            Console.WriteLine($"\n\tОшибка");
            Console.WriteLine($"Сообщение: {ex.Message}");
            Console.WriteLine($"Неправильное имя: {ex.Value}");
            Console.WriteLine("-> Место возникновения: {0}", ex.TargetSite);
            foreach (DictionaryEntry d in ex.Data)
                Console.WriteLine("-> {0} {1}", d.Key, d.Value);
        }
    }
}
