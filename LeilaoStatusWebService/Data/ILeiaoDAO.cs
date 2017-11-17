using LeilaoStatusWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoStatusWebService.Data
{
    interface ILeilaoDAO
    {
        IEnumerable<Leilao> GetAll();
        Leilao GetById(int id);        
    }
}
