using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "Название книги обязательно")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Название должно быть от 1 до 200 символов")]
        [Display(Name = "Название книги")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Автор обязателен")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Автор должен быть от 2 до 100 символов")]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Required(ErrorMessage = "ISBN обязателен")]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", ErrorMessage = "Введите корректный ISBN (10 или 13 цифр)")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Жанр обязателен")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Жанр от 3 до 50 символов")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
    }
}