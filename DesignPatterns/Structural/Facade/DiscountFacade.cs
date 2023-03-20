namespace DesignPatterns.Structural.Facade;

public class DiscountFacade
{
    private readonly OrderService _orderService;
    private readonly CustomerDiscountBaseService _customerDiscountBaseService;
    private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService;
    private readonly IDateTimeWrapper _dateTimeWrapper;


    public DiscountFacade(
        OrderService orderService, 
        CustomerDiscountBaseService customerDiscountBaseService, 
        DayOfTheWeekFactorService dayOfTheWeekFactorService,
        IDateTimeWrapper dateTimeWrapper)
    {
        _orderService = orderService;
        _customerDiscountBaseService = customerDiscountBaseService;
        _dayOfTheWeekFactorService = dayOfTheWeekFactorService;
        _dateTimeWrapper = dateTimeWrapper;
    }

    public double CalculateDiscountPercentage(int customerId)
    {
        if (!_orderService.HasEnoughOrders(customerId))
        {
            return 0;
        }

        return _customerDiscountBaseService.CalculateDiscountBase(customerId) *
               _dayOfTheWeekFactorService.CalculateDayOfTheWeekFactor(_dateTimeWrapper.GetDayOfWeek());
    }
}

public interface IDateTimeWrapper
{
    public DayOfWeek GetDayOfWeek();
}