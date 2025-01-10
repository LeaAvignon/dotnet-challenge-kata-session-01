using System;

namespace Katas.Session._01;

public static class ReverseStringKata
{
    /// <summary>
    /// This method reverses words
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ReverseWords(string input)
    {
        string[] mots = input.Split(' ');
        Array.Reverse(mots);
        return string.Join(' ', mots);
    }
}
