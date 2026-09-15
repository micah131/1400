class Program
{
    public static double TicketPrice(int age, bool isMember, string showTime)
    {
        Console.WriteLine("What is your age?");
        Console.WriteLine("are you a Member? (true/false)");
        double ticketPrice = 12;
        double memberDiscount = 0.2; // 20% discount for members
        double timeDiscount = 3; // 3$ discount for matinee shows
        if (age <= 5)
        {
            ticketPrice = 0;
        }
        else if (age >= 65)
        {
            ticketPrice = 8;
        }
        if (isMember)
        {
            ticketPrice *= (1 - memberDiscount);
        }
        if (showTime == "matinee")
        {
            ticketPrice -= timeDiscount;
        }
        return ticketPrice;
    
    }
    
    public static void Main()
   {
    double price = TicketPrice(30, true, "midnight");
    Console.WriteLine($"The ticket price is: ${price}");
   }

}
//1.age, member, time
//2. you can use mutiple discounts howerver you cannot go below 0
//3. it should revert to the base price if the discounts make it go below 0
//4.0
//5.9
//6.3.4
//7.9.6