namespace TheMenu.Helpers
{
    public static class ValidationsHelpers
    {
        public static string ChechIfValidString(string hint)
        {
            bool success = false;
            Console.Write(hint);
            string text;
            do
            {
                text = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("You must enter a valid input.");
                    Console.Write(hint);
                }
                else
                {
                    success = true;
                }
            } while (!success);

            return text;
        }
        public static uint CheckIfValidIntgeer(string hint)
        {
            do
            {
                string text = ChechIfValidString(hint);
                if(uint.TryParse(text, out uint value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("You must enter a valid input.");
                }
            } while (true);
        }
    }

   
}
