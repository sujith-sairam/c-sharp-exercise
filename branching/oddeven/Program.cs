//check a number is odd or even..

int number;

Console.WriteLine("Enter a number");
number = Convert.ToInt32(Console.ReadLine());

if(number%2==0){
    Console.WriteLine("Given number is even");
}else{
    Console.WriteLine("Given number is odd");
}