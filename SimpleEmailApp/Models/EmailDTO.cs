using System.ComponentModel.DataAnnotations;

namespace SimpleEmailApp.Models
{
    public class EmailDTO
    {
        [EmailAddress]
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;

        public string Body { get; set; } = string.Empty;
    }
}
