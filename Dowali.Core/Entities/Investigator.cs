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
    public class Investigator : BaseEntity
    {
        [Required(ErrorMessage = " اسم الباحاث الداخلي مطلوب")]
        [MaxLength(255)]
        [Display(Name = " إسم الباحث الداخلي")]
        public string Name { get; set; }

        [Required(ErrorMessage = " الرتبة العلمية مطلوب")]
        [Display(Name = "الرتبة العلمية")]
        public int Academic_Rank { get; set; }


        [Required(ErrorMessage = "القسم مطلوب")]
        [Display(Name = "القسم")]
        public string Department { get; set; }


        [Required(ErrorMessage = "عنوان المؤسسة مطلوب")]
        [MaxLength(255)]
        [Display(Name = "عنوان المؤسسة")]
        public string Address_Of_Institiution { get; set; }


        [Display(Name = "الكلية أو المركز")]
        [MaxLength(255)]
        [Required(ErrorMessage = "حقل الكلية أو المركز إلزامي")]
        public string College_Center { get; set; }


        [Display(Name = "هاتف العمل")]
        [Required(ErrorMessage = "هاتف العمل الزامي")]
        public int Office_Phone { get; set; }


        [Display(Name = "رقم الجوال")]
        [Required(ErrorMessage = "رقم الجوال إلزامي")]
        public int Mobile_Number { get; set; }

        [Required(ErrorMessage = "البريد الإلكتروني")]
        [MaxLength(255)]
        [Display(Name = " البريد الإلكتروني")]
        public string Email { get; set; }



        //======================================================= General information of entity ============================================================

        [Display(Name = "نوع الباحث")]
        public int Inv_Type { get; set; }

        public Guid Project_Id { get; set; }

    }
}
