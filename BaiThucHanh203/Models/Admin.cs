using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh203.Models

{
    public class Admin
    {
        [Key]

        public string StudentCode { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }
    }
}