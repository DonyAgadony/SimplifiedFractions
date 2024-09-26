class Program
{
    public static void Main()
    {
        Console.WriteLine(Simplify("4/6"));
    }
    public static string Simplify(string OGFraction)
    {
        string[] fractions = OGFraction.Split('/');
        double UP = double.Parse(fractions[0]);
        double down = double.Parse(fractions[1]);
        for (double i = down; i > 0; i--)
        {
            if (UP % i == 0 && down % i == 0)
            {
                UP /= i;
                down /= i;
            }
        }
        return $"{UP}/{down}";

    }
}