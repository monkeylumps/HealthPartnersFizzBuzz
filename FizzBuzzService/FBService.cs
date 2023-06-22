using System.Reflection;

namespace FizzBuzzService
{
    public class FBService : IFizzBuzzService
    {
        private readonly List<IFizzBuzzRule> rules;

        public FBService()
        {
            rules = LoadFizzBuzzRules();
        }

        public IList<string> Run(int range)
        {
            var output = new List<string>();

            output = Enumerable.Range(1, range).Select(item => item.ToString()).ToList();

            return output;
        }

        public string GetFizzBuzzOutput(int number)
        {
            string output = string.Empty;

            foreach (var rule in rules)
            {
                if (rule.IsMatch(number))
                {
                    output += rule.GetOutput();
                }
            }

            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }

        private List<IFizzBuzzRule> LoadFizzBuzzRules()
        {
            var ruleTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(IFizzBuzzRule).IsAssignableFrom(type) && !type.IsInterface).Reverse();

            var rules = new List<IFizzBuzzRule>();

            foreach (var ruleType in ruleTypes)
            {
                var rule = Activator.CreateInstance(ruleType) as IFizzBuzzRule;
                rules.Add(rule);
            }

            return rules;
        }
    }
}