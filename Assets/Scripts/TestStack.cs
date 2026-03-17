using UnityEngine;
using System;
using System.Runtime.InteropServices.WindowsRuntime;


public class TestStack
{
    private object[] a;
    private int top;

    public TestStack(int capacity = 16) //용량은 16
    {
        a = new object[capacity]; //a는 뉴 오브젝트[용량]
        top = -1; //처음은 -1
    }
    public void Push(object data)
    {
        if (top == a.Length - 1) //처음이 a.Length -1이면
        {
            //throw 하거나 아래처럼 배열 확장
            ResizeStack();
        }
        a[++top] = data; //이거 뭐야 왜 ++이 앞에 있어 나 이거 안쓴단 말이야 이거 어쩌자고 나보고 어떡하고 어떡하라고!!!!!!!!!!!!!!!!!!
    }
    private void ResizeStack()
    {
        int capacity = 2 * a.Length; //int 용량은 2 * a.Length
        var tempArray = new object[capacity]; //무슨 값인지는 모르겠으나 임시저장은 뉴오브젝트[용량]
        Array.Copy(a, tempArray, a.Length); //와 진짜 이거 에바다 나 이거 어케해 그냥 죽기직전이라고 보는데 이거 뭐 어쩌자는거지 너 뭐하는 애니 썅
        a = tempArray; //a는 int로 생성한 임지저장
    }
    public object Pop() //터트리라고? 뭘 학교를? 아니면 ㅆ비ㅏㄹ 비주얼스튜디오를?!?!?!??!?!?!???????????
    {
        if (this.IsEmpty) //이 객체가 비어있는지 bool 값으로 확인
        {
            throw new ApplicationException("Empty"); //던져
        }
        return a[top--]; //어쩌자고
    }
    public object Peek() //이거 뭔데 생긴건 돼지고기같은데
    {
        if (this.IsEmpty) //이 객체가 비어있는지 bool 값으로 확인
        {
            throw new ApplicationException("Empty"); //던져
        }
        return a[top];//어쩌자고
    }
    public bool IsEmpty //비어있는지 확인하는 bool값 함수로 생성
    {
        get { return top == -1; } //이거 뭔데 어쩌자고
    }
    public int Capacity //용량
    {
        get { return a.Length; } //뭐 어쩌자고 나 뭐 어떡하라고 뭐하라고 어쩌자고 이거 뭐 어떡하라고 나보고 뭘 하라고 교수님 제발 살려주세요 저 이대로 컥 (사망)
    }
}
