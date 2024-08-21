using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace TechExam.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime? publishedDate { get; set; }
    }
}
