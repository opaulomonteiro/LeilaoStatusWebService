//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeilaoStatusWebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        public int ID { get; set; }
        public string BreveDescricao { get; set; }
        public string DescricaoCompleta { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> Lote_LoteID { get; set; }
    
        public virtual Lote Lote { get; set; }
    }
}
