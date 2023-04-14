// determine in which quadrant the coordinate point lies..
int co1,co2;

    Console.Write("Input the value for X coordinate :");
    co1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the value for Y coordinate :");
    co2 = Convert.ToInt32(Console.ReadLine());

	if( co1 > 0 && co2 > 0)
	  Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n",co1,co2);
	else if( co1 < 0 && co2 > 0)
	  Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n",co1,co2);
	else if( co1 < 0 && co2 < 0)
	  Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n",co1,co2);
	else if( co1 > 0 && co2 < 0)
	  Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n",co1,co2);
	else if( co1 == 0 && co2 == 0)
	  Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n",co1,co2);