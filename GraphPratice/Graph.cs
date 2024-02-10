Gragh<int> intGraph = new Gragh<int>();
intGraph.AddNode(0, new Node<int>(5));
intGraph.AddNode(1, new Node<int>(3));
intGraph.AddNode(2, new Node<int>(7));
intGraph.AddNode(3, new Node<int>(32));
intGraph.AddNode(4, new Node<int>(4));
intGraph.AddNode(5, new Node<int>(2));
intGraph.AddNode(6, new Node<int>(5));
intGraph.AddNode(7, new Node<int>(2));

intGraph.LinkNode(0, 1);
intGraph.LinkNode(0, 2);
intGraph.LinkNode(1, 3);
intGraph.LinkNode(1, 6);
intGraph.LinkNode(2, 4);
intGraph.LinkNode(2, 5);
intGraph.PairNode(5, 7);
intGraph.LinkNode(7, 4);
Console.WriteLine("-----------DFS Start-----------");
intGraph.DFS(0);
Console.WriteLine("-----------BFS Start-----------");
intGraph.BFS(0);

public partial class Gragh<T>
{
    public Dictionary<int, Node<T>> NodeDictionary { get; private set; }

    public Gragh()
    {
        NodeDictionary = new Dictionary<int, Node<T>>();
    }

    public void AddNode(int keyIndex, Node<T> v)
    {
        NodeDictionary.Add(keyIndex, v);
        v.SetKey(keyIndex);
    }
    public void PairNode(int firstNode, int secondNode)
    {
        NodeDictionary[firstNode].Adjacent.Add(NodeDictionary[secondNode]);
        NodeDictionary[secondNode].Adjacent.Add(NodeDictionary[firstNode]);
    }

    public void LinkNode(int origin_Index, int link_Index)
    {
        NodeDictionary[origin_Index].Adjacent.Add(NodeDictionary[link_Index]);
    }

    public void UnlinkedNode(int origin_Index, int unlink_Index)
    {
        NodeDictionary[origin_Index].Adjacent.Remove(NodeDictionary[unlink_Index]);
    }
}
