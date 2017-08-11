using System.Collections.Generic;

namespace Practice
{
    public class AddElectricalWires
    {
        public static int maxNewWires(string[] wires, int[] gridConnections)
        {
            // For each connection to the main grid perform a DFS from
            // that node to all connected nodes.  Track clique size and
            // members.
            var visited = new bool[wires.Length];
            var cliques = new List<List<int>>();
            foreach (int gridConnect in gridConnections)
            {
                var nodes = Dfs(gridConnect, wires);
                cliques.Add(nodes);
                foreach (var node in nodes)
                {
                    visited[node] = true;
                }
            }

            // Find remaining nodes that are not connected to main grid.
            //
            // Add the remaining nodes to the largest (possibly empty) of the
            // main grid connected cliques.
            //
            // NOTE: This would be a good case to test other codes on.  They
            // may fail to add the non-main grid clique to the largest of the
            // connected groups.
            List<int> largestClique = new List<int>();
            foreach (var clique in cliques)
            {
                if (clique.Count > largestClique.Count)
                {
                    largestClique = clique;
                }
            }
            for (var i = 0; i<visited.Length; i++)
            {
                if (!visited[i])
                {
                    largestClique.Add(i);
                }
            }

            // For each clique add as many wires as needed to create a fully
            // connected graph.
            var totalWires = 0;
            foreach (var clique in cliques)
            {
                totalWires += CliqueEdgeCount(clique.Count);
            }

            // Discunt wires that are currently in the network.
            var currentWires = 0;
            foreach (var connections in wires)
            {
                foreach (var c in connections)
                {
                    if (c == '1')
                    {
                        currentWires += 1;
                    }
                }
            }
            currentWires /= 2;

            return totalWires - currentWires;
        }

        private static int CliqueEdgeCount(int count)
        {
            int n = count - 1;
            var totalEdges = ((n + 1) * n) / 2;
            return totalEdges;
        }

        private static List<int> Dfs(int gridConnect, string[] wires)
        {
            var workList = new Queue<int>(new int[] { gridConnect });
            var clique = new List<int>();

            while (workList.Count > 0)
            {
                var node = workList.Dequeue();
                clique.Add(node);
                var links = wires[node];
                for (int i = 0; i < links.Length; i++)
                {
                    if (links[i] == '1')
                    {
                        // TODO: Optimize by storing this as an array.
                        if (!clique.Contains(i))
                        {
                            workList.Enqueue(i);
                        }
                    }
                }
            }

            return clique;
        }
    }
}
