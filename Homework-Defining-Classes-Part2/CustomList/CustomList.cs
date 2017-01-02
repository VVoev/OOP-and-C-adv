using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.CustomList
{
    class CustomList <T> where T : IComparable<T>
    {
        //Fields
        private const int initialCapacity= 16;
        private T[] elements;
        private int count;

        //Properties
        public int Count
        {
            get { return this.count; }
            private set
            {
                this.count = value;
            }
        }




        //Constructor
        public CustomList()
        {
            this.elements = new T[initialCapacity];
            this.Count = 0;
        }

        //Methods
        public void Add(T elem)
        {
            if (this.count == this.elements.Length - 1)
            {
                Resize();
            }
            this.elements[this.count] = elem;
            Count++;
        }

        public bool Contains(T elem)
        {
            bool isExisting = this.elements.Contains(elem) ? true : false;
            return isExisting;
        }

        public void Swap(int indexFirst,int indexSecond)
        {
            T temp = this.elements[indexFirst];
            this.elements[indexFirst] = this.elements[indexSecond];
            this.elements[indexSecond] = temp;
        }

        public int GreaterThan(T elem)
        {
            int count = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(elem) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Max()
        {
            T maxItem = this.elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(maxItem) > 0)
                {
                    maxItem = this.elements[i];
                }
            }
            return maxItem;
        }
        public T Min()
        {
            T minItem = this.elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(minItem) < 0)
                {
                    minItem = this.elements[i];
                }
            }
            return minItem;
        }

        public T Remove(int index)
        {
            T elements = this.elements[index];
            this.DecreaseElementsCount(index); 
            return elements;
        }
        public T this[int index]
        {
            get { return this.elements[index]; }
        }

        private void DecreaseElementsCount(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        private void Resize()
        {
            int currentLenght = this.elements.Length;
            T[] newElements = new T[currentLenght * 2];
            Array.Copy(this.elements, newElements, currentLenght);
            this.elements = newElements;
        }
    }
}
