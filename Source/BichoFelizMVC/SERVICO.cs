//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BichoFelizMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SERVICO
    {
        public int IDSERVICO { get; set; }
        public Nullable<int> IDTIPOSERVICO { get; set; }
        public Nullable<int> IDCONTATO { get; set; }
        public Nullable<int> IDANIMAL { get; set; }
        public Nullable<System.DateTime> DATAHORA { get; set; }
        public Nullable<int> PERIODO { get; set; }
        public Nullable<int> SITUACAO { get; set; }
    
        public virtual ANIMAL ANIMAL { get; set; }
        public virtual CONTATO CONTATO { get; set; }
        public virtual TIPOSERVICO TIPOSERVICO { get; set; }
    }
}