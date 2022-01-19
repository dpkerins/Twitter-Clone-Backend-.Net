using System;
namespace Twitter_Backend.Models
{
    public class Tweet
    {
        public long Id { get; set; }
        public string Body { get; set; }
        public long User_Id { get; set; }
    }
}
