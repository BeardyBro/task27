int number = ReadLine();
int ReadLine()
{
Console.WriteLine("Input a number");
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
return result;
}
int Sum(int number)
{
int result=0;
while (number>0)
{
    result +=number%10;
    number = number/10;
}
return result;
}
Console.WriteLine($"Sum of all digits in {number} = {Sum(number)}");