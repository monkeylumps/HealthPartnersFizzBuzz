namespace FizzBuzzService
{
    public interface IFizzBuzzService
    {
        string GetFizzBuzzOutput(int number);

        IList<string> Run(int range);
    }
}