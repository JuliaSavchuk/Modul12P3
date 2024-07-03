using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12P3
    internal class Task2
    {
        public static void Tas2()
        {
            Console.Write("Введіть шлях до оригінального файлу: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введіть шлях, куди потрібно перемістити файл: ");
            string destinationPath = Console.ReadLine();

            try
            {
                File.Move(sourcePath, destinationPath);
                Console.WriteLine("Файл успішно переміщено.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при переміщенні файлу: {ex.Message}");
            }
        }
    }
}
