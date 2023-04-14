// Reverse the array elements..

Console.Write("Input the number of elements to store in an array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for(int i=0;i<size;i++){
    Console.Write($"element-{i}:");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}

Console.WriteLine("The reversed elements are:");
for(int i=size-1;i>=0;i--){
    Console.WriteLine(array[i]);
}