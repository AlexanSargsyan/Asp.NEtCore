using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public bool? WillAttend { set; get; }
      
    }
}
