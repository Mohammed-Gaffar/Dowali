//////////////////////////////////////////////////
//Author    : Mohammed Gaffer Aidaab
//For       : King Faisual University
//Under     : ISB integrated sulution business Company
//App       : Dowali Application (())
//Date      : July - 2024
/////////////////////////////////////////////////////

using Core.Entities.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Dowali.Core.Entities
{
    [Index(nameof(Project.owner), IsUnique = true)]

    public class Project : BaseEntity
    {
        [Required(ErrorMessage = "اسم المشروع باللغة العربية الزامي")]
        [MaxLength(255)]
        [Display(Name = "عنوان المشروع باللغة العربية")]
        public string Title_Ar { get; set; }

        [Required(ErrorMessage = "اسم الشروع باللغة الانجليزية إلزامي")]
        [MaxLength(255)]
        [Display(Name = "عنوان المشروع باللغة الإنجليزية")]
        public string Title_En { get; set; }

        [Required(ErrorMessage = "مدة المشروع")]
        [Display(Name = "مدة المشروع")]
        public int Douration { get; set; }

        [Required(ErrorMessage = "ملخص المشروع الزامي")]
        [MaxLength(255)]
        [Display(Name = "ملخص المشروع باللغة العربية")]
        public string Summary_Ar { get; set; }

        [Required(ErrorMessage = "ملخص المشروع باللغة الإنجليزية")]
        [MaxLength(255)]
        [Display(Name = "ملخص المشروع باللغة الإنجليزية")]
        public string Summary_En { get; set; }

        [Required(ErrorMessage = "المجال الرئيسي الزامي")]
        [MaxLength(255)]
        [Display(Name = "المجال الرئيسي")]
        public string Main_Field { get; set; }

        [Required(ErrorMessage = "المجال الفرعي الزامي")]
        [MaxLength(255)]
        [Display(Name = "المجال الفرعي")]
        public string Sub_Field { get; set; }


        [Display(Name = "حالة المشروع")]
        public int? satatus { get; set; }                   //project status {null === no action taken by the manager , 1 approved project , 0 not appproved project 

        [Display(Name = "صاحب المشروع")]
        public string owner { get; set; }                  //unique identifer for the user create project 

        [AllowNull]
        [Display(Name = "ملف المشروع")]
        public string? File_Path { get; set; }


        [NotMapped]
        [Display(Name = "ملف المشروع")]
        public IFormFile? File { get; set; }
    }
}