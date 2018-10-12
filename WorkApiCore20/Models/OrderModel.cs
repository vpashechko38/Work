using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkApiCore20.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string FioClient { get; set; }
        /// <summary>
        /// Номер телефона клиента
        /// </summary>
        public string PhoneNumberClient { get; set; }
        /// <summary>
        /// Серия и номер паспорта
        /// </summary>
        public string SeriesAndNumberPasport { get; set; }
        /// <summary>
        /// Кем выдан паспорт
        /// </summary>
        public string IssuedByPasport { get; set; }
        /// <summary>
        /// Сумма заказа
        /// </summary>
        public double SumOrder { get; set; }
    }
}
