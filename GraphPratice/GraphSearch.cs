
public partial class Gragh<T>
{
    public void DFS(int v)
    {
        bool[] visited = new bool[NodeDictionary.Count];
        DFSUtil(v, visited);
    }

    private void DFSUtil(int index, bool[] visited)
    {
        visited[index] = true;
        Console.WriteLine($"visit index : {NodeDictionary[index].KeyIndex} true");
        foreach (var node in NodeDictionary[index].Adjacent)
        {
            if (!visited[node.KeyIndex]) DFSUtil(node.KeyIndex, visited);

            else Console.WriteLine($"visit index : {node.KeyIndex} ignore");
        }
    }

    public void BFS(int v)
    {
        bool[] visited = new bool[NodeDictionary.Count];

        Queue<int> queue = new Queue<int>();

        queue.Enqueue(v);

        while (queue.Count > 0)
        {
            int index = queue.Dequeue();
            if (!visited[index])
            {
                foreach (var node in NodeDictionary[index].Adjacent)
                {
                    queue.Enqueue(node.KeyIndex);
                }
                visited[index] = true;
                Console.WriteLine($"visit index : {NodeDictionary[index].KeyIndex} true");
            }
            else
            {
                Console.WriteLine($"visit index : {NodeDictionary[index].KeyIndex} ignore");
            }
        }
    }

}
