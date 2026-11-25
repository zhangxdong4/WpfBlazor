using System.ComponentModel.DataAnnotations;

namespace WpfBlazor.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "姓名是必填项")]
    [Display(Name = "姓名")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "密码是必填项")]
    [DataType(DataType.Password)]
    [MaxLength(100)]
    [Display(Name = "密码")]
    public string? PassWord { get; set; }

    [Required(ErrorMessage = "生日是必填项")]
    [Display(Name = "生日")]
    public DateTime Birthday { get; set; }

    [Display(Name = "住址")]
    public string? Address { get; set; }
}
