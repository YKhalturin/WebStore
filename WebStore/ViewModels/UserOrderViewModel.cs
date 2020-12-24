namespace WebStore.ViewModels
{
    public class UserOrderViewModel
    {
        public readonly int OrderId;
        public readonly string OrderName;
        public readonly string OrderPhone;
        public readonly string OrderAddress;
        public readonly decimal Sum;

        public UserOrderViewModel(in int orderId, string orderName, string orderPhone, string orderAddress, decimal sum)
        {
            OrderId = orderId;
            OrderName = orderName;
            OrderPhone = orderPhone;
            OrderAddress = orderAddress;
            Sum = sum;
        }
    }
}