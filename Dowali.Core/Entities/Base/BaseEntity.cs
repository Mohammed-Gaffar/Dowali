//////////////////////////////////////////////////
//Author    : Mohammed Gaffer Aidaab
//For       : King Faisual University
//Under     : ISB integrated sulution business Company
//App       : Dowali Application (())
//Date      : July - 2024 
/////////////////////////////////////////////////////

using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        public DateTime? Create_At { get; set; }

        public Guid Created_by { get; set; }

        public DateTime? Update_At { get; set; }

        public Guid? Updated_by { get; set; }
    }
}
