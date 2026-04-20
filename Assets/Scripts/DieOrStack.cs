using UnityEngine;
using System;
using Unity.VisualScripting;

public class DieOrStack<T>
{
    T[] items;
    int top;

    public int Count => top;//현재 스택이 들어있는 요소의 개수

    public DieOrStack(int capacity = 10) //스택 생성 시 초기 용량을 설정 (capacity : 용량)
    {
        items = new T[capacity];
        top = 0;
    }

    public void Push(T item) //데이터를 스택의 맨 위에 추가
    {
        if (top >= items.Length)
            Array.Resize(ref items, items.Length * 2); //배열이 꽉 찼다면 크기를 두 배로 늘림
                                                       //Array :한 번 크기를 정하면 절대 바꿀 없는 고정크기
                                                       //Array.Resize : 기존 배열의 두 배 크기를 가진 완전히 새로운 빈 배열 메모리를 다른 곳에 할당
                                                       //기존 열 칸짜리 배열에 있던 데이터들을 방금 만든 스무 칸짜리 새 배열로 옮겨담음
                                                       //기존 열 칸짜리 는 부수게 두고, items라는 이름으로 새로 만든 스무 칸짜리 배열로 방향을 틀어줌
        items[top] = item;
        ++top;
    }
    public T Pop() //스택의 맨 위 데이터를 꺼내고 반환
    {
        if (top == 0)
            throw new InvalidOperationException("스택이 비어 있습니다.");

        --top;
        T item = items[top];
        items[top] = default; //참조 타입일 경우 메모리가 새는 것을 방지하기 위해 빈자리로 만듦

        return item;
    }
    public T Peek() //스택의 맨 위 데이터를 제거하지 않고 반환
    {
        if (top == 0)
            throw new InvalidOperationException("스택이 비어 있습니다.");

        return items[top - 1];
    }
    public bool IsEmpty() //스택이 비어있는지 확인
    {
        return (top == 0);
    }
}
