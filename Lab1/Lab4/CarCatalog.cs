using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class CarCatalog:IEnumerable
    {
        private Car[] cars;       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CarsEnumerator(cars);
        }

        public CarCatalog(Car[] a)
        {
            cars = a;
        }


    }

    class CarsEnumerator : IEnumerator
    {
        private Car[] cars;
        int position = -1;

        public CarsEnumerator(Car[] _cars)
        {
            this.cars = _cars;
        }

        object IEnumerator.Current
        {
            get 
            {
                if(position == -1 || position >= cars.Length) throw new IndexOutOfRangeException();
                else return cars[cars.Length - 1 - position];
            }
        }

        bool IEnumerator.MoveNext()
        {
            if (position < cars.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }

}
