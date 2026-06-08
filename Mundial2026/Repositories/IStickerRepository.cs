using Mundial2026.Models;

namespace Mundial2026.Repositories;

public interface IStickerRepository
{
    IReadOnlyList<Sticker> GetAll();
}