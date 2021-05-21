using ch.gibz.m151.uran.data.MockDb;
using ch.gibz.m151.uran.data.Models;
using System;
using System.Collections.Generic;

namespace ch.gibz.m151.uran.business
{
    public class CommentRepository
    {
        public void saveComment(SimpleComment comment)
        {
            new MockDb().AddComment(comment);
        }

        public List<SimpleComment> getAll()
        {
            return new MockDb().GetAll();
        }
    }
}
