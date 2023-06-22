namespace FizzBuzzService
{
    public interface IFizzBuzzService
    {
        int GetFizzBuzzOutput(int input);

        IList<string> Run(int range);
    }
}