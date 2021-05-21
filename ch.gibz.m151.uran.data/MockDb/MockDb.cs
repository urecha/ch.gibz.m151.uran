using ch.gibz.m151.uran.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.data.MockDb
{
    public class MockDb
    {
        private static List<SimpleComment> Comments = new List<SimpleComment>();

        public void AddComment(SimpleComment comment)
        {
            Comments.Add(comment);
        }

        public List<SimpleComment> GetAll()
        {
            return Comments;
        }

    }
}
