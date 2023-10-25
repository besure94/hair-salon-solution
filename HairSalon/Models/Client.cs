namespace HairSalon.Models
{
  public class Client
  {
    public string StylistId { get; set; }
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public Stylist Stylist { get; set; }
  }
}