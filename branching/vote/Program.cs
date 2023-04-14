//check a person is eligible to vote or not..

int age;

Console.WriteLine("Enter the age:");
age = Convert.ToInt32(Console.ReadLine());



if(age>=18){
    Console.WriteLine("Candidate is eligible to vote");
}else{
    Console.WriteLine("Candidate is not eligible to vote");
}