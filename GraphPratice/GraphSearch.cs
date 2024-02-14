
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
        Console.WriteLine($"visit index : {NodeDictionary[index].Index} true");
        foreach (var node in NodeDictionary[index].Adjacent)
        {
            if (!visited[node.Index]) DFSUtil(node.Index, visited);

            else Console.WriteLine($"visit index : {node.Index} ignore");
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
                    queue.Enqueue(node.Index);
                }
                visited[index] = true;
                Console.WriteLine($"visit index : {NodeDictionary[index].Index} true");
            }
            else
            {
                Console.WriteLine($"visit index : {NodeDictionary[index].Index} ignore");
            }
        }
    }

}
