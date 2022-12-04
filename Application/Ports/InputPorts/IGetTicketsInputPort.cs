using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ports.InputPorts
{
    public interface IGetTicketsInputPort
    {
        Task GetTicketsHandle();
    }
}
