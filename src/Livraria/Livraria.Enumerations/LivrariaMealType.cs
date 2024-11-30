namespace Niu.Nutri.Livraria.Enumerations;
public enum LivrariaMealType
{
    Breakfast,
    MorningSnack,
    Lunch,
    AfternoonSnack,
    Dinner,
    Supper
}

public static class DyaryMealExtensions
{
    public static string GetName(this LivrariaMealType? type)
    {
        //traduzir todos os tipos de refeição
        return type switch
        {
            LivrariaMealType.Breakfast => "Café da manhã",
            LivrariaMealType.MorningSnack => "Lanche da manhã",
            LivrariaMealType.Lunch => "Almoço",
            LivrariaMealType.AfternoonSnack => "Lanche da tarde",
            LivrariaMealType.Dinner => "Jantar",
            LivrariaMealType.Supper => "Ceia",
            null => null,
            _ => throw new NotImplementedException(type.ToString())
        };
    }
}