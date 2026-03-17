using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class TestLinkedList<T>
{
    private SinglyLinkedListNode<T> head; //해드 뭔데 해드가 뭘 가르키는건데

    public void Add(SinglyLinkedListNode<T> newNode) //추가
    {
        if(head == null) //해드가 널 값이면
        {
            head = newNode; //해드는 뉴노드
        }
        else //가 아니면
        {
            var current = head; //무슨 값인지는 모르겠으나 커런트는 해드
            while (current != null && current.Next != null) //커런트가 널 값이 아니고, 커런트넥스트가 널 값이 아닌 동안
            {
                current = current.Next; //커런트는 커런트넥스트다.
            }
            current.Next = newNode; //딱 여기까지 흐름만 이해함.
        }
    }
    public void AddAfter(SinglyLinkedListNode<T> current, SinglyLinkedListNode<T> newNode)
    {
        if (head == null || current == null || newNode == null) //해드가 널 값이거나, 커런트가 널 값이거나, 뉴노드가 널 값이면
        {
            //알아서 서비스 내로 에러 수정 (수정 안되면 그 때 에러남
            throw new InvalidOperationException(); //이거 뭔데 인발리드오퍼래이션익셉션 뭔데 이거 여전히 모르겠어 이거 뭔데 ㅆㅂ 어쩌자고 어쩔까
        }
        newNode.Next = current.Next; //뭔데 ㅜ왜 뉴노드 넥스트가 커런트노드넥스트인데 이거 뭔데
        current.Next = newNode; // 뭐 어쩌자고 왜 갑자기 커런트노드넥스트는 뉴노드인데 어떡하자고
    }
    public void Remove(SinglyLinkedListNode<T> removeNode)
    {
        if (head == null || removeNode == null) //해드가 널 값이거나 리무브노드가 널 값이면
        {
            return;
        }
        if (removeNode == head) //걍 여기서 부터는 어떻게 생각해야할지조차 감이 잡히지 않음.
        {
            head = head.Next; //해드는 해드넥스트
            removeNode = null; //리무브노브는 널이다.
        }
        else
        {
            var current = head; //무슨 값인지는 모르겠지만 커런트는 해드

            while (current != null && current.Next !=  removeNode) //커런트가 널 값이 아니고, 커런트 넥스트가 리무드노드가 아닌 동안
            {
                current = current.Next; //커런트는 커런트넥스트
            }
            if (current != null) //커런트가 널 값이 아니면
            {
                current.Next = removeNode.Next; //커런트넥스트는 리무브노드넥스트
                removeNode = null; //리무브노드는 널
            }
        }
    }
    public SinglyLinkedListNode<T> GetNode(int index) //노드 받아오기.
    {
        var current = head; //무슨 값인지 모르겠으나 일단 커런트는 해드다.
        for (int i = 0; i < index && current != null; i++) //i는 인텍스보다 작고 커런트가 널값이 아니게 일단 늘어남.
        {
            current = current.Next; //커런트는 커런트넥스트
        }
        return current; //커런트로 돌아간다.
    }
    public int Count()
    {
        int cnt = 0; //일단 카운트는 0

        var current = head; // 무슨 값인지는 모르겠으나 일단 커런트는 해드다.
        while (current != null) //커런트가 널값이 아닌 동안
        {
            cnt++; //카운트가 늘고
            current = current.Next; //커런트는 커런트넥스트가 된다.
        }
        return cnt; //다 돌고나면 0으로 돌아감.
    }
    //포기를 포기한다. 이야 포기를 포기한다니 [ 포기하는 것을 포기하다 X , 포기+포기 = 울트라매지컬맥시멈포기 O ]
}
