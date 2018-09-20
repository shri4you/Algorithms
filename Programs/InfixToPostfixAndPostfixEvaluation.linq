<Query Kind="Program" />

void Main()
{
	SymbolPriorities.Add('+', 1); //lowest
	SymbolPriorities.Add('-', 1); //lowest
	SymbolPriorities.Add('*', 2); 
	SymbolPriorities.Add('/', 2); 
	SymbolPriorities.Add('(', 3); //highest
	SymbolPriorities.Add(')', 3); 
	
	InfixToPostfix("A*B-(C+D)+E");
	
	EvaluatePostfix("AB*CD+-E+");
}

// Define other methods and classes here

Dictionary<char,int> SymbolPriorities = new Dictionary<char,int>();

void InfixToPostfix(string infixExp)
{
	Stack<char> operators = new Stack<char>();
	
	foreach(char c in infixExp)
	{
		if(!SymbolPriorities.ContainsKey(c))
		{
			Console.Write(c);
		}
		else if(c == ')')
		{
			char c1;
			while(operators.Any())
			{
				c1 = operators.Pop();
				if(c1 == '(')
				{
					break;
				}
				else 
				{
					Console.Write(c1);
				}
			}
		}
		else
		{
			while(operators.Any() && SymbolPriorities[c] <= SymbolPriorities[operators.Peek()] && operators.Peek() != '(')
			{
				Console.Write(operators.Pop());
			}
			
			operators.Push(c);
		}
	}
	
	while(operators.Any())
	{
		Console.Write(operators.Pop());
	}
	
	Console.WriteLine();
}

public void EvaluatePostfix(string postfixExpression)
{
	Stack<string> resultStack = new Stack<string>();
	
	foreach(char c in postfixExpression)
	{
		if(SymbolPriorities.ContainsKey(c))
		{
			// need distinction between unary and binary operators
			// considering only binary for simplicity i.e. for unary pop one element instead of two.
			// actual evaluation will have number result, but adding "( )" here instead for understanding.
			var second = resultStack.Pop();
			var first = resultStack.Pop();
			string result = @"(" + first + c + second + @")";
			resultStack.Push(result);
		}
		else
		{
			resultStack.Push(c.ToString());
		}
	}
	
	Console.WriteLine(resultStack.Pop());
	
}


