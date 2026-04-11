namespace Enums
{
    // You can explicitly set the starting value and the rest will increment by 1
    //public enum OrderStatus
    //{
    //    Pending = 1, 
    //    Shipped,    // 2
    //    Delivered,  // 3
    //    Cancelled   // 4
    //}

    // HOWEVER, for clarity (and troubleshooting) it is recommended to explicitly set all values
    public enum OrderStatus
    {
        Pending = 1,
        Shipped = 2,
        Delivered = 3,
        Cancelled = 4
    }
}
