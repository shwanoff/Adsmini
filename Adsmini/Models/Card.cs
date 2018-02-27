using System;
using System.Runtime.Serialization;

namespace Adsmini.Models
{
    /// <summary>
    /// Объявление.
    /// </summary>
    [DataContract(Name = "card")]
    public class Card
    {
        /// <summary>
        /// Уникальный идентификатор объявления.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Дата и время создания объявления.
        /// </summary>
        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Краткое описание.
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Подробное описание.
        /// </summary>
        [DataMember(Name = "longtext")]
        public string LognText { get; set; }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        [DataMember(Name = "type")]
        public int TypeId { get; set; }

        /// <summary>
        /// Контактный телефон.
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        [DataMember(Name = "city")]
        public int? CityId { get; set; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Ключевые слова.
        /// </summary>
        [DataMember(Name = "tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Сайт.
        /// </summary>
        [DataMember(Name = "site")]
        public string Site { get; set; }

        /// <summary>
        /// Электронная почта.
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Категория объявления.
        /// </summary>
        
        public Type Type { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Заголовок. </returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
