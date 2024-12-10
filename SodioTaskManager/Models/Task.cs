using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }

    public class SodioTask
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.Pending;

        [Required]
        public DateTime DueDate { get; set; }
    }
}
