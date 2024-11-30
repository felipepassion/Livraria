namespace Niu.Nutri.Livraria.Enumerations
{
    public enum QuantityType
    {
        ML,
        L
    }

    public static class QuantityTypeExtensions
    {
        public static string ToString(this QuantityType? type)
        {
            return type switch
            {
                QuantityType.ML => "Mililitros",
                QuantityType.L => "Litros",
                null => null,
                _ => throw new NotImplementedException(type.ToString())
            };
        }
    }
}
