using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T val1;
        private T val2;
        private T val3;

        public Guarda3()
        {
            val1 = default(T);
            val2 = default(T);
            val3 = default(T);
        }

        public T GetItem(int i)
        {
            return i switch
            {
                0 => val1,
                1 => val2,
                2 => val3,
                _ => throw new IndexOutOfRangeException()
            };
        }

        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(val1, default(T)))
                val1 = item;
            else if (EqualityComparer<T>.Default.Equals(val2, default(T)))
                val2 = item;
            else if (EqualityComparer<T>.Default.Equals(val3, default(T)))
                val3 = item;
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0: 
                    val1 = item; 
                    break;
                
                case 1:
                    val2 = item;
                    break;
                
                case 2:
                    val3 = item;
                    break;

                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return val1;
            yield return val2;
            yield return val3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}