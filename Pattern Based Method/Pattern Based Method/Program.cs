using System;

namespace Pattern_Based_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string EncodeText = Myclass.Encoding("Hello world!");
            Console.WriteLine($"Encode Text->{EncodeText}");
            string DecodeText = Myclass.Decoding(EncodeText);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"Decode Text->{DecodeText}");
        }
    }
}
