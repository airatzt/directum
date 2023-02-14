using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Dal.Entities
{
    /// <summary>
    /// Модель с данными о контактах пользователя
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// ИД контакта
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// ИД пользователя, владельца контакта
        /// </summary>
        public Guid OwnerId { get; set; }
        /// <summary>
        /// ИД пользователя, на который ссылается контакт
        /// </summary>
        public Guid ContactUserId  { get; set; }
        /// <summary>
        /// дата и время последней беседы с контактом
        /// </summary>
        public DateTime  LastUpdateTime { get; set; }
    }
}
