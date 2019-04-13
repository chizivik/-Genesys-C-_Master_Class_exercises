using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM.Infrastructure.Entities
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Customer Customer { get; set; }
    }
}