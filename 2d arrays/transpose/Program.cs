using System;

namespace TwoDMatrix
{
 class TransposeOfMatrix{   
public static void Main(string[] args){

Console.WriteLine("Enter the row and column for the matrices:");
Console.Write("row:");
int matrix_row = Convert.ToInt32(Console.ReadLine());
Console.Write("col:");
int matrix_column = Convert.ToInt32(Console.ReadLine());
int[,] Normal_Matrix = new int[matrix_row,matrix_column];
int[,] Transpose_Matrix = new int[matrix_column,matrix_row];

Console.WriteLine("Input elements in the matrix:");
for(int row=0;row<matrix_row;row++){
    for(int col=0;col<matrix_column;col++){
        Console.Write($"element - [{row}][{col}] :");
        Normal_Matrix[row,col] = Convert.ToInt32(Console.ReadLine());
    }
}

for(int row=0;row<matrix_column;row++){
    for(int col=0;col<matrix_row;col++){
        Transpose_Matrix[row,col] = Normal_Matrix[col,row];
    }
}

Console.WriteLine("The Normal matrix is :");
for(int row=0;row<matrix_row;row++){
    for(int col=0;col<matrix_column;col++){
        Console.Write(Normal_Matrix[row,col] +  " ");
    }
    Console.WriteLine();
}

Console.WriteLine("The Transpose matrix is :");
for(int row=0;row<matrix_column;row++){
    for(int col=0;col<matrix_row;col++){
        Console.Write(Transpose_Matrix[row,col] +  " ");
    }
    Console.WriteLine();
}


        }
    }
}