// display the count of duplicate numbers in an array..\\
Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;

Console.WriteLine("Enter the elements:");
for(int i=0;i<size;i++){
    Console.Write($"elements{i}:");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}
for(int i=0;i<size-1;i++){
    for(int j=i+1;j<size;j++){
        if(array[i]==array[j]){
            count++;
        }
    }
}
Console.WriteLine($"The count of the duplicate elements are:{count}");