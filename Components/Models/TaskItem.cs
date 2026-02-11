using System.ComponentModel.DataAnnotations;

namespace BlazorTask.Components.Models
{
    public class TaskItem
    {
        public Guid Id {  get; set; }
        [Required(ErrorMessage="Every task must have a name")]
        public string Name { get; set; } = "";
        public bool IsComplete { get; set; }

    }
}
