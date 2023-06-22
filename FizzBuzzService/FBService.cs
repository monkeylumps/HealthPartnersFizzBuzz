namespace FizzBuzzService
{
    public class FBService : IFizzBuzzService
    {
        public IList<string> Run(int range)
        {
            var output = new List<string>();

            output = Enumerable.Range(1, range).Select(item => item.ToString()).ToList();

            return output;
        }
    }
}