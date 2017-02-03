using System;

public class GenericList<T>
{
    const int DefaultCapacity = 4096;

    private T[] elements;
    private int count = 0;

    public int Count
    {
        get { return this.count; }
    }


    public GenericList(int capacity)
    {
        elements = new T[capacity];
    }
    public GenericList():this(DefaultCapacity)
    {

    }


    public void Add(T elementh)
    {
        if (count > elements.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
            "The list capacity of {0} was exceeded.", elements.Length));
        }
        this.elements[count] = elementh;
        count++;
    }

    public T this [int index]
    {
        get
        {
            if (index > count)
            {
                throw new IndexOutOfRangeException(String.Format("INVALID INDEX: {0}.", index));
            }
            T result = elements[index];
            return result;
        }
    }
}