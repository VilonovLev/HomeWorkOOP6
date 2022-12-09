

class Solution 
{
    public static void Main(string[] args)
    {
        Stack<int> stackNumbers = new Stack<int>();
        Stack<String> stackSimbols = new Stack<String>();

    string inputString;
        while ((inputString = Console.ReadLine()) != "exit")
        {
            if (int.TryParse(inputString, out _))
            {
                stackNumbers.Push(int.Parse(inputString));
            }
            else if (CurrentSimbol(inputString))
            {
                stackSimbols.Push(inputString);
            }
            else
            {
                continue;
            }

            if( stackNumbers.Count > 1 && stackSimbols.Count > 0)
            {
                int result = Calculate();
                stackNumbers.Push(result);
                Console.WriteLine($"Результат {result}");
            }

        }

        int Calculate()
        {
            int second = stackNumbers.Pop();
            int first = stackNumbers.Pop();
            String result = first + stackSimbols.Pop() + second;
            return Convert.ToInt32(new System.Data.DataTable().Compute(result, null));
        }

        bool CurrentSimbol(string? input)
        {
            return (input.Equals("*") || input.Equals("+") || input.Equals("-") || input.Equals("/"));
        }

    }

   
}