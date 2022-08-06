using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    static List<string> existingList = new List<string>(){"C#","Clojure", "Elm"};
    public static List<string> NewList()
    {
        List<string> newlist = new List<string>();
        return newlist;
    }

    public static List<string> GetExistingLanguages()
    {
        return existingList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        if (languages[0]=="C#") return true;
        if (languages[1]=="C#" && languages.Count >= 2 && languages.Count <=3) return true;
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Distinct().Count() == languages.Count;
    }
}
