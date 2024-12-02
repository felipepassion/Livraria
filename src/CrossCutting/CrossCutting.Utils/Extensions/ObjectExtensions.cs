using System.Reflection;

namespace Niu.Nutri.CrossCuting.Infra.Utils.Extensions
{
    public static class ObjectExtensions
    {
        public static T Update<T, K>(this T item, K other, params string[] namesToIgnore)
        {
            var fis = FillFields(item?.GetType()!, true, 3);
            var fis2 = FillFields(other?.GetType()!, true, 3);

            // object tempMyClass = item == null ? null : Activator.CreateInstance(item?.GetType()); -> IF CLONE
            foreach (FieldInfo fi in fis)
            {
                var name = fi.Name.Contains("<") ? fi.Name.Substring(fi.Name.IndexOf('<') + 1, fi.Name.IndexOf('>') - 1) : fi.Name;
                if (namesToIgnore?.Any(x => name.Equals(x, StringComparison.InvariantCultureIgnoreCase) == true) == true) continue;

                if (fi.FieldType.Namespace != item.GetType().Namespace)
                {
                    var otherVal = fis2.FirstOrDefault(x => x.Name == fi.Name)?.GetValue(other);
                    if (otherVal is null) continue;

                    var myVal = fi.GetValue(item);
                    if ((myVal == null && otherVal != null) || myVal?.ToString()?.Equals(otherVal?.ToString(), StringComparison.InvariantCultureIgnoreCase) == false)
                    {
                        otherVal = otherVal is Guid && (Guid)otherVal == Guid.Empty || otherVal == null ? null : otherVal;

                        fi.SetValue(item, otherVal ?? myVal);
                    }
                }
                else
                {
                    object obj = fi.GetValue(item);
                    object otherObj = fis2.FirstOrDefault(x => x.Name == fi.Name)?.GetValue(other);

                    if (otherObj != null)
                        obj.Update(otherObj, namesToIgnore);
                }
            }
            return item;
        }

        public static List<FieldInfo> FillFields(this Type t, bool includeParent = true, int parantLevel = 1)
        {
            List<FieldInfo> fis = new List<FieldInfo>();
            FillFields(t, fis, includeParent, parantLevel);
            return fis;
        }

        private static void FillFields(Type t, List<FieldInfo> fis, bool includeParent = true, int parentLevel = 1)
        {
            if (t != null)
            {
                if (t.BaseType != null && includeParent && parentLevel-- > 0)
                    FillFields(t.BaseType, fis, includeParent, parentLevel);
                fis.AddRange(t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty) ?? new FieldInfo[0]);
            }
        }

        public static bool IsEmpty<T>(this T obj)
        {
            return IsNull(obj);
        }

        public static bool IsNull<T>(this T obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var prop in props)
            {
                if (prop.GetValue(obj) != null)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ContainsBase<T>(this Type t)
        {
            if (t.BaseType == null)
                return false;
            else if (t.BaseType.BaseType != null && t.BaseType.BaseType.FullName != "System.Object")
                return t.BaseType.ContainsBase<T>();
            else
                return t.BaseType.Name.Contains(nameof(T));
        }
    }
}
