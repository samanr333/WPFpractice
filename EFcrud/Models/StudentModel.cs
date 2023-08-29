using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Validation.Model
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Email { get; set; } 
    }
}
