namespace HairSalon.Models
{
  public class Client
  {
    public int StylistId { get; set; }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public Stylist Stylist { get; set; }
  }
}