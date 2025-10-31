public class BFS
{
    public void UseQueue(int[,] graph, int startIndex, int nodeCount)
    {
        Queue<int> graphQueue = new Queue<int>();
        bool[] visited = new bool[nodeCount];

         Console.Write($"{startIndex} -> ");
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            if (startIndex == graph[i, 0])
            {
                graphQueue.Enqueue(graph[i, 1]);
            }
        }

        while (graphQueue.Count > 0)
        {
            int currentNode = graphQueue.Dequeue();

            if (visited[currentNode - 1]) continue;
            visited[currentNode - 1] = true;

            Console.Write($"{currentNode} -> ");

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (currentNode == graph[i, 0])
                {
                    graphQueue.Enqueue(graph[i, 1]);
                }
            }
        }
    }
}

public class Program
{
    static void Main()
    {
        int nodeCount = 7;
        int[,] graph =
        {
            {1,2},
            {1,3},
            {2,5},
            {3,4},
            {4,6},
            {5,7}
        };
        BFS dfs = new BFS();
        dfs.UseQueue(graph, 1, nodeCount);
    }
}