using System;
using System.ComponentModel.DataAnnotations;

namespace scrap_system_api.Models;

public class User
{
  public int UserId { get; set; }
  public string? FullName { get; set; }
  public string? Email { get; set; }
  public string? PhoneNumber { get; set; }
  public string? Role { get; set; }
  public DateTime CreatedAt { get; set; }
  public ICollection<Address>? Addresses { get; set; }
  public ICollection<PickupRequest>? PickupRequests { get; set; }

}
