using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionApp.Models
{
    public class Candidates
    {
        public int id {get; set;}
        //public image image { get; set; }
        public string name { get; set; }
        public string post { get; set; }
        public int votes { get; set; }
    }
    public enum post
    {
        President = 1,
        Vice_President,
        Secretary
    }
}