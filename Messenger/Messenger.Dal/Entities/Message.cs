using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Dal.Entities
{
    /// <summary>
    /// Модель сообщения пользователя
    /// </summary>
    public class Message
    {
        /// <summary>
        /// ИД сообщения
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// ИД пользователя, отправившего сообщение
        /// </summary>
        public Guid SenderId { get; set; }
        /// <summary>
        /// пользователя, получившего сообщение
        /// </summary>
        public Guid RecipientId { get; set; }
        /// <summary>
        /// дата и время отправки сообщения
        /// </summary>
        public DateTime SendTime { get; set; }
        /// <summary>
        /// дата и время получения сообщения
        /// </summary>
        public DateTime DeliveryTime { get; set; }
        /// <summary>
        /// текст сообщения
        /// </summary>
        public string Content { get; set; }
    }
}
