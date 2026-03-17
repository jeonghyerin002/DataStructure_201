using UnityEngine;
using System;

public class TestQueue
{
    //단순화를 위해 object 데이터 타입 사용
    private object[] a;
    private int front;
    private int rear;

    //디폴트 큐 크기는 16이지만 지정가능
    public TestQueue(int queueSize = 16) //일단 큐를 최대로 지정
    {
        a = new object[queueSize]; //에이는 새로운 오브젝트 [큐사이즈]
        front = -1; //처음은 -1이다.
        rear = -1; //마지막은 -1이다
    }
    public void Enqueue(object data) 
    {
        //큐가 가득 차있는지 체크
        if ((rear + 1) % a.Length == front) //최대 값보다 +1 되면 
        {
            throw new ApplicationException("Full"); //안됨
        }
        else
        {
            //비어있는 경우
            if (front == -1) //처음이 -1이면
            {
                front++; // +1 늘어난다 
            }
            
            //데이터 추가
            rear = (rear + 1) % a.Length; //이건 모르겠슨 해석 안됨 하나도 이해 안됨 이거 이해한거 아니네 하나도 모르겠어 이거 어쩌자고 나 뭐 어떡하라고
            a[rear] = data;
        }
    }
    public object Dequeue()
    {
        //큐가 비어있는지 체크
        if (front == -1 && rear == -1) //처음이 -1이고, 마지막이 -1이면
        {
            throw new ApplicationException("Empty"); //비어있음.
        }
        else
        {
            //데이터 읽기
            object data = a[front]; //오브젝트 데이터는 처음상태

            //마지막 요소를 읽은 경우
            if (front == rear) //한바퀴 돌면
            {
                //특수값 -1로 설정
                front = -1; //처음은 -1이 되고
                rear = -1; //마지막은 -1이 된다. 사실상 리셋?
            }
            else //안 돌았으면
            {
                //front 이동
                front = (front + 1) % a.Length; //다시 돌려
            }
            return data; //데이터로 돌아간..다?
        }
    }
}
