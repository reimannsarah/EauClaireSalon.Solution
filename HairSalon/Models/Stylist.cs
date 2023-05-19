using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    // public DateTime HireDate { get; set; }
    public List<Client> Clients { get; set; }
  }

  public enum SpecialtyService
  {
    Cut,
    Color,
    CutAndColor
  }
}