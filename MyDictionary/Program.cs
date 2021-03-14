using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            

            MyDictionary<string, int> adYas = new MyDictionary<string, int>();


            adYas.Add("Ahmet", 30);
            adYas.Add("Mehmet", 40);
            adYas.Add("Veli", 25);
            adYas.Add("Banu", 23);
            adYas.Add("Sedat", 22);

            adYas.List();


        }
    }
}
