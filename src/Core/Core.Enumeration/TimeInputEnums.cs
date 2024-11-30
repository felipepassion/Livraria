﻿namespace Niu.Nutri.Core.Enumeration;

public static class TimeInputEnums
{
    public static string[] GetHoursList()
    {
        string[] hours = new string[24];
        for (int i = 0; i < 24; i++)
        {
            hours[i] = i.ToString("##");
        }
        return hours;
    }

    public static string[] GetMinutes()
    {
        string[] minutes = new string[60];
        for (int i = 0; i < 60; i++)
        {
            minutes[i] = i.ToString("##");
        }
        return minutes;
    } 
}
