// "// Copyright (c) FIAP Cloud Games. All rights reserved."

namespace FCG.Shared.Events;
public record UserCreatedEvent
{
    public Guid UserId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
}
