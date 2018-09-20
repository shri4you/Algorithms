<Query Kind="Program">
  <Namespace>skmDataStructures.Graph</Namespace>
</Query>

void Main()
{
	Graph G = new Graph();
	G.AddNode(new Node("A", "A"));
	G.AddNode(new Node("B", "B"));
	G.AddNode(new Node("C", "C"));
	G.AddNode(new Node("D", "D"));
	G.AddNode(new Node("E", "E"));
	G.AddNode(new Node("F", "F"));
	G.AddDirectedEdge("A", "B");
	G.AddDirectedEdge("B", "C");
	G.AddDirectedEdge("C", "D");
	G.AddDirectedEdge("A", "D");
	G.AddDirectedEdge("D", "A");
	G.AddDirectedEdge("D", "E");
	DFS(G.Nodes["A"], new HashSet<Node>());
	//G.TopologicalSort();
}

static void DFS(Node node, HashSet<Node> visited)
{
	if(visited.Contains(node))
		return;
		
	visited.Add(node);
	node.Data.Dump();
	foreach(EdgeToNeighbor al in node.Neighbors)
	{
		DFS(al.Neighbor,visited);
	}
}