using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>        //제너릭 형식 Class로 사용하기 위해서 선언
{
    private T[] items;                  
    private int currentIndex = 0;       

    public GenericContainer(int capacity)   
    {
        items = new T[capacity];
    }

    public void Add(T item)                
    {
       if(currentIndex < items.Length)      
       {
            items[currentIndex] = item;     
            currentIndex++;                 
       }
    }

    public T[] GetItems()                  
    {
        return items;
    }
}
