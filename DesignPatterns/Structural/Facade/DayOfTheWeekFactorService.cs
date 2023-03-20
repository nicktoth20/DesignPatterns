namespace DesignPatterns.Structural.Facade;

public class DayOfTheWeekFactorService
{
    public virtual double CalculateDayOfTheWeekFactor(DayOfWeek dayOfWeek)
    {
        return dayOfWeek switch
        {
            DayOfWeek.Saturday => 0.8,
            DayOfWeek.Sunday => 0.8,
            _ => 1.2
        };
    }
}