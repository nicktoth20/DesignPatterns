namespace DesignPatterns.Behavior.Observer;

public class TicketStockService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        // update local datastore (datastore omitted in demo implementation)
        Console.WriteLine($"{nameof(TicketStockService)} notified of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
    }
}