using System;

namespace TwoDMatrix
{
 class MultippicationOfMatrices{   
public static void Main(string[] args){

Console.WriteLine("Enter the rows and columns for the first matrix:");
Console.Write("Enter the row:");
int rowOfMatrix_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column:");
int colOfMatrix_1 = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = new int[rowOfMatrix_1,colOfMatrix_1];

Console.WriteLine("Enter the rows and columns for the second matrix:");
Console.Write("Enter the row:");
int rowOfMatrix_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column:");
int colOfMatrix_2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixTwo = new int[rowOfMatrix_2,colOfMatrix_2];

Console.WriteLine("Input elements in the first matrix:");
for(int row=0;row<rowOfMatrix_1;row++){
    for(int col=0;col<colOfMatrix_1;col++){
        Console.Write($"element - [{row}][{col}] :");
        matrixOne[row,col] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Input elements in the second matrix:");
for(int row=0;row<rowOfMatrix_2;row++){
    for(int col=0;col<colOfMatrix_2;col++){
        Console.Write($"element - [{row}][{col}] :");
        matrixTwo[row,col] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("The first matrix is :");
for(int row=0;row<rowOfMatrix_1;row++){
    for(int col=0;col<colOfMatrix_1;col++){
        Console.Write(matrixOne[row,col] +  " ");
    }
    Console.WriteLine();
}

Console.WriteLine("The second matrix is :");
for(int row=0;row<rowOfMatrix_2;row++){
    for(int col=0;col<colOfMatrix_2;col++){
        Console.Write(matrixTwo[row,col] +  " ");
    }
    Console.WriteLine();
}

if(rowOfMatrix_1 != colOfMatrix_2){
    Console.WriteLine("Matrix multiplication is not possible");
}else{
    int[,] resultMatrix = new int[rowOfMatrix_1,colOfMatrix_2];
    for(int row=0;row<rowOfMatrix_1;row++){
        for(int col=0;col<colOfMatrix_2;col++){
            resultMatrix[row,col] = 0;
            for(int k=0;k<rowOfMatrix_1;k++){
                resultMatrix[row,col] += matrixOne[row,k] * matrixTwo[k,col];
            }
        }
    }
    Console.WriteLine("The Multipication Result matrix is: ");
    for(int row=0;row<rowOfMatrix_1;row++){
    for(int col=0;col<colOfMatrix_2;col++){
        Console.Write(resultMatrix[row,col] +  " ");
    
    }
    Console.WriteLine();
}
}
        }
    }
}