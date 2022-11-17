using AspNetCore.Models;

namespace AspNetCore.Models
{
    public class Statistic
    {
        /// <summary>
        /// Общее кол-во туров
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        ///  Сумма больше 150 баллов
        /// </summary>
        public decimal SumGood { get; set; }
    }
}
