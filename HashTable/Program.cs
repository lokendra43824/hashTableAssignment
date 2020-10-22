using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash5 = hash.get("5");
            string hash4 = hash.get("4");
            string hash3 = hash.get("3");
            string hash2 = hash.get("2");
            string hash1 = hash.get("1");

            Console.WriteLine(hash5);
            Console.WriteLine(hash4);
            Console.WriteLine(hash3);
            Console.WriteLine(hash2);
            Console.WriteLine(hash1);




        }
    }
}
