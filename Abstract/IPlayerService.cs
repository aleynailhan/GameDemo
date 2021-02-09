using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IPlayerService
    {
        void Register(Player player);
        void UpdateInformation(Player player);
        void DeleteAccount(Player player);
    }
}
