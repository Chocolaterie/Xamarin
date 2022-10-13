using EniDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Services
{
    public class TwitterServiceMock : ITwitterService
    {

        public bool authenticate(string email, string password)
        {
            if (email.Equals("pierre-dans-leau@gmail.com") && password == "password")
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets(string email)
        {
            List<Tweet> tweets = new List<Tweet>();

            for (int i = 0; i < 10; i++)
            {
                tweets.Add(new Tweet { Author = $"Pierre{i}", Message = $"Message test {i}" })
            }

            return tweets;
        }
    }
}
