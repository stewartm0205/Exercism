using System;
using System.Collections.Generic;

public static class DialingCodes
{
    static Dictionary<int, string> existingDict = new Dictionary<int, string> {{1, "United States of America"}, {55,"Brazil"}, {91,"India"}};


    public static Dictionary<int, string> GetEmptyDictionary()
    {
        Dictionary<int, string> d = new Dictionary<int, string>();
        return d;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return existingDict;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var emptyDict = GetEmptyDictionary();
        emptyDict.Add(countryCode, countryName);
        return emptyDict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary.Add(countryCode, countryName);
        }
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            return existingDictionary[countryCode];
        }
        return "";

    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode)) {
            existingDictionary.Remove(countryCode);
        }
        return existingDictionary;

    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longest = "";
        foreach (var item in existingDictionary) {
            if (item.Value.Length > longest.Length) longest = item.Value;
        }
        return longest;
    }
}