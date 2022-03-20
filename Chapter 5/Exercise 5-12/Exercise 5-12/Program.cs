/*
Write a program named WebAddress that asks a user for a business name. Suggest a
good Web address by adding www. to the front of the name, removing all spaces from
the name, and adding .com to the end of the name. For example, a good Web address
for Acme Plumbing and Supply is www.AcmePlumbingandSupply.com.
 */



using System;
using static System.Console;

namespace Exercise_5_12
{
    class WebAddress
    {
        static void Main(string[] args)
        {
            const string firstUrl = "www.";
            const string lastUrl = ".com";

            string inputAddress;
            Write("Enter your business namme: ");
            inputAddress = ReadLine();

            WriteLine("{0}{1}{2}", firstUrl, inputAddress.Replace(" ", ""), lastUrl);
        }
    }
}
