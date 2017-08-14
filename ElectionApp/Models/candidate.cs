using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionApp.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public int Votes { get; set; }
    }
    public enum Post
    {
        President = 1,
        Vice,
        Secretary,
        Projects
    }
}