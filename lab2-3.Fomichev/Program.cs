int kievOneWayPrice = 500;
int kievRoundTripPrice = 750;
int kharkivOneWayPrice = 400;
int kharkivRoundTripPrice = 600;
int donetskOneWayPrice = 350;
int donetskRoundTripPrice = 550;
int lvivOneWayPrice = 600;
int lvivRoundTripPrice = 900;

Console.WriteLine("Выберите направление полета:");
Console.WriteLine("1. Киев");
Console.WriteLine("2. Харьков");
Console.WriteLine("3. Донецк");
Console.WriteLine("4. Львов");

int direction = 0;
while (direction < 1 || direction > 4)
{
    Console.Write("Введите номер направления: ");
    if (!int.TryParse(Console.ReadLine(), out direction))
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число от 1 до 4.");
        continue;
    }
}

Console.WriteLine("Выберите тип путешествия:");
Console.WriteLine("1. В одном направлении");
Console.WriteLine("2. В двух направлениях");

int tripType = 0;
while (tripType < 1 || tripType > 2)
{
    Console.Write("Введите номер типа путешествия: ");
    if (!int.TryParse(Console.ReadLine(), out tripType))
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число 1 или 2.");
        continue;
    }
}

Console.Write("Введите количество дней до вылета: ");
int daysToDeparture = 0;
if (!int.TryParse(Console.ReadLine(), out daysToDeparture) || daysToDeparture < 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное целое число.");
    return;
}

int ticketPrice = 0;

switch (direction)
{
    case 1:
        ticketPrice = (tripType == 1) ? kievOneWayPrice : kievRoundTripPrice;
        break;
    case 2:
        ticketPrice = (tripType == 1) ? kharkivOneWayPrice : kharkivRoundTripPrice;
        break;
    case 3:
        ticketPrice = (tripType == 1) ? donetskOneWayPrice : donetskRoundTripPrice;
        break;
    case 4:
        ticketPrice = (tripType == 1) ? lvivOneWayPrice : lvivRoundTripPrice;
        break;
}

if (daysToDeparture >= 45)
{
    ticketPrice = (int)(ticketPrice * 0.8);
}
else if (daysToDeparture >= 20)
{
    ticketPrice = (int)(ticketPrice * 0.9);
}

Console.WriteLine($"Стоимость заказа: {ticketPrice} грн");