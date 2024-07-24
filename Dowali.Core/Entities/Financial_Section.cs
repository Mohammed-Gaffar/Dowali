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
    public class Financial_Section : BaseEntity
    {
        [Display(Name = "رقم المشروع")]
        public Guid Project_Id { get; set; }

        [Display(Name = "الروتب الأجور")]
        [Required(ErrorMessage = "بيانات الرواتب والاجوز الزامية")]
        public double Wages_Salaries { get; set; }

        [Display(Name = "التجهيزات وملحقاتها")]
        [Required(ErrorMessage = "التجهيزات وملحقاتها الزامية ")]
        public double Equepment_And_Accessories { get; set; }

        [Display(Name = "المواد المستهلكة")]
        [Required(ErrorMessage = "بيانات المواد المستهلكة الزامية")]
        public double consumable { get; set; }

        [Display(Name = "تبادل الزيارات")]
        [Required(ErrorMessage = "يجب ادخال بيانات  تبادل الزيارات")]
        public double Exchange_Visits { get; set; }

        [Display(Name = "منصرفات أخرى")]
        [Required(ErrorMessage = "حقل الزامي")]
        public double Other_Expendtiure_items { get; set; }

        [Display(Name = "قيمة عقد الشريك الخارجي شامل الاستقطاع الضريبي")]
        [Required(ErrorMessage = "يجب ادخال بانات قيمة الشريك الخارجي")]
        public double External_Partner_Contract_include_Tax { get; set; }

        [Display(Name = "المجموع")]
        [Required(ErrorMessage = "هذا الحقل الزامي")]
        public double Total { get; set; }
    }
}
