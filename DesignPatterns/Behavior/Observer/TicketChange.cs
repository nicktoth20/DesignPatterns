namespace DesignPatterns.Behavior.Observer;

public class TicketChange
{
    public int ArtistId { get; }
    public int Amount { get; }

    public TicketChange(int artistId, int amount)
    {
        ArtistId = artistId;
        Amount = amount;
    }
}