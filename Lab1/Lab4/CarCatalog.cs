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
             

        public CarCatalog(Car[] a)
        {
            cars = a;
        }

        public int Length
        {
            get
            {
                return cars.Length;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CarsEnumerator(this);
            //return new CarsEnumerator(this);
            //return new CarsEnumerator(this);
            //return new CarsEnumerator(this);
        }

        public Car this[int x]
        {
            get { return cars[x]; }
        }

    }

    class CarsEnumerator : IEnumerator
    {
        private CarCatalog catalog;
        int position = -1;

        public CarsEnumerator(CarCatalog carCatalog)
        {
            catalog = carCatalog;
        }

        object IEnumerator.Current
        {
            get 
            {
                if(position == -1 || position >= catalog.Length) throw new IndexOutOfRangeException();
                else return catalog[catalog.Length - 1 - position];
            }
        }

        bool IEnumerator.MoveNext()
        {
            if (position < catalog.Length - 1)
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
