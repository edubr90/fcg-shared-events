namespace FCG.Shared.Events;

public record OrderPlacedEvent
{
    public Guid OrderId { get; init; }
    public Guid UserId { get; init; }
    public Guid GameId { get; init; }
    public decimal Price { get; init; }
    public DateTime PlacedAt { get; init; }
}

