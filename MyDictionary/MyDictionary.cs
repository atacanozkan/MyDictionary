using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < keys.Length; i++)
                    if (keys[i].Equals(key))
                        return values[i];
                throw new Exception("There is no such a key in the dictionary");
            }
            set
            {
                for (int i = 0; i < keys.Length; i++)
                    if (keys[i].Equals(key))
                    {
                        values[i] = value;
                        return;
                    }
                throw new Exception("There is no such a key in the dictionary");
            }
        }

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < keys.Length; i++)
                if (keys[i].Equals(key))
                    throw new Exception("The key is already defined in the dictionary");

            TKey[] keysTemp = keys;
            TValue[] valuesTemp = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < keysTemp.Length; i++)
            {
                keys[i] = keysTemp[i];
                values[i] = valuesTemp[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length-1] = value;
        }
    }
}
