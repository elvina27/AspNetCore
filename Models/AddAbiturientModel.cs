using AspNetCore.Models;

namespace AspNetCore
{
    public class AddAbiturientModel
    {
        /// <summary>
        /// Полное имя
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Гендер
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Др
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Форма обучения
        /// </summary>
        public FormaObucheniya FormaObucheniya { get; set; }
        /// <summary>
        /// Баллы ЕГЭ по матем
        /// </summary>
        public decimal Matem { get; set; }
        /// <summary>
        /// Баллы ЕГЭ по русскому
        /// </summary>
        public decimal Rus { get; set; }
        /// <summary>
        /// Баллы ЕГЭ по информатике
        /// </summary>
        public decimal Inf { get; set; }
    }
}
