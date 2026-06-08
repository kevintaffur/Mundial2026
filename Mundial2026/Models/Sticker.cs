namespace Mundial2026.Models;

public class Sticker
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string PlayerName { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public bool Owned { get; set; } = false;
    public int Quantity { get; set; } = 0;
}