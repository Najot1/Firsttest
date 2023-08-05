using Crm;

using Crm.Entities;
using Crm.Services;

ClientService clientService = new();
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
    Gender gender = (Gender)int.Parse(Console.ReadLine()!);
    if (!Enum.IsDefined(typeof(Gender), gender))
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


   


    Client newClient = clientService.CreateClient(new ClientInfo() {
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

    Console.WriteLine("Client Name: {0}",
        string.Join(' ', newClient.FirstName, newClient.MiddleName, newClient.LastName));

    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
    Console.WriteLine("Client Phone:{0}", newClient.Phone);
    Console.WriteLine("Client Email and Password:{0}", newClient.Email, newClient.Password); 
}

OrderService orderService = new();
CreateOrder();

void CreateOrder()
{
    Console.WriteLine("Order ID:");
    string? Id = Console.ReadLine();
    if (string.IsNullOrEmpty(Id))
        Console.WriteLine("Order Id is required!");

    Console.WriteLine("Description:");
    string? Description = Console.ReadLine();
    if (string.IsNullOrEmpty(Description))
        Console.WriteLine("Description is required!");

    Console.WriteLine("Price:");
    string PriceInputStr = Console.ReadLine()!;
    bool isPriceCorrect = short.TryParse(PriceInputStr, out short Price);
    if (!isPriceCorrect)
        Console.WriteLine("Please input correct value for Price field!");

    Console.WriteLine("Date:");
    string Date = Console.ReadLine()!;
    if (string.IsNullOrEmpty(Date))
        Console.WriteLine("Date is required!");

    Console.WriteLine("Address:");
    string? Address = Console.ReadLine();
    if (string.IsNullOrEmpty(Address)) 
        Console.WriteLine("Address is required!");

    Console.WriteLine("Type of Delivery(Express - 0,Standard - 1,Free - 2):");
    TypeOfDelivery Delivery = (TypeOfDelivery)int.Parse(Console.ReadLine()!);
    if (!Enum.IsDefined(typeof(TypeOfDelivery), Delivery))
    {
        throw new InvalidOperationException("Type of delivery is required!");
    }

    Order newOrder = orderService.CreateOrder(new OrderInfo() {
        Id = Id!,
        Description = Description!,
        Price = Price,
        Date = Date,
        Address = Address!,
        Delivery = Delivery
    });

    Console.WriteLine("Order Info: {0}",
        string.Join(' ', newOrder.Id, newOrder.Description, newOrder.Price));

    Console.WriteLine("Order Date: {0}", newOrder.Date);
    Console.WriteLine("Order Address: {0}", newOrder.Address);
    Console.WriteLine("Order Delivery Type: {0}", newOrder.Delivery);
}



void Find(Client newClient, Order newOrder)
{
ClientService clientService1 = new();
OrderService orderService1 = new();
Console.WriteLine("Enter first and last name:");
string find = Console.ReadLine()!;
if (string.IsNullOrEmpty(find)) 
    Console.WriteLine("First and Last Name are required!");
if (find.Equals(newClient.FirstName + newClient.LastName))
{
    clientService1.FindClient();
    Console.WriteLine("Enter Id and Descrition:");
    string find2 = Console.ReadLine()!;
    if (find2.Equals(newOrder.Id + newOrder.Description))
    {
        orderService1.FindOrder();
    }
}
}




Console.WriteLine("Create:"); 
string Create = Console.ReadLine()!;
if (Create.Equals("Client"))
{
    CreateClient();
    if (Create.Equals("Order"))
    {
        CreateOrder();
    }
}