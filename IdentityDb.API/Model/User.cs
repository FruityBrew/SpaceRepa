using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IdentityDb.API.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public Int32 UserId { get; set; }

        [DataMember]
        public String Mail { get; set; }

        [DataMember]
        public String Login { get; set; }

        [DataMember]
        [Required]
        public Byte[] PassHash { get; set; }

        [DataMember]
        public DateTime RegistrationDt { get; set; }
    }
}
