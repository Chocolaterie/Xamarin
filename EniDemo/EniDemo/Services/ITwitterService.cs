using EniDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Services
{
    public interface ITwitterService
    {

        bool authenticate(String email, String password);

        List<Tweet> getTweets(String email);
    }
}
