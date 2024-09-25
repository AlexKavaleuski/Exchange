using Exchange;

try
{
    Console.WriteLine("Hello, World!");

    var input = Console.ReadLine();

    var currencyProvider = new HardcodedCurrencyProvider();
    var currencyConverter = new CurrencyConverter(currencyProvider);
    var exchangeService = new ExchangeService(currencyConverter);

    var result = exchangeService.Convert(input);

    Console.WriteLine(result);
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}
