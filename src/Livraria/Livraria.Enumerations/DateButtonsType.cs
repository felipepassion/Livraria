﻿namespace Niu.Nutri.Livraria.Enumerations;
public enum DateButtonsType
{
    Yesterday,
    Today,
    Custom
}

public static class DateButtonsTypeExtensions
{
    public static string ToString(this DateButtonsType type)
    {
        return type switch
        {
            DateButtonsType.Yesterday => "Ontem",
            DateButtonsType.Today => "Hoje",
            DateButtonsType.Custom => "Outro",
            _ => throw new NotImplementedException(type.ToString())
        };
    }
}