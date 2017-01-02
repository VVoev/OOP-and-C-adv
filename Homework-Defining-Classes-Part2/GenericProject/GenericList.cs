using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.GenericProject
{
    class GenericList<T> where T : IComparable,IComparable<T>
    {
        //Fields
        private const int InitialCapacity = 4;
        private int count;
        private int capacity;
        private T[] list;

        //Properties
        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value < InitialCapacity)
                    throw new ArgumentOutOfRangeException("Capacity can not be less than Initial Capacity, which is set to be at least 1.");
                else
                    this.capacity = value;
            }
        }

  

        public int Count
        {
            get { return this.count; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count can not be less than 0.");
                else
                this.count = value;
            }
        }

       

        //Indexer
        public T this[int index]
        {
            get
            {
                if(index<0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range exception.");
                }
                else
                {
                    return this.list[index];
                }
            }
        }

       

        //Constructor
        public GenericList(int capacity = InitialCapacity)
        {
            this.Capacity = capacity;
            this.Count = 0;
            this.list = new T[this.Capacity];
        }

        //Methods
        protected void DoubleCapacity()
        {
            //double the capacity when Count is half of the capacity
            T[] newlist = new T[this.Capacity];
            this.Capacity *= 2;
            for (int i = 0; i < this.Count; i++)
            {
                newlist[i] = this.list[i];
            }
            this.list = newlist;
        }
        public void Add(T element)
        {
            if (this.Count == this.capacity / 2)
            {
                DoubleCapacity();
            }
            this.Count++;
            this.list[this.Count - 1] = element;
        }
        public int IndexAt(T elem)
        {
            int count = -1;
            foreach (var item in list)
            {
                count++;
                if (item.CompareTo(elem) == 0)
                {
                    return count;
                }
            }
            throw new ArgumentOutOfRangeException("Such index do not exist");
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Can not insert element at this position, because it's outside of boundaries of current collection");
            }
            for (int i = this.Count - 1; i > index; i--)
            {
                this.list[i + 1] = this.list[i];
            }
            this.list[index] = element;
            this.Count++;
        }

        public T IndexOf(T elem)
        {
            int index = -1;
            foreach (var item in list)
            {
                index++;
                if (index.CompareTo(elem) == 0)
                {
                    return item;
                }
            }
            throw new ArgumentException("Do not exist");
        }
        public void RemoveAt(int index)
        {
            if(index<0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException("The give index is not valid");
            }
            else
            {
                for (int i = index+1; i < this.Count; i++)
                {
                    this.list[i - 1] = this.list[i];
                }
                this.Count--;
            }
        }
        public void Min()
        {
            T min = this.list[0];
            foreach (var item in list)
            {
                if (item.CompareTo(min)<0)
                {
                    min = item;
                }
            }
            Console.WriteLine(min);

        }
        public void Max()
        {
            T max = this.list[0];
            foreach (var item in list)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }

        public void Clear()
        {
            this.Capacity = InitialCapacity;
            this.Count = 0;
            this.list = new T[this.capacity];
        }

        public override string ToString()
        {
            string[] temp = new string[this.count];
            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = this.list[i].ToString();
            }

            return string.Join(", ", temp);
        }


    }
}
