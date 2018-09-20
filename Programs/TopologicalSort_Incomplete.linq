<Query Kind="Program" />

/*
Complete the below function which takes an arraylist and displays the list in the expected output
	 
	public class TreePrinter { 
	public static void printTree(Iterable<Relation> rs) { 
	// your code 
	
	} 
	} 
	
	public static class Relation { 
	String parent; 
	String child; 
	public Relation(String parent, String child) { ... } 
	} 
	} 
	
	Example input: 
	List<Relation> input = newArrayList(); 
	
	input.add(new Relation("animal", "mammal")); 
	input.add(new Relation("animal", "bird")); 
	input.add(new Relation("lifeform", "animal")); 
	input.add(new Relation("cat", "lion")); 
	input.add(new Relation("mammal", "cat")); 
	input.add(new Relation("animal", "fish")); 
	
	TreePrinter.printTree(input); 
	
	Expected output: 
	line 1: lifeform 
	line 2: animal 
	line 3: mammal 
	line 4: cat 
	line 5: lion 
	line 6: bird 
	line 7: fish
*/

void Main()
{
	List<Relation> input = new List<Relation>(); 
	
	input.Add(new Relation("animal", "mammal")); 
	input.Add(new Relation("animal", "bird")); 
	input.Add(new Relation("lifeform", "animal")); 
	input.Add(new Relation("cat", "lion")); 
	input.Add(new Relation("mammal", "cat")); 
	input.Add(new Relation("animal", "fish")); 
}

// Define other methods and classes here
public class TreePrinter 
{ 
	public class Node
	{
		string label;
		public Node(string label)
		{
			this.label = label;
		}
		
		public 
	}
	
	
	public static void printTree(IEnumerable<Relation> rs) 
	{ 
		// your code 
	
	}
} 

public class Relation 
{ 
	String parent; 
	String child; 
	public Relation(string parent, string child) 
	{ 
		this.parent = parent;
		this.child = child;
	} 
} 
