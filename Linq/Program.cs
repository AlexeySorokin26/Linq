namespace Linq
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sorted = phoneBook.OrderBy(p => p.Name).ThenBy(p => p.LastName);

            foreach(var p in sorted)
                Console.WriteLine(p.Name + " " + p.Email +  " " + p.LastName + " " + p.PhoneNumber);

            while (true)
            {
                Console.WriteLine("input your page number from 1 to 3 included");
                var input = Console.ReadKey().KeyChar;
                int pageNum;
                var parsed = Int32.TryParse(input.ToString(), out pageNum);
                if (!parsed || pageNum < 1 || pageNum > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Страницы не существует");
                }
                else
                {
                    // пропускаем нужное количество элементов и берем 2 для показа на странице
                    var pageContent = phoneBook.Skip((pageNum - 1) * 2).Take(2);
                    Console.WriteLine();

                    // выводим результат
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

                    Console.WriteLine();
                }
            }



            Console.ReadKey();

        }
    }
}
