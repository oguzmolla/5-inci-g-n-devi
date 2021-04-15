using System;

namespace Exam1
{
    class Program
    {
        public string password = "1234";
        public static string[] courseList = { "C#", "Angular", "Dart" };

        public static void Main(string[] args)
        {
            Console.WriteLine("Şifre giriniz");
            string password = Console.ReadLine();

            if (password == "1234")
            {
                GetList(courseList);
            }
            else
            {
                Console.WriteLine("şifreniz yanlış");
            }

            Console.ReadLine();
        }

        public static string[] GetList(string[] objList)
        {
            foreach (string item in objList)
            {
                Console.WriteLine(item);
            }

            return objList;
        }
    }
}
