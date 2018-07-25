using System;
using System.Collections.Generic;

public class NamesCount
{
    private int count;
    private Dictionary<string, int> counts = new Dictionary<string, int>();

    /// <summary>
    /// Adds the name.
    /// </summary>
    /// <param name="name">Name.</param>
    public void AddName(string name)
    {
        int nameCount;

        if (counts.TryGetValue(name, out nameCount))
        {
            counts[name] = nameCount + 1;
        }
        else
        {
            counts.Add(name, nameCount + 1);
        }

        count++;
    }

    /// <summary>
    /// Returns proportion of parameter name in all calls to AddName.
    /// </summary>
    /// <returns>Double in interval [0, 1]. Returns 0 if AddName has not been called.</returns>
    /// <param name="name">Name.</param>
    public double NameProportion(string name)
    {
        int nameCount;

        if (counts.TryGetValue(name, out nameCount))
            return ((double)(counts[name]) / (double)(count));
        else
            return 0.000d;
    }

    public static void Main(string[] args)
    {
        NamesCount namesCount = new NamesCount();

        namesCount.AddName("James");
        namesCount.AddName("John");
        namesCount.AddName("Mary");
        namesCount.AddName("Mary");

        Console.WriteLine("Fraction of Johns: {0}", namesCount.NameProportion("John"));
        Console.WriteLine("Fraction of Marys: {0}", namesCount.NameProportion("Mary"));
    }
}