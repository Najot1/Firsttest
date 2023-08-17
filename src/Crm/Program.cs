using Crm.DataAccess;
using Crm.BusinessLogic;

// IClientService clientService = new ClientService();
// CreateClient();


// void CreateClient()
// {
//     Console.WriteLine("ID:");
//     string IDClient = Console.ReadLine()!;
//     bool isIDCorrect = int.TryParse(IDClient, out int id);
//     if (!isIDCorrect)
//         Console.WriteLine("Please input correct value for ID field!");

//     Console.WriteLine("FistName:");
//     string? firstName = Console.ReadLine();
//     if (string.IsNullOrEmpty(firstName))
//         Console.WriteLine("First Name is required!");

//     Console.WriteLine("LastName:");
//     string? lastName = Console.ReadLine();
//     if (string.IsNullOrEmpty(lastName)) 
//         Console.WriteLine("Last Name is required!");

//     Console.WriteLine("MiddleName:");
//     string? middleName = Console.ReadLine();
//     if (string.IsNullOrEmpty(middleName)) 
//         Console.WriteLine("Middle Name is required!");

//     Console.WriteLine("Age:");
//     string ageInputStr = Console.ReadLine()!;
//     bool isAgeCorrect = short.TryParse(ageInputStr, out short age);
//     if (!isAgeCorrect)
//         Console.WriteLine("Please input correct value for age field!");

//     Console.WriteLine("PassportNumber:");    
//     string? passportNumber = Console.ReadLine();
//     if (string.IsNullOrEmpty(passportNumber))
//         Console.WriteLine("Passport Number is required!");

//     Console.WriteLine("Gender(0=Male,1=Female):");
//     Gender gender = (Gender)int.Parse(Console.ReadLine()!);
//     if (!Enum.IsDefined(typeof(Gender), gender))
//     {
//         throw new InvalidOperationException("Gender is required (0 = Male, 1 = Female!");
//     }

//     Console.WriteLine("PhoneNumber:");
//     string? phone = Console.ReadLine();
//     if (string.IsNullOrEmpty(middleName)) 
//         Console.WriteLine("PhomeNumber is required!");

//     Console.WriteLine("Email:");
//     string? email = Console.ReadLine();
//     if (string.IsNullOrEmpty(middleName)) 
//         Console.WriteLine("Email is required!");

//     Console.WriteLine("Password:");
//     string? password = Console.ReadLine();
//     if (string.IsNullOrEmpty(middleName)) 
//         Console.WriteLine("Password is required!");


   


//     Client newClient = clientService.CreateClient(new ClientInfo() {
//         ID = id,
//         FirstName = firstName!,
//         LastName = lastName!,
//         MiddleName = middleName!,
//         Age = age,
//         PassportNumber = passportNumber!,
//         Gender = gender!,
//         Phone = phone!,
//         Email = email!,
//         Password = password!
//     });

//     Console.WriteLine("Client Name: {0}", string.Join(' ', newClient.ID, newClient.FirstName, newClient.MiddleName, newClient.LastName));
//     Console.WriteLine("Client Age: {0}", newClient.Age);
//     Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
//     Console.WriteLine("Client Phone:{0}", newClient.Phone);
//     Console.WriteLine("Client Email and Password:{0}", string.Join(' ', newClient.Email, newClient.Password)); 
// }

IOrderService orderService = new OrderService();
CreateOrder();

