// "// Copyright (c) FIAP Cloud Games. All rights reserved."

namespace FCG.Shared.Events;
public record PaymentProcessedEvent
{
    public Guid OrderId { get; init; }
    public Guid UserId { get; init; }
    public Guid GameId { get; init; }
    public PaymentStatus Status { get; init; }
    public DateTime ProcessedAt { get; init; }
}

public enum PaymentStatus
{
    Approved,
    Rejected
}
