using System.ComponentModel;

namespace AspNetCore.Models
{
    public enum Gender
    {
        /// <summary>
        /// Мальчик
        /// </summary>
        [Description("Мужской")]
        Male,
        /// <summary>
        /// Девочка
        /// </summary>
        [Description("Женский")]
        Female,
    }
}