void CreateOrder()
{
    Console.WriteLine("Order ID:");
    string IdOrder = Console.ReadLine()!;
    bool isIDCorrect = int.TryParse(IdOrder, out int id);
    if (!isIDCorrect)
        Console.WriteLine("Please input correct value for ID field!");
        
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
    TypeOfDelivery delivery = (TypeOfDelivery)int.Parse(Console.ReadLine()!);
    if (!Enum.IsDefined(typeof(TypeOfDelivery), delivery))
    {
        throw new InvalidOperationException("Type of delivery is required!");
    }

    Console.WriteLine("Order State (Pending = 0,Approved = 1,Cancelled = 2):");
    OrderState state = (OrderState)int.Parse(Console.ReadLine()!);
    if (!Enum.IsDefined(typeof(OrderState), state))
    {
        throw new InvalidOperationException("Order State is not correct!");
    }

   Order newOrder = orderService.CreateOrder(new OrderInfo() {
        ID = id,
        Description = description!,
        Price = price,
        Date = date,
        Address = address!,
        Delivery = delivery,
        State = state
    });

    Console.WriteLine("Order Info: {0}", string.Join(' ', newOrder.ID, newOrder.Description, newOrder.Price));
    Console.WriteLine("Order Date: {0}", newOrder.Date);
    Console.WriteLine("Order Address: {0}", newOrder.Address);
    Console.WriteLine("Order Delivery Type: {0}", newOrder.Delivery);
    Console.WriteLine("Order State: {0}", newOrder.State);
}




// Console.WriteLine("Enter new First and Last names:");
// string newFirstName = Console.ReadLine()!;
// string newLastName = Console.ReadLine()!;
// int clientId = Convert.ToInt16(Console.ReadLine());

// Client client = clientService.ChangeClient(newFirstName!, newLastName!, clientId);

// Console.WriteLine("Client Name: {0}", string.Join(' ', client.FirstName, client.MiddleName, client.LastName));
// Console.WriteLine("Client Age: {0}", client.Age);
// Console.WriteLine("Client Passport Number: {0}", client.PassportNumber);
// Console.WriteLine("Client Phone:{0}", client.Phone);
// Console.WriteLine("Client Email and Password:{0}", string.Join(' ',client.Email, client.Password));




// Console.WriteLine("Remove:");
// string removeClient = Console.ReadLine()!;
// int clientId = Convert.ToInt16(Console.ReadLine());
// Client clientToDelete = clientService.RemoveClient(removeClient, clientId);



    


// Console.WriteLine("Enter Client first and last name:");
// string firstName = Console.ReadLine()!;
// string lastName = Console.ReadLine()!;
// Client client = clientService.FindClient(firstName!, lastName!)!;

// Console.WriteLine("Client Name: {0}", string.Join(' ', client.FirstName, client.MiddleName, client.LastName));
// Console.WriteLine("Client Age: {0}", client.Age);
// Console.WriteLine("Client Passport Number: {0}", client.PassportNumber);
// Console.WriteLine("Client Phone:{0}", client.Phone);
// Console.WriteLine("Client Email and Password:{0}", string.Join(' ',client.Email, client.Password));


// Console.WriteLine("|||||||||||||||||||||||||||||||");



// Console.WriteLine("Enter Order Id and Description name:");
// int orderId = Convert.ToInt16(Console.ReadLine());
// string description = Console.ReadLine()!;
// Order order = orderService.FindOrder(id!, description!)!;

// Console.WriteLine("Order Info: {0}", string.Join(' ', order.Id, order.Description, order.Price));
// Console.WriteLine("Order Date: {0}", order.Date);
// Console.WriteLine("Order Address: {0}", order.Address);
// Console.WriteLine("Order Delivery Type: {0}", order.Delivery); 





// Console.WriteLine("Create:"); 
// string Create = Console.ReadLine()!;
// if (Create.Equals("Client"))
// {
//     CreateClient();
//     if (Create.Equals("Order"))
//     {
//         CreateOrder();
//     }
//     else return;
// }

// Console.WriteLine("Enter Order Id and Order State:");
// int orderId = Convert.ToInt16(Console.ReadLine());
// OrderState newOrderState = (OrderState)int.Parse(Console.ReadLine()!);
// Order order = orderService.SetState(newOrderState, orderId)!;
// Console.WriteLine("Order State: {0}", order.State);

Console.WriteLine("Create:");
string Cr = Console.ReadLine()!;
if (Cr.Equals("Order"))
{
    CreateOrder();

}

// Order counter = orderService.ShowOrderPending()!;
// Console.WriteLine("Count: {0}", counter.Count);

Order counter2 = orderService.ShowOrderCount()!;
Console.WriteLine("Order Count: {0}", counter2.Count);