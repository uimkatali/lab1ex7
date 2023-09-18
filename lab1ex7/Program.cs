namespace lab1ex7
{

    class Program

    /*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
    impar
    */
    {
        static void Main(string[] args)
        {
            int numar = Convert.ToInt32(Console.ReadLine());
            if(numar % 2 == 0 ) {
                Console.WriteLine("Numar par!");
            }
            else { Console.WriteLine("Numar impar"); }
        }
    }
}