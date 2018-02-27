using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Adsmini.Models
{
    /// <summary>
    /// Город.
    /// </summary>
    [DataContract(Name = "city")]
    public class City
    {
        /// <summary>
        /// Уникальный идентификатор города.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название города.
        /// </summary>
        [DataMember(Name = "name")]
        public string Title { get; set; }

        /// <summary>
        /// Объявления.
        /// </summary>
        public virtual ICollection<Card> Cards { get; set; }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Название города. </returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
