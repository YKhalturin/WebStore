namespace WebStore.ViewModels
{
    public class UserOrderViewModel
    {
        public readonly int _orderId;
        public readonly string _orderName;
        public readonly string _orderPhone;
        public readonly string _orderAddress;
        public readonly decimal _sum;

        public UserOrderViewModel(in int orderId, string orderName, string orderPhone, string orderAddress, decimal sum)
        {
            _orderId = orderId;
            _orderName = orderName;
            _orderPhone = orderPhone;
            _orderAddress = orderAddress;
            _sum = sum;
        }
    }
}