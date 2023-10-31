using Microsoft.AspNetCore.Identity;
using System;

namespace Eol.Models
{
  public class ApplicationUser : IdentityUser
  {
    public byte[] Photo { get; set; }
    public DateTime specificDate { get; set; }
    public string Description { get; set; }
  }
}