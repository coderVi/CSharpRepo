namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir = 3;
            int sutun = 3;

            for (int i = 1; i <= satir; i++)
            {
                for (int j = 1; j <= sutun; j++)
                {
                    // matrisin köşelerini oluşturmak için " * " sembolünü kullanmak için koşul belirtimi
                    if (i == 1 && j == 1 || i == 1 && j == sutun || i == satir && j == 1 || i == satir && j == sutun)
                    {
                        Console.Write("*");
                    }
                    // matrisin çervesini oluşturmak için " - " harfini kullanmak için koşul belirtimi
                    else if (i == 1 || i == satir || j == 1 || j == sutun)
                    {
                        Console.Write("-");
                    }
                    // matrisin içini oluşturmak için kullanıyoruz
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}