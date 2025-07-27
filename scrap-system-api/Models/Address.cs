using System;

namespace scrap_system_api.Models;

public class Address
{
  public int AddressId { get; set; }
  public int UserId { get; set; }
  public string? AddressLine1 { get; set; }
  public string? AddressLine2 { get; set; }
  public string? City { get; set; }
  public string? State { get; set; }
  public string? Pincode { get; set; }
  public User? User { get; set; }
  public ICollection<PickupRequest>? PickupRequests { get; set; }
}
