//check a number is leapyear or  not..

int Year;

Console.WriteLine("Enter the  year:");
Year = Convert.ToInt32(Console.ReadLine());



if(((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)){
    Console.WriteLine("Given year is leap year");
}else{
    Console.WriteLine("Given year is not an leap year");
}