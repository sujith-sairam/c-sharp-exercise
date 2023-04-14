// check a candidate is eligible or not for admission..

int phy,che,mat;

    Console.Write("Input the marks obtained in Physics :");
    phy = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the marks obtained in Chemistry :");
    che = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the marks obtained in Mathematics :");
    mat = Convert.ToInt32(Console.ReadLine());
   Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n",mat+phy+che);
   Console.Write("Total marks of Maths and  Physics : {0}\n",mat+phy);

   if (mat>=65)
         if(phy>=55)
             if(che>=50)
	        if((mat+phy+che)>=180||(mat+phy)>=140)
	           Console.Write("The  candidate is eligible for admission.\n");
	        else
	          Console.Write("The candidate is not eligible.\n\n");
             else
	    Console.Write("The candidate is not eligible.\n\n");
         else
	   Console.Write("The candidate is not eligible.\n\n");
    else
     Console.Write("The candidate is not eligible.\n\n");
