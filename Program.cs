using System;
using Unity;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IGame, Trivial>();
            var game = unityContainer.Resolve<IGame>();
            game.AddPlayer();
            game.AddPlayer();
            Console.WriteLine(string.Format("{0} Personas jugando a {1}",
                game.CurrentPlayers, game.Name));
            Console.ReadLine();
            var table = unityContainer.Resolve<Table>();
            table.Play();

            Console.WriteLine(table.GameStatus());
            Console.ReadLine();
        }
    }
    Console.WriteLine("precione Escape para detener");
    ConsoleKey tecla;

    do
    {
    while(!Console.KeyAvailable)
        {
        //toDo movimiento del auto
        }
tecla = Console.ReadKey(true).Key;
// HACER ALGO CON LA TECLA : DIRECION DEL AUTO
}
while (tecla != ConsoleKey.Escape) ;

}




