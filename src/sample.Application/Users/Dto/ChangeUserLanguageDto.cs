using System.ComponentModel.DataAnnotations;

namespace sample.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}