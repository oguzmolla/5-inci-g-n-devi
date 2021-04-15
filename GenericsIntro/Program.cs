using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            Console.WriteLine(names.Length);

            names.Add("Oğuzhan");

            Console.WriteLine(names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
