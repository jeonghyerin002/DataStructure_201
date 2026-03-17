using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class TestLinkedList<T>
{
    private SinglyLinkedListNode<T> head;

    public void Add(SinglyLinkedListNode<T> newNode)
    {
        if(head == null)
        {
            head = newNode;
        }
        else
        {
            var current = head;
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode; //딱 여기까지 흐름만 이해함.
        }
    }
    public void AddAfter(SinglyLinkedListNode<T> current, SinglyLinkedListNode<T> newNode)
    {
        if (head == null || current == null || newNode == null)
        {
            throw new InvalidOperationException(); //이거 뭔데 인발리드오퍼래이션익셉션 뭔데 이거
        }
        newNode.Next = current.Next; //뭔데 ㅜ왜 뉴노드 넥스트가 커런트노드넥스트인데 이거 뭔데
        current.Next = newNode; // 뭐 어쩌자고 왜 갑자기 커런트노드넥스트는 뉴노드인데 어떡하자고
    }
    public void Remove(SinglyLinkedListNode<T> removeNode)
    {
        if (head == null || removeNode == null)
        {
            return;
        }
        if (removeNode == head) //걍 여기서 부터는 어떻게 생각해야할지조차 감이 잡히지 않음.
        {
            head = head.Next;
            removeNode = null;
        }
        else
        {
            var current = head;

            while (current != null && current.Next !=  removeNode)
            {
                current = current.Next;
            }
            if (current != null)
            {
                current.Next = removeNode.Next;
                removeNode = null;
            }
        }
    }
    public SinglyLinkedListNode<T> GetNode(int index)
    {
        var current = head;
        for (int i = 0; i < index && current != null; i++)
        {
            current = current.Next;
        }
        return current;
    }
    public int Count()
    {
        int cnt = 0;

        var current = head;
        while (current != null)
        {
            cnt++;
            current = current.Next;
        }
        return cnt;
    }
    //포기를 포기한다. 이야 포기를 포기한다니 [ 포기하는 것을 포기하다 X , 포기+포기 = 울트라매지컬맥시멈포기 O ]
}
