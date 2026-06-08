using Mundial2026.Models;
using Mundial2026.Seed;

namespace Mundial2026.Repositories;

public class StickerRepository : IStickerRepository
{
    private readonly List<Sticker> _stickers = StickerSeed.GetData();

    public IReadOnlyList<Sticker> GetAll()
    {
        return _stickers;
    }
}