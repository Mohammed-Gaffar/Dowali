using Dowali.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Dowali.UI.Dto
{
    public class ProjectsDTO
    {
        public Research Project { get; set; }

        public Investigator investigator { get; set; }

        public Financial_Section Financial_Section { get; set; }




        //=========================================================|External Invistgator Entity ===================================================


        [Required(ErrorMessage = " اسم الباحاث الخارجي مطلوب")]
        [MaxLength(255)]
        [Display(Name = "الباحث الخارجي")]
        public string Ex_Inv_Name { get; set; }


        [Required(ErrorMessage = " الرتبة العلمية مطلوب")]
        [Display(Name = "الرتبة العلمية")]
        public int Ext_Inv_Academic_Rank { get; set; }


        [Required(ErrorMessage = "القسم مطلوب")]
        [Display(Name = "القسم")]
        public string Ext_Inv_Department { get; set; }


        [Required(ErrorMessage = "عنوان المؤسسة مطلوب")]
        [MaxLength(255)]
        [Display(Name = "عنوان المؤسسة ")]
        public string Ext_Inv_Address_Of_Institiution { get; set; }


        [Display(Name = "الكلية أو المؤسسة")]
        [MaxLength(255)]
        [Required(ErrorMessage = "حقل الكلية أو المؤسسة إلزامي")]
        public string Ext_inv_College_Center { get; set; }


        [Required(ErrorMessage = "هاتف العمل")]
        [Display(Name = "هاتف العمل الزامي")]
        public int Ext_Inv_Office_Phone { get; set; }


        [Display(Name = "رقم الجوال")]
        [Required(ErrorMessage = "رقم الجوال إلزامي")]
        public int Ext_Inv_Mobile_Number { get; set; }


        [Display(Name = "البريد الإلكتروني")]
        [MaxLength(255)]
        [Required(ErrorMessage = "حقل البريد الإلكتروني إلزامي")]
        public string Ext_Inv_Email { get; set; }

        //===============================================================================================================



        [AllowNull]
        [NotMapped]
        public IEnumerable<Research>? Projects { get; set; }

        [AllowNull]
        [NotMapped]
        public IEnumerable<Investigator>? ProjectInvestigators { get; set; }


        [AllowNull]
        [NotMapped]
        public IEnumerable<Financial_Section>? Projectinancial_Section { get; set; }



    }
}