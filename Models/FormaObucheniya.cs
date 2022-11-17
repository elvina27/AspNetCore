using System.ComponentModel;

namespace AspNetCore.Models
{
    public enum FormaObucheniya
    {
        /// <summary>
        /// Очное
        /// </summary>
        [Description("Очное")]
        Ochnoe,
        /// <summary>
        /// Очно-заочное
        /// </summary>
        [Description("Очно-заочное")]
        Ocno_zaochnoe,
        /// <summary>
        /// Заочное
        /// </summary>
        [Description("Заочное")]
        Zaochnoe,
    }
}
