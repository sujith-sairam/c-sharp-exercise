//categorize the height of a person..

float height ;

Console.WriteLine("Height of the person:");
    height = Convert.ToInt32(Console.ReadLine());
 
    if (height < 150.0)
        Console.WriteLine("The person is Dwarf.");
    else if ((height >= 150.0) && (height <= 165.0))
       Console.WriteLine("The person is  average heighted.");
    else if ((height >= 165.0) && (height <= 195.0))
        Console.WriteLine("The person is taller.");
    else
        Console.WriteLine("Abnormal height.");