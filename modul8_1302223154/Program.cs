// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig read = new BankTransferConfig();
        read.SetDefault();

        string Lang = read.config.Lang;
    }
}
