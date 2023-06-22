namespace FizzBuzzService
{
    internal interface IFizzBuzzRule
    {
        bool IsMatch(int number);

        string GetOutput();
    }
}