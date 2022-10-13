using EniDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EniDemo.Services
{
    public class TwitterServiceMock : ITwitterService
    {
        public bool authenticate(string email, string password)
        {
            // Mock persons
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 4; i++)
            {
                persons.Add(new Person { Email = $"Pierre{i}@gmail.com", Password = $"password{i}" });
            }

            // Recherche Linq
            Person person = persons.FirstOrDefault(currentPerson => currentPerson.Email == email && currentPerson.Password == password);

            if (person != null)
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
                tweets.Add(new Tweet { Author = $"Pierre{i}", Message = $"Message test {i}" });
            }

            return tweets;
        }
    }
}
