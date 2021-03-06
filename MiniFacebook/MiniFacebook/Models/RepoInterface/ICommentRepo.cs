﻿using MiniFacebook.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Models.RepoInterface
{
    public interface ICommentRepo
    {
        public IEnumerable<Comment> loadPostComments(int PostID);
        public Comment getPostComment(DateTime comDate, string uid);
        public void addComment(Comment c);
    }
}
