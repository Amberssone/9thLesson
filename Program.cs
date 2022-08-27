// 9 Урок 
 /* 2 Задание 

 {
     
    static int SUM(int n, int m)
    {
         
        if (m == 1)
            return (n * (n + 1) / 2);
     
        int sum = SUM(n, m - 1);
         
        return (sum * (sum + 1) / 2);
    }
    
    public static void Main()
    {
         
        int n = 5;
        int m = 3;
         
        Console.Write("SUM(" + n + ", "
                       + m + "): " + SUM(n, m));
    }
}
*/

/* 3 Задание 

{
     static int ack(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if((m > 0) && (n == 0))
        {
            return ack(m - 1, 1);
        }
        else if((m > 0) && (n > 0))
        {
            return ack(m - 1, ack(m, n - 1));
        }else
        return n + 1;
    }
 
    public static void Main()
    {
         
        Console.WriteLine(ack(1, 2));
    }
}
 
*/


