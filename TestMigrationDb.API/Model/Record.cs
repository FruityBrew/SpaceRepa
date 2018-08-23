using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TestMigrationDb.API.Model
{
    [DataContract]
    public class Record
    {
        [Required]
        [DataMember]
        public Int32 RecordId { get; set; }

        [Required]
        [DataMember]
        public Int32 UserId { get; set; }

        [DataMember]
        public String Name { get; set; }
    }
}
