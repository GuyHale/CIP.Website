using System.ComponentModel;
using System.Reflection;


namespace CIP.Website.Data.Helpers
{
    public static class EnumExtensions
    {
        public static string Description(this Enum? value)
        {
            if(value is null)
            {
                return string.Empty;
            }
            FieldInfo? enumField = value.GetType().GetField(value.ToString());
            DescriptionAttribute? descriptionAttr = enumField?.GetCustomAttribute<DescriptionAttribute>();
            return descriptionAttr?.Description ?? string.Empty;
        }
    }
}
