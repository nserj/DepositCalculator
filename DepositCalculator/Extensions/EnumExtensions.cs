using System;
using System.ComponentModel;
using System.Reflection;

namespace DepositCalculator.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Get Description form the Enum
        /// </summary>
        public static string GetDescription(this Enum enumValue)
        {
            FieldInfo? field = enumValue.GetType().GetField(enumValue.ToString());
            if (field != null)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    return attributes[0].Description;
                }
            }
            return enumValue.ToString();
        }
    }
}
