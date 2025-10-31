public class DFS
{
    public void UseStack(int[,] graph, int startIndex, int nodeCount)
    {
        Stack<int> graphStack = new Stack<int>();
        bool[] visited = new bool[nodeCount];

        Console.Write($"{startIndex} -> ");
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            if (startIndex == graph[i, 0])
            {
                graphStack.Push(graph[i, 1]);
            }
        }

        while (graphStack.Count > 0)
        {
            int currentNode = graphStack.Pop();

            if (visited[currentNode - 1]) continue;
            visited[currentNode - 1] = true;

            Console.Write($"{currentNode} -> ");

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (currentNode == graph[i, 0])
                {
                    graphStack.Push(graph[i, 1]);
                }
            }
        }
    }
    public void UseRecursion(int[,] graph, int index, int nodeCount)
    {
        bool[] visited = new bool[nodeCount];
        Console.Write($"{index} -> ");
        for(int i = 0; i < graph.GetLength(0); i++)
        {
            if(graph[i,0] == index)
            {
                RecurstionDFS(graph, graph[i, 1], visited);
            }
        }
    }
    private void RecurstionDFS(int[,] graph, int index, bool[] visited)
    {
        if (visited[index - 1]) return;
        visited[index - 1] = true;
        Console.Write($"{index} -> ");
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            if(graph[i,0] == index)
            {
                RecurstionDFS(graph, graph[i,1], visited);
            }
        }
    }
}



// public class Program
// {
//     static void Main()
//     {
//         int nodeCount = 7;
//         int[,] graph =
//         {
//             {1,2},
//             {1,3},
//             {2,5},
//             {3,4},
//             {4,6},
//             {5,7}
//         };
//         DFS dfs = new DFS();
//         dfs.UseStack(graph, 1, nodeCount);
//         Console.WriteLine();
//         dfs.UseRecursion(graph , 1 , nodeCount);
//     }
// }