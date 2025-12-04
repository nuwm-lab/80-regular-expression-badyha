using System;
using RegularExpression;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    class Program
    {
        static void Main(string[] args)
        {
            // Зразковий текст з ORCID номерами у форматі 0000-0000-0000-0000
            string text = @"Автори статті:
Петренко Іван (ORCID: 0000-0002-1825-0097),
Іваненко Марія - 0000-0001-2345-6789,
Невірний формат 0000-000-0000-0000,
Ще один ORCID: 0000-0003-1415-9265.
Контакт: someone@example.com";

            var finder = new OrcidFinder();
            var orcids = finder.FindIn(text);

            Console.WriteLine("Знайдені ORCID-и:");
            if (orcids.Count == 0)
            {
                Console.WriteLine("  (не знайдено)");
            }
            else
            {
                foreach (var o in orcids)
                {
                    Console.WriteLine("  " + o);
                }
            }
        }
    }
}
