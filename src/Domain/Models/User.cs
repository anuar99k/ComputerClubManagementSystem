namespace Domain.Models;

/// <summary>
///     Базовая сущность пользователя
/// </summary>
public class User : Entity
{
    public string Username { get; set; }
    public string Password { get; set; }
}