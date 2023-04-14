// Display the sum of the array elements..

Console.Write("Input the number of elements to store in an array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for(int i=0;i<size;i++){
    Console.Write($"element-{i}:");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}
int sum=0;
for(int i=0;i<size;i++){
    sum += array[i];
}
Console.WriteLine($"The sum of the elements are:{sum}");