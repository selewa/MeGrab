using Eagle.Domain.Repositories;
using Eagle.Repositories.Lite;
using MeGrab.Domain.Models;
using MeGrab.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace MeGrab.Domain.Repositories.Lite
{
    public class TopicRepository : LiteRepository<Topic, Guid>, ITopicRepository
    {
        public TopicRepository(IRepositoryContext repositoryContext) : base(repositoryContext) 
        { 
        }
    }
}
