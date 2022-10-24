using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] data;

        public MyList()
        {
            data = new T[0];
        }

        public void Append(T newElement)
        {
            T[] newData = new T[data.Length + 1];
            for(int i = 0; i<data.Length; i++)
                newData[i] = data[i];
            newData[data.Length] = newElement;
            data = newData;
        }

        //можно добавить и удаление

        public int Count()
        {
            return data.Length;
        }      
             

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public T this[int x]
        {
            get { return data[x]; }
        }

    }


}
