using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // Convert the string to lowercase, filter out non-letter characters, and check for duplicates
        var letters = word
            .ToLower()
            .Where(char.IsLetter);

        // Check if the number of unique letters matches the total letter count
        return letters.Distinct().Count() == letters.Count();
    }
}