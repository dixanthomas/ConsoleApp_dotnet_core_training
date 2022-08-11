

int numOne;
int numTwo;
int[] arr=new int[3];
Console.WriteLine("Enter two numbers to get the sum:");
try
{
    //arr[3] = 0;
    //numOne = Convert.ToInt32("inut");
    numOne = Convert.ToInt32(Console.ReadLine());
    numTwo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{numOne} + {numTwo} = {getSum(numTwo,numOne)}");
    Console.ReadKey();
}
catch (FormatException)
{
    Console.WriteLine("Invalid input (required input is a number)");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Index Out Of Range Exception");
}
catch(Exception ex)
{
    Console.WriteLine($"Message: {ex.Message}\nSource: {ex.Source}");
}

// Method
int getSum(int val1, int val2)
{
    return val1 + val2;
}