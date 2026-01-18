using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Liste<T> : IEnumerable<T>
    {
        int count_ = 0;
        int index_ = 0;
        private T[] values;

        public Liste()
        {
            values = new T[4];
        }

        public T this[int index]
        {
            get
            {
                return values[index];
            }
        }

        public void Add(T value)
        {
            if (count_ == values.Length)
            {
                int newCount = values.Length + 1;
                T[] newValues = new T[newCount];
                Array.Copy(values, newValues, values.Length);
                values = newValues;
            }
            values[count_] = value;
            count_++;
        }

        public void RemoveAt(int deleteIndex)
        {
            int temporaryCount = values.Length - 1;
            T[] newValues = new T[temporaryCount];
            for (int i = 0, a = 0; i < values.Length; i++)
            {
                if (i != deleteIndex)
                {
                    newValues[a] = values[i];
                    a++;
                }
            }

            values = newValues;
            count_--;
        }

        public void Remove(T deleteValue)
        {
            string deleteString = deleteValue.ToString();
            
            int start, finish, result, temporaryCount;
            for (start = 0, finish = 0; start < values.Length; start++)
            {
                string valueString = values[start].ToString();
                if (valueString != deleteString)
                {
                    finish++;
                }
            }

            result = start - finish;// start - finish yapıyorumki kaç eleman eksildiğini bulabiliyim
            temporaryCount = values.Length - result;
            T[] newValues = new T[temporaryCount];

            for (int i = 0, a = 0; i < values.Length; i++)
            {
                string valueString = values[i].ToString();
                if (valueString != deleteString)
                {
                    newValues[a] = values[i];
                    a++;
                }
            }


            values = newValues;
            count_ -= result; // çıkan eleman kadar uzunluğu değiştiriyoruz
        }

        public bool Contains(T value)
        {
            string valueString = value.ToString();

            for (int i = 0; i < values.Length; i++)
            {
                string valuesString = values[i].ToString();
                if (valuesString == valueString)
                    return true;
            }
            return false;

        }

        public void Clear()
        {
            T[] newValues = new T[0];
            values = newValues;
            count_ = 0;
        }

        public void ListReader()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }


        public int Count()
        {
            return values.Length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count_; i++)
            {
                yield return values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}