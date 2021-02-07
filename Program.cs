using System;
using System.Collections.Generic;
using System.Text;


namespace MyDicitonary
{
    class MainClass
    {
        static void Main()
        {
            Liste liste1 = new Liste(){ Id = 1, Name = "Ali" };
            Liste liste2 = new Liste(){ Id = 2, Name = "Önder" };
            Liste liste3 = new Liste() { Id = 3, Name = "Yusuf" };
            Liste liste4 = new Liste() { Id = 4, Name = "Hasan" };


            MyDictionary<int, string> dictionary  = new MyDictionary<int, string>();

            dictionary.Add(liste1.Id, liste1.Name);
            dictionary.Add(liste2.Id, liste2.Name);
            dictionary.Add(liste3.Id, liste3.Name);
            dictionary.Add(liste4.Id, liste4.Name);

            Console.WriteLine("Total Number: "+dictionary.Count);

            dictionary.ShowList();

            

           


        }
    }
}
