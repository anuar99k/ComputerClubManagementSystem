namespace Domain;

public class Entity
{
    public string Id { get; } = Guid.NewGuid().ToString();
}