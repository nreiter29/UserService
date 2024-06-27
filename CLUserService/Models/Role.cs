using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserService.Models;

public class Role
{
    [Key]
    public Guid RoleId { get; set; }
    public string Title { get; set; } = string.Empty;
    public ICollection<User> Users { get; set; }
}