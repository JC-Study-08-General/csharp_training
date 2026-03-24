using System;

namespace Learning_CSharp
{
    internal class FizzBuzz
    {
        // by putting the rules in the interface it makes this extensible
        public interface IFizzBuzzRule
        {
            bool IsMatch(int number);
            string Result { get; }
        }

        // Single responsibility
        public class FizzRule : IFizzBuzzRule
        { 
            public bool IsMatch(int number) => number % 3 == 0;
            public string Result => "Fizz";
        }

        public class BuzzRule : IFizzBuzzRule
        {
            public bool IsMatch(int number) => number % 5 == 0;
            public string Result => "Buzz";
        }

        // Dependency Injection
        public class FizzBuzzRunner(IEnumerable<IFizzBuzzRule> rules)
        { 
            private readonly IEnumerable<IFizzBuzzRule> _rules = rules;

            public string GetOutput(int number)
            {
                var output = string.Concat(
                    _rules
                    .Where(r => r.IsMatch(number))
                    .Select(r => r.Result));

                return string.IsNullOrEmpty(output) ? number.ToString() : output;
            }
        }
    }
}
