using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeilaoStatusWebService.Models;

namespace LeilaoStatusWebService.Data
{
    public class LeilaoDAO : ILeilaoDAO
    {
        public IEnumerable<Leilao> GetAll()
        {
            try
            {
                using (var contexto = new DBLeilaoEntities())
                {
                    //fazendo load das entidades filhas
                    var leiloes = contexto.Leilao
                        .Include("Lote.Produto")
                        .Include("Usuario")
                        .ToList();
                    return leiloes;                  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao buscar os leiloes do banco", e.Source);
                return new List<Leilao>();
            }
        }

        public Leilao GetById(int id)
        {
            try
            {
                using (var contexto = new DBLeilaoEntities())
                {
                    var leilao = contexto.Leilao
                      .Include("Lote.Produto")
                      .Include("Usuario")
                      .ToList()
                      .Find(l => l.LeilaoID.Equals(id));
                    return leilao;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao buscar o leilao pelo Id", e.Source);
                return null;
            }
        }
    }
}