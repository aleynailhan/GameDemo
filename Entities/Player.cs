using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Player: IEntitiy
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
