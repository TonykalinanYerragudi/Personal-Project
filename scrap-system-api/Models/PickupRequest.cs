using System;
using scrap_system_api.Enums;

namespace scrap_system_api.Models;

public class PickupRequest
{
  public int PickupId { get; set; }
  public int UserId { get; set; }
  public int AddressId { get; set; }
  public ScrapType? ScrapType { get; set; }
  public string? EstimatedWeight { get; set; }
  public DateTime ScheduledDate { get; set; }
  public string? TimeSlot { get; set; }
  public PickupStatus? Status { get; set; }
  public User? User { get; set; }
  public Address? Address{ get; set; }
}
