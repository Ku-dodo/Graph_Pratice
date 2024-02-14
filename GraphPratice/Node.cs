public class Node<T>
{
    public int Index { get; private set; }
    public T Data { get; private set; }
    public List<Node<T>> Adjacent = new List<Node<T>>();

    public Node(T data)
    {
        Data = data;
    }

    public void SetKey(int index)
    {
        Index = index;
    }

    public void SetData(T data)
    {
         Data = data;
    }
}