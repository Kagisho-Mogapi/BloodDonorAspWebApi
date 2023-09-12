using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonor.Model
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Mobile { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public byte Age { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public string BloodGroup { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

    }
}
