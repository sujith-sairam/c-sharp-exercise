//check two numbers are equal or not..

int number_1 ,number_2;

Console.WriteLine("Enter first number");
number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 == number_2){
    Console.WriteLine("Both numbers are equal ");
}else{
    Console.WriteLine("Both numbers are not equal");
}