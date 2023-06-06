using System.ComponentModel.DataAnnotations;

namespace RealEstateCourse.Models
{
    public class Estate
    {
        public int Id { get; set; }

        [MaxLength(200)]
        [Display(Name = "نام")]
        [Required(ErrorMessage ="فیلد نام ملک اجباری می باشد")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(1000)]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
