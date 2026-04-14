using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Название книги обязательно")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Автор обязателен")]
        [StringLength(100)]
        public string Author { get; set; }

        [Required(ErrorMessage = "ISBN обязателен")]
        [StringLength(20)]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", ErrorMessage = "Введите корректный ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Жанр обязателен")]
        [StringLength(50)]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Год издания обязателен")]
        [Range(1450, 2025, ErrorMessage = "Год должен быть от 1450 до 2025")]
        public int Year { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}