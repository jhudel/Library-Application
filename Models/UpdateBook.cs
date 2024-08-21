using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace TechExam.Models
{
    public class UpdateBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime? publishedDate { get; set; } 
    }
}
