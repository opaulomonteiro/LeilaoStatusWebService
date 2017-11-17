using System.Web.Http;
using System.Web.Http.Description;
using LeilaoStatusWebService.Models;
using LeilaoStatusWebService.Data;
using System.Collections.Generic;

namespace LeilaoStatusWebService.Controllers
{
    public class LeilaoController : ApiController
    {
        private LeilaoService service = new LeilaoService();

        // GET: api/Leilao
        public IEnumerable<Leilao> GetLeiloes()
        {
            IEnumerable<Leilao> leilao = service.GetAll();
            return leilao;
        }

        // GET: api/Leilao/5
        [ResponseType(typeof(Leilao))]
        public IHttpActionResult GetLeilao(int id)
        {
            Leilao leilao = service.GetById(id);
            if (leilao == null)
            {
                return NotFound();
            }

            return Ok(leilao);
        }

    }
}