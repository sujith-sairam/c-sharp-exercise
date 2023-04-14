// print the cube of the series untill the given value..

int i,ctr;
	
    Console.Write("Input number of terms : ");
    ctr= Convert.ToInt32(Console.ReadLine());	
    for(i=1;i<=ctr;i++)
    {
	 Console.Write($"Number is : {i} and cube of the {i} is :{i*i*i} \n");     
    }