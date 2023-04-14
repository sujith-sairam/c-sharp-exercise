using System.Collections;
// Display odd and even Integers in separate arrays
Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.WriteLine("Enter the elements:");
for(int i=0;i<size;i++){
    Console.Write($"elements{i}:");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}
ArrayList odd = new ArrayList();
ArrayList even = new ArrayList();

for(int i=0;i<size;i++){
    if(array[i] % 2 ==0){
        even.Add(array[i]);
    }else{
        odd.Add(array[i]);
    }
}
Console.Write("Even elements of the array are : ");
for(int i=0;i<even.Count;i++){
    Console.Write(even[i] +" ");
}
Console.WriteLine();
Console.Write("Odd elements of the array are : ");
for(int i=0;i<odd.Count;i++){
    Console.Write(odd[i] +" ");
}


