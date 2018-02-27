using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Adsmini.Models
{
    /// <summary>
    /// Категория.
    /// </summary>
    [DataContract(Name = "type")]
    public class Type
    {
        /// <summary>
        /// Уникальный идентификатор объявления.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название.
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
        /// <returns> Название категории. </returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
