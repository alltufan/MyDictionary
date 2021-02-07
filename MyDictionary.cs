using System;
using System.Collections.Generic;
using System.Text;

namespace MyDicitonary
{
    public class MyDictionary<K, V>
    {
        K[] key;
        V[] value;

        K[] tempKey;
        V[] tempValue;

        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];


        }

        public void Add(K item1, V item2)
        {
            tempKey = key;
            tempValue = value;

            key = new K[key.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }
            key[key.Length - 1] = item1;

            for (int i = 0; i < tempValue.Length; i++)
            {
                value[i] = tempValue[i];
            }

            value[value.Length - 1] = item2;
        }

        public int Count
        {
             get { return key.Length; }
    
        }

        public void ShowList()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("Id: "+key[i] +" Name : "+ value[i]);
            }
        }

    }
}
