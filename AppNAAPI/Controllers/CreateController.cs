using AppNAAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AppNAAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateController : ControllerBase
    {
        private readonly AppNauAnContext dbcontext;
        public CreateController(AppNauAnContext context)
        {
            dbcontext = context;
        }

        [HttpPost]
        [Route("addall")]
        public IActionResult addall(string @tenloai, string @tenmon, 
            string @congthuclam, string @tgnau, string @dokho,
             string @anhmonlvo, string @tendangnhap, string @tennguyenlieu1,
              string @khoiluong1, string @tennguyenlieu2, string @khoiluong2,
               string @tennguyenlieu3, string @khoiluong3, string @tennguyenlieu4,
               string @khoiluong4,string @cachlam, string @anhcachlam1, string @anhcachlam2,
               string @anhcachlam3)
        {

            string query = "EXEC duyhieu.addallatonce @tenloai, @tenmon," +
                "@congthuclam,@tgnau,@dokho,@anhmonlvo,@tendangnhap,@tennguyenlieu1," +
                "@khoiluong1, @tennguyenlieu2, @khoiluong2@tennguyenlieu3@khoiluong3," +
                "@tennguyenlieu4,@khoiluong4,@cachlam, @anhcachlam1, @anhcachlam2, @anhcachlam3";

            List<SqlParameter> parms = new List<SqlParameter>
        {
            new SqlParameter { ParameterName = "@tenloai", Value = tenloai },
            new SqlParameter { ParameterName = "@tenmon", Value = tenmon },
            new SqlParameter { ParameterName = "@congthuclam", Value = congthuclam },
            new SqlParameter { ParameterName = "@tgnau", Value = tgnau },
            new SqlParameter { ParameterName = "@dokho", Value = dokho },
            new SqlParameter { ParameterName = "@anhmonlvo", Value = anhmonlvo },
            new SqlParameter { ParameterName = "@tendangnhap", Value = tendangnhap },
            new SqlParameter { ParameterName = "@tennguyenlieu1", Value = tennguyenlieu1 },
            new SqlParameter { ParameterName = "@khoiluong1", Value = khoiluong1 },
            new SqlParameter { ParameterName = "@tennguyenlieu2", Value = tennguyenlieu2 },
            new SqlParameter { ParameterName = "@khoiluong2", Value = khoiluong2 },
            new SqlParameter { ParameterName = "@tennguyenlieu3", Value = tennguyenlieu3 },
            new SqlParameter { ParameterName = "@khoiluong3", Value = khoiluong3 },
            new SqlParameter { ParameterName = "@tennguyenlieu4", Value = tennguyenlieu4 },
            new SqlParameter { ParameterName = "@cachlam", Value = cachlam },
            new SqlParameter { ParameterName = "@anhcachlam1", Value = anhcachlam1 },
            new SqlParameter { ParameterName = "@anhcachlam2", Value = anhcachlam2 },
            new SqlParameter { ParameterName = "@anhcachlam3", Value = anhcachlam3 },

        };

            var result = dbcontext.Database.ExecuteSqlRaw(query, parms);
            return Ok(result);
        }

    }
}
