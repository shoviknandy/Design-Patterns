using InterviewStyle.FoodBuilder;
using InterviewStyle.PaymentStrategy;
using InterviewStyle.Ride_Sharing;
using InterviewStyle.ShoppingCart;
using InterviewStyle.StockMonitoring;

//Ques: Ride-Sharing
//var uber = Uber.getInstance();
//uber.Bookcar();
//uber.GenerateOTP();


//Ques: ShoppingCart
//IShoppingCart Watch = new ShoppingCart(9600);
//Console.WriteLine($" Watch Cost before Discount : {Watch.getTotal()}");
//Watch = new FestiveDiscount(Watch);
//Console.WriteLine($" Watch Cost after Discount : {Watch.getTotal()}");
//Watch = new LoyaltyDiscount(new CouponDiscount(Watch));
//Console.WriteLine($" Watch Cost after chain Discount : {Watch.getTotal()}");



//Ques: PaymentStrategy
//var paymentMethod = new PaymentStrategy();
//paymentMethod.SetPaymentMethod(new UPI());
//paymentMethod.processOrder(2600, 124);

//paymentMethod.SetPaymentMethod(new CreditCard());
//paymentMethod.processOrder(2800, 45692);



//Ques: StockMonitoring
//var monitoring = new StockMonitoring();
//var whatsapp = new MobileAppNotification();
//var GmailNotification = new EMailNotification();
//monitoring.Subscribe(whatsapp);
//monitoring.Subscribe(GmailNotification);
//monitoring.PriceChange(1200);
//monitoring.UnSubscribe(GmailNotification);
//monitoring.PriceChange(1000);


//Ques FoodOrder
IFoodBuilder Order = new FoodBuilder();
Order.addMainCourse("Butter Naan")
    .addMainCourse("Chicken Tikka")
    .addDrink("Mineral Water")
    .addDrink("Lassi").addAppetizer("Samosa")
    .addFries(1)
    .addFries(1).order();
Order.viewOrder();

