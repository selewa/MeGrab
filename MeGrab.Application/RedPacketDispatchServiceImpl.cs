using Eagle.Domain;
using Eagle.Domain.Application;
using Eagle.Domain.Repositories;
using MeGrab.DataObjects;
using MeGrab.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeGrab.Application
{
    public class RedPacketDispatchServiceImpl : ApplicationService, IRedPacketDispatchService
    {
        public RedPacketDispatchServiceImpl(IRepositoryContext repositoryContext) : base(repositoryContext) { }

        public void Dispatch(DispatchRequest dispatchRequest)
        {
            throw new NotImplementedException();
        }

    }
}
