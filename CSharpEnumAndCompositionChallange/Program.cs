using CSharpEnumAndCompositionChallange.Entities;

Client client = ProgramManager.GetClientData();
Order order = ProgramManager.GetOrderData(client);
ProgramManager.GetOrderItems(order);

Console.WriteLine();
Console.WriteLine(order);