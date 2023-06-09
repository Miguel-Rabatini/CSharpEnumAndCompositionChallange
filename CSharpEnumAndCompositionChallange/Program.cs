using CSharpEnumAndCompositionChallange.Entities;

Client clientData = ShowProgram.ClientDataSection();
Order orderData = ShowProgram.OrderDataSection(clientData);
Order itemData = ShowProgram.ItemDataSection(orderData);
ShowProgram.Summary(itemData);