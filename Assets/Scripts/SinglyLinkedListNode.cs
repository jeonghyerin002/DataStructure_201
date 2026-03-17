using UnityEngine;

public class SinglyLinkedListNode<T> //여기 <T> 이거 뭔데 어쩌자고 이거 뭔데
{
    public T Data { get; set; }
    public SinglyLinkedListNode<T> Next {get; set;}
    public SinglyLinkedListNode(T Data)
    {
        this.Data = Data;
        this.Next = null;
    }
}
