using System;
namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.Write("Moi nhap chuoi can sap xep: ");
            string s = Console.ReadLine();
            Xep(ref s);
            Console.WriteLine(s);
        }

        
    }
}




