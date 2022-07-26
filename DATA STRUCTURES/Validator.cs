using System.Text.RegularExpressions;

namespace DATA_STRUCTURES
{
    internal class Validator
    {
        public static string UserInput()
        {
            var regexItem = new Regex("^[a-z A-Z]*$");

            string input = Console.ReadLine();
            if(regexItem.IsMatch(input))
            {
                return input;
            }
            return "ehT gnirts uoy deretne saw dilavni"; // Because I can
        }
    }
}
