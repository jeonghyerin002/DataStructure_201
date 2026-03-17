using UnityEngine;
using System;

public class TestList<T>
{
    public int Count { get { return count;  } }

    private int capacity;
    private T[] items;
    private int count = 0;

    public void Add(T value)
    {
        if (count == capacity)
        {
            //크기 증가
        }
        items[count] = value;
        count++;
    }
    /*public T Get()
    {
        return T;
    }
    public bool Remove(T target)
    {
        while()
        {
            검색
        }
    }
    public int Find(T value)
    {
        return index;
    }*/
}
