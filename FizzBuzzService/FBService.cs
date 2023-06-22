using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public string GetFizzBuzzOutput(int number)
        {
            string output = string.Empty;

            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }
    }
}