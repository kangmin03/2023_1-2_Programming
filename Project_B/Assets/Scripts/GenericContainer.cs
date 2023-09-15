using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>  //���ʸ� ���� Class�� ���
{
    private T[] items;
    private int currentIndex = 0;

    public GenericContainer(int capacity)   //class�ּ� class �̸��� ���� �Լ��� ���� ������
    {
        items = new T[capacity];
    }

    public void Add(T item)  //�����̳ʿ� ���� �ִ´�
    {
        if(currentIndex < items.Length)   //�����̳� �迭 ĭ �̻� �� ��� ���´�
        {
            items[currentIndex] = item;   //���� ���� �迭�� �ִ´�.
            currentIndex++;      //�ε����� ������Ų��.
        }
    }

    public T[] GetItems()    //�迭�� ����
    {
        return items;
    }
}
