namespace Niu.Nutri.Livraria.Enumerations
{
    public enum LiquidType
    {
        Water,
        Tea
    }

    public static class LiquidButtonsTypeExtensions
    {
        public static string GetName(this LiquidType? type)
        {
            return type switch
            {
                LiquidType.Water => "Água",
                LiquidType.Tea => "Chá",
                null => null,
                _ => throw new NotImplementedException(type.ToString())
            };
        }

        public static string ToImgFilePath(this LiquidType? type) => $"/icons/liquid/{type}.svg";
    }
}
