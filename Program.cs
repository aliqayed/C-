// See https://aka.ms/new-console-template for more information
Console.Write(" enter nummber = ");
int number =int .Parse(Console.ReadLine());
int SUM = 0;

for (int i = 1; i <= 10; i++)
{
    if ((number != i)&& number % i == 0)
    {
        Console.WriteLine($" {number} % {i} == 0");
        SUM += i;
        
    }
    
}

if (SUM == number) {

    Console.WriteLine($"number is premtive nummber is  =  {SUM}");

}

else {
    Console.WriteLine($"Nummber =  {number}  Is NOT premtive "); 
}
