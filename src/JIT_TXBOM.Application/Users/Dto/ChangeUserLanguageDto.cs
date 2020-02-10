using System.ComponentModel.DataAnnotations;

namespace JIT_TXBOM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}