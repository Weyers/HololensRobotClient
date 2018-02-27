using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BluetoothconnectionModel
    {
        [Required]
        public string Port { get; set; }
    }
}