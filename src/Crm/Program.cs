using Crm.BusinessLogic;

IClientService clientService = ClientServiceFactory.CreateClientService();
CreateClient();

void CreateClient()
{
    Console.WriteLine("FistName:");
    string? firstName = Console.ReadLine();
    if (string.IsNullOrEmpty(firstName))
        Console.WriteLine("First Name is required!");

    Console.WriteLine("LastName:");
    string? lastName = Console.ReadLine();
    if (string.IsNullOrEmpty(lastName)) 
        Console.WriteLine("Last Name is required!");

    Console.WriteLine("MiddleName:");
    string? middleName = Console.ReadLine();
    if (string.IsNullOrEmpty(middleName)) 
        Console.WriteLine("Middle Name is required!");

    Console.WriteLine("Age:");
    string ageInputStr = Console.ReadLine()!;
    bool isAgeCorrect = short.TryParse(ageInputStr, out short age);
    if (!isAgeCorrect)
        Console.WriteLine("Please input correct value for age field!");

    Console.WriteLine("PassportNumber:");    
    string? passportNumber = Console.ReadLine();
    if (string.IsNullOrEmpty(passportNumber))
        Console.WriteLine("Passport Number is required!");

    Console.WriteLine("Gender(0=Male,1=Female):");
    string? gender = Console.ReadLine();
    if (gender != "Female" || gender != "Male")
    {
        throw new InvalidOperationException("Gender is required (0 = Male, 1 = Female!");
    }

    Console.WriteLine("PhoneNumber:");
    string? phone = Console.ReadLine();
    if (string.IsNullOrEmpty(middleName)) 
        Console.WriteLine("PhomeNumber is required!");

    Console.WriteLine("Email:");
    string? email = Console.ReadLine();
    if (string.IsNullOrEmpty(middleName)) 
        Console.WriteLine("Email is required!");

    Console.WriteLine("Password:");
    string? password = Console.ReadLine();
    if (string.IsNullOrEmpty(middleName)) 
        Console.WriteLine("Password is required!");


   


    ClientInfo newClient = clientService.CreateClient(new ClientInfo() {
        FirstName = firstName!,
        LastName = lastName!,
        MiddleName = middleName!,
        Age = age,
        PassportNumber = passportNumber!,
        Gender = gender!,
        Phone = phone!,
        Email = email!,
        Password = password!
    });

    Console.WriteLine("Client Name: {0}", string.Join(' ', newClient.Id, newClient.FirstName, newClient.MiddleName, newClient.LastName));
    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
    Console.WriteLine("Client Phone:{0}", newClient.Phone);
    Console.WriteLine("Client Email and Password:{0}", string.Join(' ', newClient.Email, newClient.Password)); 
}


IOrderService orderService = OrderServiceFactory.CreateOrderService();
CreateOrder();

void CreateOrder()
{
    Console.WriteLine("Description:");
    string? description = Console.ReadLine();
    if (string.IsNullOrEmpty(description))
        Console.WriteLine("Description is required!");

    Console.WriteLine("Price:");
    string PriceInputStr = Console.ReadLine()!;
    bool isPriceCorrect = short.TryParse(PriceInputStr, out short price);
    if (!isPriceCorrect)
        Console.WriteLine("Please input correct value for Price field!");

    Console.WriteLine("Date:");
    string date = Console.ReadLine()!;
    if (string.IsNullOrEmpty(date))
        Console.WriteLine("Date is required!");

    Console.WriteLine("Address:");
    string? address = Console.ReadLine();
    if (string.IsNullOrEmpty(address)) 
        Console.WriteLine("Address is required!");

    Console.WriteLine("Type of Delivery(Express - 0,Standard - 1,Free - 2):");
    string? delivery = Console.ReadLine();
    if (delivery != "Express" || delivery != "Standart" || delivery != "Free")
    {
        throw new InvalidOperationException("Type of delivery is required!");
    }

    Console.WriteLine("Order State (Pending, Approved, Cancelled:");
    string? state = Console.ReadLine();
    if (state != "Pending" || state != "Approved" || state != "Cancelled")
    {
        throw new InvalidOperationException("Order State is not correct!");
    }

   OrderInfo newOrder = orderService.CreateOrder(new OrderInfo() {
        Description = description!,
        Price = price,
        Date = date,
        Address = address!,
        Delivery = delivery,
        State = state
    });

    Console.WriteLine("Order Info: {0}", string.Join(' ', newOrder.Id, newOrder.Description, newOrder.Price));
    Console.WriteLine("Order Date: {0}", newOrder.Date);
    Console.WriteLine("Order Address: {0}", newOrder.Address);
    Console.WriteLine("Order Delivery Type: {0}", newOrder.Delivery);
    Console.WriteLine("Order State: {0}", newOrder.State);
}





// Console.WriteLine("Create:"); 
// string Create = Console.ReadLine()!;
// while (Create.Equals("Client"))
// {
//     CreateClient();
//     if (Create.Equals("Order")) 
//     {
//         CreateOrder();
//     }
//     if (Create is null)
//     {
//         break;
//     }
// }
