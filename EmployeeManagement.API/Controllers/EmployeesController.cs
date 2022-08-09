using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<EmployeeModel>> Get()
        {
            var employeeList = new GetEmployeeListQuery();
        return await _mediator.Send(employeeList);
        }
    }
}
