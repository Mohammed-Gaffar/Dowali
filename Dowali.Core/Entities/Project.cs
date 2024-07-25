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
        [Required(ErrorMessage = "اسم البحث باللغة العربية الزامي")]
        [MaxLength(255)]
        [Display(Name = "عنوان البحث باللغة العربية")]
        public string Title_Ar { get; set; }

        [Required(ErrorMessage = "اسم البحث باللغة الانجليزية إلزامي")]
        [MaxLength(255)]
        [Display(Name = "عنوان البحث باللغة الإنجليزية")]
        public string Title_En { get; set; }

        [Required(ErrorMessage = "مدة البحث")]
        [Display(Name = "مدة البحث")]
        public int Douration { get; set; }

        [Required(ErrorMessage = "ملخص البحث الزامي")]
        [MaxLength(255)]
        [Display(Name = "ملخص المقترح البحثي  باللغة العربية")]
        public string Summary_Ar { get; set; }

        [Required(ErrorMessage = "ملخص المقترح البحثي باللغة الإنجليزية")]
        [MaxLength(255)]
        [Display(Name = "ملخص المقترح البحثي  باللغة الإنجليزية")]
        public string Summary_En { get; set; }

        [Required(ErrorMessage = "المجال الرئيسي الزامي")]
        [MaxLength(255)]
        [Display(Name = "المجال الرئيسي")]
        public string Main_Field { get; set; }

        [Required(ErrorMessage = "المجال الفرعي الزامي")]
        [MaxLength(255)]
        [Display(Name = "المجال الفرعي")]
        public string Sub_Field { get; set; }


        [Display(Name = "حالة البحث")]
        public int? satatus { get; set; }                   //project status {null === no action taken by the manager , 1 approved project , 0 not appproved project 

        [Display(Name = "صاحب البحث")]
        public string? owner { get; set; }                  //unique identifer for the user create project 

        [AllowNull]
        [Display(Name = "ملف البحث")]
        public string? File_Path { get; set; }


        [NotMapped]
        [Display(Name = "ملف البحث")]
        public IFormFile? File { get; set; }
    }
}