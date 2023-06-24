﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Commentler
    {
        [Key]
        public int CommentId { get; set; }
        //public string? CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string? CommentCondent { get; set; }
        public bool CommentState { get; set; }

       
        public int? DestinationID { get; set; }
        public Destination? Destination { get; set; }

        public int AppUserID { get; set; }
        public AppUser? AppUser { get; set; }
       
    }
}
