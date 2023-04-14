// print n according to m value

int m,n;

Console.WriteLine("Enter a number");
m = Convert.ToInt32(Console.ReadLine());

if(m==0){
    n=0;
}else if(m>0){
    n=1;
}else{
    n=-1;
}

Console.WriteLine(n);

