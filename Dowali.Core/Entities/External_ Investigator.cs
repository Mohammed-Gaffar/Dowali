//////////////////////////////////////////////////
//Author    : Mohammed Gaffer Aidaab
//For       : King Faisual University
//Under     : ISB integrated sulution business Company
//App       : Dowali Application (())
//Date      : July - 2024 
/////////////////////////////////////////////////////

using Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Dowali.Core.Entities
{
    public class External_Investigator : BaseEntity
    {
        [Required(ErrorMessage = " اسم الباحاث الخارجي مطلوب")]
        [MaxLength(255)]
        [Display(Name = "الباحث الخارجي")]
        public string Name { get; set; }

        [Required(ErrorMessage = " الرتبة العلمية مطلوب")]
        [MaxLength(255)]
        [Display(Name = "الرتبة العلمية")]
        public int Academic_Rank { get; set; }

        [Required(ErrorMessage = "القسم مطلوب")]
        [Display(Name = "القسم")]
        public int Department { get; set; }

        [Required(ErrorMessage = "عنوان المؤسسة")]
        [MaxLength(255)]
        [Display(Name = "عنوان المؤسسة مطلوب")]
        public string Address_Of_Institiution { get; set; }

        [Required(ErrorMessage = "الكلية أو المؤسسة")]
        [MaxLength(255)]
        [Display(Name = "حقل الكلية أو المؤسسة إلزامي")]
        public string College_Center { get; set; }

        [Required(ErrorMessage = "هاتف العمل")]
        [MaxLength(255)]
        [Display(Name = "هاتف العمل الزامي")]
        public int Office_Phone { get; set; }

        [Required(ErrorMessage = "رقم الجوال")]
        [MaxLength(255)]
        [Display(Name = "رقم الجوال إلزامي")]
        public int Mobile_Number { get; set; }


        [Required(ErrorMessage = "البريد الإلكتروني")]
        [MaxLength(255)]
        [Display(Name = "حقل البريد الإلكتروني إلزامي")]
        public string Email { get; set; }
    }
}
