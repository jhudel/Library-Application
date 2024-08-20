using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace TechExam.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }

    public class errorMessage
    {
        public string? ErrorMessage { get; set; }
        public string? ErrorSubMessage { get; set; }
    }

    public class successMessage
    {
        public string? SuccessMessage { get; set; }
        public string? SuccessSubMessage { get; set; }
    }
}
