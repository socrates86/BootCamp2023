using Example1;

ICustomerService customerService = new CustomerService();
List<Customer> customers = customerService.GetCustomers();

EmailSetting emailSetting = new EmailSetting();
emailSetting.Server = "smtp.gmail.com";
emailSetting.Username = "iykesocrates@gmail.com";
emailSetting.Password = "ghbdemklpayy";

IEmailService emailService = new EmailService(emailSetting);

foreach (Customer customer in customers)
{
    MyMessage message = new MyMessage();
    message.From = emailSetting.Username;
    message.Body = $"Dear {customer.Name}, \n Our promo begins this month!";

    bool result = emailService.SendMessage( customer, message );

    if(result)
    {
        Console.WriteLine($"Message sent to { customer.Name } @{ customer.Email }");
    }
}