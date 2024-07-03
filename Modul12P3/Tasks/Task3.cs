using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12P3 
{
    internal class Task3
    {
        public static void Tas3()
        {
            Console.Write("Введіть шлях до початкової папки: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введіть шлях, куди потрібно скопіювати папку: ");
            string destinationPath = Console.ReadLine();

            try
            {
                CopyDirectory(sourcePath, destinationPath);
                Console.WriteLine("Папку успішно скопійовано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при копіюванні папки: {ex.Message}");
            }
        }

        static void CopyDirectory(string sourceDir, string destinationDir)
        {
            // Створення цільової папки, якщо вона не існує
            Directory.CreateDirectory(destinationDir);

            // Копіювання всіх файлів
            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile);
            }

            // Копіювання всіх підпапок
            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                string destDirectory = Path.Combine(destinationDir, Path.GetFileName(directory));
                CopyDirectory(directory, destDirectory);
            }
        }
    }
}
