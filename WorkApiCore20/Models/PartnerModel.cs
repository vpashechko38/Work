using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkApiCore20.Models
{
    public class PartnerModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Подтверждена ли учетная запись пользователя
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Пароль от учетной записи пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Наименование организации
        /// </summary>
        public string NameOrganization { get; set; }
        /// <summary>
        /// Фамилия Имя Отчество
        /// </summary>
        public string Fio { get; set; }
        // 0 -  , 1 -  , 2 -
        /// <summary>
        /// Тип клиента: 0 - ИП , 1 - Физ.лицо , 2 - Юр.лицо 
        /// </summary>
        public int TypeClient { get; set; }
        /// <summary>
        /// Почтовый ящик, также служит как логин для авторизации пользователя в системе
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Расчетный счет
        /// </summary>
        public string CheckingAccount { get; set; }
        /// <summary>
        /// Серия и номер паспорта
        /// </summary>
        public string SeriesAndNumberPassport { get; set; }
        /// <summary>
        /// Кем выдан паспорт
        /// </summary>
        public string IssuedByPasport { get; set; }
        /// <summary>
        /// Дата выдачи паспорта
        /// </summary>
        public DateTime DateOfIssuePassport { get; set; }
        /// <summary>
        /// Код подразделения выдавшего паспорт
        /// </summary>
        public string UnitCodePasport { get; set; }
        /// <summary>
        /// ОГРН
        /// </summary>
        public string OGRN { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string KPP { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// ОГРНИП
        /// </summary>
        public string OGRNIP { get; set; }
        /// <summary>
        /// Юридический адрес
        /// </summary>
        public string LegalAddress { get; set; }
        //физический адрес
        /// <summary>
        /// Физический адрес
        /// </summary>
        public string ActualAddress { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Наименование банка
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// БИК
        /// </summary>
        public string BIK { get; set; }
        /// <summary>
        /// Должность руководителя
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Действующий на основании
        /// </summary>
        public string ActingBasis { get; set; }
        /// <summary>
        /// Корреспондентский счет
        /// </summary>
        public string CorrespondentAccount { get; set; }
        /// <summary>
        /// Серия и номер свидетельства о постановке на учет в налоговом органе
        /// </summary>
        public string SeriesAndNumberCertificate { get; set; }
        /// <summary>
        /// Дата выдачи свидетельства о постановке на учет в налоговом органе
        /// </summary>
        public string DateOfIssueCertificate { get; set; }
    }
}
