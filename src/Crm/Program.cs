﻿using Crm;
using Crm.Entities;
using Crm.Services;

ClientService clientService = new();
CreateClient();

void CreateClient()
{
    string? firstName = Console.ReadLine();
    if (string.IsNullOrEmpty(firstName))
        Console.WriteLine("First Name is required!");
    string? lastName = Console.ReadLine();
    if (string.IsNullOrEmpty(lastName)) 
        Console.WriteLine("Last Name is required!");
    string? middleName = Console.ReadLine();
    if (string.IsNullOrEmpty(middleName)) 
        Console.WriteLine("Middle Name is required!");
    string ageInputStr = Console.ReadLine()!;
    bool isAgeCorrect = short.TryParse(ageInputStr, out short age);
    if (!isAgeCorrect)
        Console.WriteLine("Please input correct value for age field!");
    string? passportNumber = Console.ReadLine();
    if (string.IsNullOrEmpty(passportNumber))
        Console.WriteLine("Passport Number is required!");
    Gender gender = (Gender)int.Parse(Console.ReadLine()!);
    if (!Enum.IsDefined(typeof(Gender), gender))
    {
        throw new InvalidOperationException("Gender is required (0 = Male, 1 = Female!");
    }

   


    Client newClient = clientService.CreateClient(new ClientInfo() {
        FirstName = firstName!,
        LastName = lastName!,
        MiddleName = middleName!,
        Age = age,
        PassportNumber = passportNumber!,
        Gender = gender!
    });

    Console.WriteLine("Client Name: {0}",
        string.Join(' ', newClient.FirstName, newClient.MiddleName, newClient.LastName));

    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
}

OrderService orderService = new();
CreateOrder();

void CreateOrder()
{
    string? Id = Console.ReadLine();
    if (string.IsNullOrEmpty(Id))
        Console.WriteLine("Order Id is required!");
    string? Description = Console.ReadLine();
    if (string.IsNullOrEmpty(Description))
        Console.WriteLine("Description is required!");
    string PriceInputStr = Console.ReadLine()!;
    bool isPriceCorrect = short.TryParse(PriceInputStr, out short Price);
    if (!isPriceCorrect)
        Console.WriteLine("Please input correct value for Price field!");
    string Date = Console.ReadLine()!;
    if (string.IsNullOrEmpty(Date))
        Console.WriteLine("Date is required!");
    string? Address = Console.ReadLine();
    if (string.IsNullOrEmpty(Address)) 
        Console.WriteLine("Address is required!");
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
string CreateC = Console.ReadLine()!;
if (CreateC.Equals("Create Client"))
{
    CreateClient();
}

string CreateO = Console.ReadLine()!;
if (CreateO.Equals("Create Order"))
{
    CreateOrder();
}
