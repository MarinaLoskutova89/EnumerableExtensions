using System.Collections.Generic;

namespace Top
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine($"[{string.Join(',', list.Top(30))}]");
                Console.WriteLine();

                List<Person> anotherList = new()
                {
                    new() { Name = "Alice", Age = 25 },
                    new() { Name = "Bob", Age = 15 },
                    new() { Name = "Charlie", Age = 40 },
                    new() { Name = "Dean", Age = 80 },
                    new() { Name = "Eva", Age = 5 },
                    new() { Name = "Frank", Age = 30 },
                    new() { Name = "Greg", Age = 55 },
                    new() { Name = "Hank", Age = 28 },
                    new() { Name = "Ilona", Age = 13 },
                };

                var output = anotherList.Top(30, person => person.Age);
                output.ToList().ForEach(x => Console.WriteLine($"Name - {x.Name}, Age - {x.Age}"));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
