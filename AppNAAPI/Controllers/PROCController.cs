using AppNAAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AppNAAPI.Controllers
{

    [Route("api/")]
    [ApiController]
    public class PROCController : ControllerBase
    {
        private readonly AppNauAnContext dbcontext;
        public PROCController(AppNauAnContext context)
        {
            dbcontext = context;
        }
        [HttpGet]
        [Route("NguyenlieuinFoodfinfo")]
        public IActionResult NguyenlieuinFoodfinfo(int mamon)
        {
            string query = "EXEC dbo.NguyenlieuinFoodinfo @mamon=" + mamon;
            var result = dbcontext.NguyenlieuinFoodfinfoClasses.FromSqlRaw(query).AsEnumerable().ToList();
            return Ok(result);
        }
        [HttpGet]
        [Route("Fragnddb")]
        public IActionResult Fragnddb(string tendangnhap)
        {
            string query = "EXEC dbo.Fragnddb @tendangnhap=" + tendangnhap;
            var result = dbcontext.Fragnddbs.FromSqlRaw(query).AsEnumerable().ToList();
            return Ok(result);
        }
        [HttpGet]
        [Route("Fragndsave")]
        public IActionResult Fragndsave(string tendangnhap)
        {
            string query = "EXEC dbo.Fragndsave @tendangnhap=" + tendangnhap;
            var result = dbcontext.Fragnddbs.FromSqlRaw(query).AsEnumerable().ToList();
            return Ok(result);
        }
        [HttpGet]
        [Route("Foodinfo")]
        public IActionResult Foodinfo()
        {
            string query = "EXEC dbo.Foodinfo";
            var result = dbcontext.Foodinfos.FromSqlRaw(query).AsEnumerable().ToList();
            return Ok(result);
        }
        [HttpGet]
        [Route("LoaiFoodinfotest")]
        public IActionResult Foodinfo2()
        {

            var result = dbcontext.Loaimons
                .Select (m => new
                {
                    Loaimon = m,
                    mons = m.Mons
                }
                )
                .ToList();
            return Ok(result);
        }
        [HttpGet]
        [Route("LoaiFoodinfo2")]
        public IActionResult Foodinfo3()
        {

            var result = dbcontext.Loaimons
                .Include(lm => lm.Mons)
                    .ThenInclude(m => m.Congthucnguyenlieus)
                        .ThenInclude(c => c.ManguyenlieuNavigation)
                .Include(lm => lm.Mons)
                    .ThenInclude(m => m.Anhmonans)

                .ToList();
            return Ok(result);
        }
        [HttpGet]
        [Route("a")]
        public IActionResult test()
        {
            var result = dbcontext.Loaimons
                .FirstOrDefault();
            return Ok(result);
        }






    }
}
