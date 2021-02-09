using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Sales:IEntitiy
    {
        public int SaleId { get; set; }
        public string GameName { get; set; }
        public string PlayerName { get; set; }
    }
}
