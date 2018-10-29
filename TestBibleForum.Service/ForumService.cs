using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestBibleForum.Data;
using TestBibleForum.Data.Models;

namespace TestBibleForum.Service
{
    public class ForumService : IForum
    {
        private ApplicationDbContext _dbContext;

        public ForumService(ApplicationDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _dbContext.Forums
                .Include(forum => forum.Posts);
        }

        public IEnumerable<ApplicationUser> GetApplicationUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
