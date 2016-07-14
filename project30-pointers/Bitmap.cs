using System;
using System.Drawing;


public static class bitmapExtender
{
	public static void PrintBmp(this int[,] arr)
	{
		int numRows = arr.GetLength(0);
		int numCols = arr.GetLength(1);
		for(int y = 0; y < numRows; y++)
		{
			for(int x = 0; x < numCols; x++)
			{
				Console.Write(arr[y,x].ToString() + " ");
			}
			Console.WriteLine("");
		}
	}
}



class Bitmap
{
	public static unsafe void Clear(int[,] bitmap)
	{
		//use pointers to clear the bitmap
		int length = bitmap.Length;
		
		//tell garabage collection to not move the bitmap
		fixed(int* b = bitmap)
		{
			//start at the start
			int * p = b;
			for(int i =0; i < length; i++)
			{
				//set the int to zero
				*p = 0;
				
				//move to the next int
				p++;
			}
		}
	}
	
	public static void Main()
	{
		int height = 20;
		int width = 20;
		int[,] bitmap = new int[width, height];
		for(int x = 0; x < height; x++)
		{
			for(int y = 0; y < width; y++)
			{
				bitmap[x,y] = x + y;
			}
		}
		
		Console.WriteLine("before");
		bitmap.PrintBmp();
		
		Clear(bitmap);
		
		Console.WriteLine("after");
		bitmap.PrintBmp();
	}
}