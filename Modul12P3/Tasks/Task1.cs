using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12P3
{
    internal class Task1
    {
        public static void Tas1()
        {
            Console.Write("Введіть шлях до оригінального файлу: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введіть шлях, куди потрібно скопіювати файл: ");
            string destinationPath = Console.ReadLine();

            try
            {
                File.Copy(sourcePath, destinationPath);
                Console.WriteLine("Файл успішно скопійовано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при копіюванні файлу: {ex.Message}");
            }
        }
    }
}
