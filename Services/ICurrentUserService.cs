using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoustacheApp.Services
{
    public interface ICurrentUserService
    {
        string GetCurrentUserName();
    }
}