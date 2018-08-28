using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IdentityDb.API.Model
{
    public class User
    {
        public Int32 UserId { get; set; }

        public String Mail { get; set; }

        public String Login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        public String Pass { get; set; }

        public DateTime? RegistrationDt { get; set; }
    }
}
