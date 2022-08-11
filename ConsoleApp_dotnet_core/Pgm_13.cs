int numOne;
int numTwo;
int result;
Console.WriteLine("Enter two numbers to get the sum");
try
{
numOne = Convert.ToInt32(Console.ReadLine());
numTwo = Convert.ToInt32(Console.ReadLine());
result = numOne + numTwo;
Console.WriteLine($"{numOne} + {numTwo} = {result}");
Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}