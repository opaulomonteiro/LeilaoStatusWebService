using LeilaoStatusWebService.Models;
using System.Collections.Generic;

namespace LeilaoStatusWebService.Data
{
    public class LeilaoService
    {
        private ILeilaoDAO dao = new LeilaoDAO();

        public IEnumerable<Leilao> GetAll()
         {
             return dao.GetAll();
         }
 
         public Leilao GetById(int id)
         {
             return dao.GetById(id);
         }
    }
}