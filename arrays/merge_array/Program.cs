using System;

namespace Array{

    class MergeArray{

        public static void Main( string[] args){
            //Merge two arrays and display it as single sorted array..

int size1,size2,size3;
Console.Write("Enter the size of the first array:");
size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the size of the second array:");
size2 = Convert.ToInt32(Console.ReadLine());
size3 = size1+size2;

int[] arr1 = new int[size1];
int[] arr2 = new int[size2];
int[] arr3 = new int[size3];

Console.WriteLine("Enter the elements for 1st array:");
for(int i=0;i<size1;i++){
    arr1[i] = Convert.ToInt32(Console.ReadLine());
    arr3[i] = arr1[i];
}

Console.WriteLine("Enter the elements for 2st array:");
for(int i=0;i<size2;i++){
    arr2[i] = Convert.ToInt32(Console.ReadLine());
    arr3[size1+i] = arr2[i];
}

for(int i=0;i<size3-1;i++){
    if(i<=size1-1){
        arr3[i] = arr1[i];
    }else{
        arr3[i] = arr2[i-size1];
    }
}

for(int i=0;i<size3-1;i++){
    for(int j=i+1;j<size3;j++){
        if(arr3[i]>arr3[j]){
            int temp = arr3[i];
            arr3[i] = arr3[j];
            arr3[j] = temp;
        }
    }
}
Console.WriteLine("The sorted elements of the merge array are:");
for(int i=0;i<size3;i++){
   
Console.Write(arr3[i] + " ");
}
        }
    }
}