using Microsoft.SemanticKernel;
using Mundial2026.Dtos;
using Mundial2026.Models;
using Mundial2026.Repositories;

namespace Mundial2026.Services;

public class StickerService
{
    private readonly IStickerRepository _repository;

    public StickerService(IStickerRepository repository)
    {
        _repository = repository;
    }

    [KernelFunction]
    public int GetOwnedCount()
    {
        return _repository
            .GetAll()
            .Count(s => s.Owned);
    }

    [KernelFunction]
    public int GetMissingCount()
    {
        return _repository
            .GetAll()
            .Count(s => !s.Owned);
    }

    [KernelFunction]
    public int GetDuplicatesCount()
    {
        return _repository
            .GetAll()
            .Sum(s => Math.Max(0, s.Quantity - 1));
    }
    
    [KernelFunction]
    public IEnumerable<StickerDto> GetMissingStickers()
    {
        return _repository
            .GetAll()
            .Where(s => !s.Owned)
            .Select(s => new StickerDto
            {
                Number = s.Number,
                PlayerName = s.PlayerName,
                Team = s.Team,
                Owned = s.Owned,
                Quantity = s.Quantity
            });
    }
    
    [KernelFunction]
    public IEnumerable<Sticker> GetMissingByTeam(
        string team)
    {
        return _repository
            .GetAll()
            .Where(s =>
                !s.Owned &&
                s.Team.Equals(
                    team,
                    StringComparison.OrdinalIgnoreCase));
    }
    
    [KernelFunction]
    public double GetCompletionPercentage()
    {
        var stickers = _repository.GetAll();

        var total = stickers.Count;

        var owned = stickers.Count(
            s => s.Owned);

        return Math.Round(
            (double)owned / total * 100,
            2);
    }
    
    [KernelFunction]
    public AlbumStatsDto GetStats()
    {
        return new AlbumStatsDto
        {
            Owned = GetOwnedCount(),
            Missing = GetMissingCount(),
            Duplicates = GetDuplicatesCount()
        };
    }
}