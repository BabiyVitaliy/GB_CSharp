// Написать программу вычисления функции Аккермана - 5*

int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    else
      if (m>0 && n==0) return Akkerman(m-1,1);
        else
         //if (m>0 && n>0) 
         return Akkerman(m-1, Akkerman(m,n-1));
}

for(int m=0;m<4;m++)
    for(int n=0;n<5;n++)
        System.Console.WriteLine($"A({m},{n})={Akkerman(m,n)}");