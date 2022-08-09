using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeModel>>
    {
        public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
