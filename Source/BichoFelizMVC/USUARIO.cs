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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.LOGACESSOes = new HashSet<LOGACESSO>();
        }
    
        public int IDUSUARIO { get; set; }
        public Nullable<int> IDCONTATO { get; set; }
        public string EMAIL { get; set; }
        public string SENHA { get; set; }
        public Nullable<int> STATUS { get; set; }
    
        public virtual CONTATO CONTATO { get; set; }
        public virtual ICollection<LOGACESSO> LOGACESSOes { get; set; }
    }
}