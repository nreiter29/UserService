using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserService.Models;

public class User
{
    [Key]
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public ICollection<Role> Roles { get; set; }
}
