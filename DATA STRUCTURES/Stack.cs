namespace DATA_STRUCTURES
{
    internal class Stack
    {
        public Stack()
        {
            Console.Write("Please enter a word you would like to reverse: ");           
            Console.WriteLine(Reverse(Validator.UserInput()));
        }

        private static string Reverse(string str)
        {
            string[] strArray = str.Split(' ');
            Stack<char> stack = new();
            string reversedString = string.Empty;
            foreach(var item in strArray)
            {
                item.ToCharArray().ToList().ForEach(stack.Push);
                
                for(int i = 0; i < item.Length; i++)
                {
                    reversedString += stack.Pop();
                }
                reversedString +=  " ";
            }
            return reversedString.Trim();
        }
    }
}
