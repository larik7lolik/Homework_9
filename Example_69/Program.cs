//Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
//M = 1; N = 4 -> 10
//M = 4; N = 8. -> 30


int SumRec(int m, int n)
{
    if(m == n) return 1;
    else return m + SumRec(m, n-1);
}
Console.WriteLine(SumRec(1, 10));


/* void Numbers(int m, int n)
{
    if (m < n)
    {
        FindSum(m, n);
    }

}
void FindSum(int m, int n)
{
    int sum = m;
    while (m < n)
    {
        m++;
        sum = sum + m;
    }
    Console.Write(sum);
}

Numbers(1, 4);
Console.WriteLine();
Numbers(4, 8);
 */





