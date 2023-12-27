using System;
class Program
{
    static void Main()
    {
        string str1 = "abcdefg";
        string str2 = "bdhijk";
        
        string result = GetUniqueCharacters(str1, str2);
        
        Console.WriteLine(result);
    }
    
    static string GetUniqueCharacters(string str1, string str2)
    {
        string uniqueCharacters = "";
        
        foreach (char c in str1)
        {
            if (!str2.Contains(c.ToString()))
            {
                uniqueCharacters += c;
            }
        }
        
        return uniqueCharacters;
    }
}
