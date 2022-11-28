tes1 test = new tes1();
Console.WriteLine("Ciao, Mondo!, Io amo le divisioni! Eccone una: "); // tradotto
Console.WriteLine(test.divisione());
public class tes1
{
    int dividendo = 2;

    public int divisore = 12;
    public int divisione()
    {
        return (dividendo / divisore);
    }
}