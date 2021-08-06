using System.ComponentModel.DataAnnotations;

namespace AJWManagementPortal.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
