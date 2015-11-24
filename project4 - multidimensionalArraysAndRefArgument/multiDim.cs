using System;

class multiDim
{
	static void Inc(ref int p)
	{
		p = p + 1;
	}
	static void Main()
	{
		//Rectangular arrays are create like this:
		int[,] marixR = new int[3,3];
		
		for(int y = 0; y < matrixR.GetLength(0); y++)
		{
			for(int x = 0; x < matrixR.GetLength(1); x++)
			{
				matrixR[x,y] = 3;
			}
		}
		
		//creating a rectangular array with known values
		int[,] matrixC = new int[,]
		{
			{0, 1, 2},
			{3, 4, 5},
			{6, 7, 8}
		};
		
		//jagged arrays
		//each inner array can be an arbitrary length
		int[][] matrixJ = new int[3][];
		
		for(int x = 0; x < matrixJ.Length; x++)
		{
			matrixJ[x] = new int[3];
			for(int y; y < matrixJ[x].Length; y++)
			{
				matrix[x][y] = 2;
			}
		}
		
		//creating a jagged array with known values
		int[][] matrixJC = new int[][]
		{
			new int[] {0,1,2},
			new int[] {3,4,5},
			new int[] {6,7,8,9}
		};
		
		//passing by reference
		int x = 8;
		Inc(ref x);
		Console.WriteLine(x); //x = 9
	}
}