using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cukcuk.BL.Entity;
using Cukcuk.EntityModel.Enums;
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

            var result = new ServiceResult();

            if (employees != null)
            {
                result.Message = "Success";
                result.ApplicationSatusCode = 200;
                result.Data = employees;
            }
            else
            {
                result.Message = "Fail";
                result.ApplicationSatusCode = 400;
            }

            return StatusCode(result.ApplicationSatusCode, result);
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

            var result = new ServiceResult();

            if (id != null)
            {
                result.Message = "Success";
                result.ApplicationSatusCode = 200;
                result.Data = employee;
            }
            else
            {
                result.Message = "Fail";
                result.ApplicationSatusCode = 400;
            }

            return StatusCode(result.ApplicationSatusCode, result);
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
            var Employee = employeeBL.InsertData(employee);

            var result = new ServiceResult();


            if (Employee)
            {
                result.Message = "Success";
                result.ApplicationSatusCode = 200;
                result.Data = Employee;
            }

            else
            {
                result.Message = "Fail";
                result.ApplicationSatusCode = 400;
            }
            return StatusCode(result.ApplicationSatusCode, employee);
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
            var Employee = employeeBL.UpdateData(employee);

            {
                if (Employee)
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
        public IActionResult Delete(Guid id)
        {
            var employee = employeeBL.DeleteData(id);
            return Ok(employee);
        }
    }
}
