using System;
using System.Collections.Generic;
using TazedirektsonAPI.Core.Models;

namespace TazedirektsonAPI.Domain.Models
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int Adet { get; set; }
        public int UserId { get; set; }
        public int ProductID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
