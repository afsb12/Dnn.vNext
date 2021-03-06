﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UserAuthentication
    {
        [Key]
        /*PK*/
        public int UserAuthenticationId { get; set; }
        /*FK*/
        public int UserId { get; set; }
        public string AuthenticationType { get; set; }
        public string AuthenticaitonToken { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual User User { get; set; }
    }
}
