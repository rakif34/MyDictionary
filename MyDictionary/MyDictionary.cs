using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,F>
    {

        T[] names;
        F[] ages;

        //constructor

        public MyDictionary()
        {
            names = new T[0];
            ages = new F[0];
        }

        public void Add(T name, F age)
        {
            T[] tempArrayN = names;
            names = new T[names.Length + 1];
            for (int i = 0; i < tempArrayN.Length; i++)
            {
                names[i] = tempArrayN[i];
            }
            names[names.Length - 1] = name;

            F[] tempArrayA = ages;
            ages = new F[ages.Length + 1];
            for (int i = 0; i < tempArrayA.Length; i++)
            {
                ages[i] = tempArrayA[i];
            }
            ages[ages.Length - 1] = age;



        }

        public void List()
        {
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("Name: " + names[j] +  " Age :" + ages[j] );
            }
        }


    }
}
