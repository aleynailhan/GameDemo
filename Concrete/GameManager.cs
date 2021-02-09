using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name+ "is deleted!");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.Name+ "is saved");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name+ "is uptaded");
        }
    }
}
