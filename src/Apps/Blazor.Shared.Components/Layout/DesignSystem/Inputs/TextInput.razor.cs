using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Text.RegularExpressions;

namespace Niu.Nutri.Shared.Blazor.Components.Layout.DesignSystem.Inputs
{
    public enum Masks
    {
        Phone,
        CPF,
        Email
    }
    public static class MasksExtensions
    {

        #region Phone

        public static bool IsValidPhone(this string value) =>
             value.Count(x => x == '(') <= 1
             && value.Count(x => x == ')') <= 1
             && value.Count(x => x == '-') <= 1;

        public static string PhoneMask(this string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            if (value.Any(c => !char.IsDigit(c)))
            {
                if (!value.IsValidPhone())
                {
                    value = value.RemoveTelephoneMask();
                    return value;
                }
            }

            value = new string(value.Where(char.IsDigit).ToArray());

            if (value.Length > 2)
                value = value.Insert(0, "(").Insert(3, ") ");

            if (value.Length > 9)
                value = value.Insert(10, "-");

            if (value.Length > 15)
            {
                value = value.Substring(0, 15);
            }

            return value;
        }

        #endregion

        #region CPF

        public static bool IsValidCpf(this string value) => true;

        public static string CpfMask(this string value)
        {
            return string.Empty;
        }


        #endregion

        #region Email

        public static bool ContainsAnyEmailChar(this string value) =>
             (value.Count(x => x == '@') >= 1
             || value.Count(x => x == '.') >= 1
             || value.Count(x => x == '_') >= 1
             || value.ExtractNumbers().Length >= 12 
             || Regex.IsMatch(value, @"^[a-zA-Z0-9]+$")) && value != ")" && value != "(" && value != "-";

        #endregion

        public static string GetValueByMask(this Masks mask, string input)
        {
            switch (mask)
            {
                case Masks.Phone:
                    return input.PhoneMask();
                case Masks.CPF:
                    return input.CpfMask();
                default:
                    throw new ArgumentException($"Mask not implemented {mask}");
            }
        }

        public static bool IsValidByMask(this Masks mask, string input)
        {
            switch (mask)
            {
                case Masks.Phone:
                    return input.IsValidPhone() && input.RemoveTelephoneMask().All(x => char.IsDigit(x));
                case Masks.CPF:
                    return input.IsValidCpf();
                case Masks.Email:
                    return input.ContainsAnyEmailChar();
                default:
                    throw new ArgumentException($"Validation not implemented {mask}");
            }
        }
    }

}
