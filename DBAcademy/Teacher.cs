using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBAcademy
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? AuthorizationId { get; set; }
        [ForeignKey("AuthorizationId")]
        public virtual Authorization Authorization { get; set; }

        public int? TestId { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }
    }
}
