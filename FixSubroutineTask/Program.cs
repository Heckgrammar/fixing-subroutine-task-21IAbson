namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;i < 8; i++)      //counts up to 8 so the currency output can be given
            {
                //Console.WriteLine(Convert.ToString(i));     //checks the for loop works
                Console.WriteLine(diffCurrencies(i));
            }
        }
        static string diffCurrencies(int x)        //Outputs the currencies
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };
            return currencies[x];

        }



    }
}
