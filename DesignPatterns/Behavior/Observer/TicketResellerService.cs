namespace DesignPatterns.Behavior.Observer;

public class TicketResellerService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        // update local datastore (datastore omitted in demo implementation)
        Console.WriteLine($"{nameof(TicketResellerService)} notified of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
    }
}