using System;

namespace TwoDMatrix
{
 class SumOfMatrices{   
public static void Main(string[] args){

Console.Write("Enter the size for the matrices:");
int sizeOfMatrix = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = new int[sizeOfMatrix,sizeOfMatrix];
int[,] matrixTwo = new int[sizeOfMatrix,sizeOfMatrix];

Console.WriteLine("Input elements in the first matrix:");
for(int row=0;row<sizeOfMatrix;row++){
    for(int col=0;col<sizeOfMatrix;col++){
        Console.Write($"element - [{row}][{col}] :");
        matrixOne[row,col] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Input elements in the second matrix:");
for(int row=0;row<sizeOfMatrix;row++){
    for(int col=0;col<sizeOfMatrix;col++){
        Console.Write($"element - [{row}][{col}] :");
        matrixTwo[row,col] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("The first matrix is :");
for(int row=0;row<sizeOfMatrix;row++){
    for(int col=0;col<sizeOfMatrix;col++){
        Console.Write(matrixOne[row,col] +  " ");
    }
    Console.WriteLine();
}

Console.WriteLine("The second matrix is :");
for(int row=0;row<sizeOfMatrix;row++){
    for(int col=0;col<sizeOfMatrix;col++){
        Console.Write(matrixTwo[row,col] +  " ");
    }
    Console.WriteLine();
}

Console.WriteLine("The addition of two matrices is :");
for(int row=0;row<sizeOfMatrix;row++){
    for(int col=0;col<sizeOfMatrix;col++){
        Console.Write(matrixOne[row,col] + matrixTwo[row,col] +  " ");
    }
    Console.WriteLine();
}
        }
    }
}