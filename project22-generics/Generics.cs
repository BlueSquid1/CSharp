using System;


public interface StackI<T>
{
	void Push(T obj);
	T Pop();
}
	
public class Stack<T> : StackI<T>
{
	private int pos = 0;
	private T[] data = new T[100];
	
	//constructor
	public Stack()
	{
		//set all data points to their default value
		for(int i = 0; i < this.data.Length; i++)
		{
			data[i] = default(T);
		}
	}
		
	public void Push(T obj)
	{
		data[pos] = obj;
		pos++;
	}
	
	public T Pop()
	{
		pos--;
		return data[pos];
	}
}

class Generics
{	
	public static void Main()
	{
		Stack<int> dataBase = new Stack<int>();
		dataBase.Push(5);
		dataBase.Push(2);
		Console.WriteLine(dataBase.Pop()); //2
		Console.WriteLine(dataBase.Pop()); //5
	}
}