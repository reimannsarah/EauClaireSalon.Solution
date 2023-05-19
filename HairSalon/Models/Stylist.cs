using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public DateOnly HireDate { get; set; }
    public List<Client> Clients { get; set; }
  }
}