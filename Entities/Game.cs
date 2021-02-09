using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game:IEntitiy
    {
        internal object payment_;

        public int GameId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
