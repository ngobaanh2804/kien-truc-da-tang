using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cukcuk.BL.Entity;
using Cukcuk.EntityModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cukcuk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly EmployeeBL employeeBL;

        public EmployeesController()
        {
            this.employeeBL = new EmployeeBL();
        }

        /// <summary>
        /// Lấy tất cả nhân viên
        /// </summary>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: NBAnh(25/12/2020)
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = employeeBL.GetAll();

            if (employees != null)
            {
                return Ok(employees);
            }

            return BadRequest();
        }

        /// <summary>
        /// Lấy thông tin nhân viên theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Thông tin nhân viên</returns>
        /// CreatedBy: NBAnh(25/12/2020)
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = employeeBL.GetById(id);
            return Ok(employee);
        }

        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        /// CreatedBy: NBAnh(25/12/2020)
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            var result = employeeBL.InsertData(employee);

            if (result)
            {
                return StatusCode(201, employee);
            }

            return BadRequest();
        }

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        /// CreatedBy: NBAnh(25/12/2020)
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Employee employee)
        {
            var result = employeeBL.UpdateData(employee);

            {
                if (result)
                {
                    return Ok(employee);
                }

                return BadRequest();
            }
        }

        /// <summary>
        /// Xóa nhân viên theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// CreatedBy: NBAnh(25/12/2020)
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = employeeBL.DeleteData(id);
            return Ok(employee);
        }
    }
}
