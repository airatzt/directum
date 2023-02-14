using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Dal.Entities
{
    /// <summary>
    /// Модель с данными пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// ИД пользователя
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// состояние пользователя: онлайн, офлайн
        /// </summary>
        public State State { get; set; }
    }

    public enum State
    {
        Online,
        Offline
    }
}
