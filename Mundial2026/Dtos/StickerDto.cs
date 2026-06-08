namespace Mundial2026.Dtos;

public class StickerDto
{
    public int Number { get; set; }
    public string PlayerName { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public bool Owned { get; set; }
    public int Quantity { get; set; }
}