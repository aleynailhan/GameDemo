using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SteamPlayerManager : BasePlayerManager
    {
        IPlayerCheckService _playerCheckService;

        public SteamPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Register(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player)) // true ise
            {
                base.Register(player);

            }
            else
            {

                throw new Exception("Not a valid person!");

            }
        }
    }
}

  
    

