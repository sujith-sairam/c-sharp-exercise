﻿// print the sum of 10 given inputs sum and average..
int i,n,sum=0;
	double avg;
	
	Console.Write("Input the 10 numbers : \n");
	for (i=1;i<=10;i++)
	{
                Console.Write("Number-{0} :",i);

        n= Convert.ToInt32(Console.ReadLine());		
		sum +=n;
	}
	avg=sum/10.0;
	Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n",sum,avg);