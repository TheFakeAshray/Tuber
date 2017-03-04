using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace API.Models.DataModels
{
    public class BaseDataModel
    {
        [Key]
        public int Id { get; set; }
    }
}
//the Id field on a DB Model is the primary key, since all tables will need a primary key we simple make this then inherit from it on all tables
