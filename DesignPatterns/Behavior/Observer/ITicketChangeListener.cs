namespace DesignPatterns.Behavior.Observer;

public interface ITicketChangeListener
{
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}