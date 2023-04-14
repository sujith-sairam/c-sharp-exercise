//Display the unique elements in an array..
Console.Write("Input the number of elements to store in an array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for(int i=0;i<size;i++){
    Console.Write($"element-{i}:");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}
Console.WriteLine("The unique elements are:");
int flag=0,j=0;
for(int i=0;i<size;i++){
    for( j=0;j<i;j++){
        if(array[i]==array[j]){
            flag=1;
            break;
        }
    }
    if(flag==0)
        Console.WriteLine(array[i]);
}
