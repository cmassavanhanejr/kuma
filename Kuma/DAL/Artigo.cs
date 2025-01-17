//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artigo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artigo()
        {
            this.ArtigoArmazems = new HashSet<ArtigoArmazem>();
            this.ArtigoPessoas = new HashSet<ArtigoPessoa>();
            this.Doadoes = new HashSet<Doado>();
        }
    
        public System.Guid id { get; set; }
        public string designacao { get; set; }
        public string descricao { get; set; }
        public Nullable<int> idCategoria { get; set; }
        public int referencia { get; set; }
        public Nullable<System.DateTime> createOn { get; set; }
        public Nullable<System.DateTime> removeOn { get; set; }
        public Nullable<System.DateTime> perdidoEm { get; set; }
        public Nullable<System.DateTime> achadoEm { get; set; }
        public Nullable<System.Guid> idEmpresa { get; set; }
        public Nullable<System.Guid> createBy { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtigoArmazem> ArtigoArmazems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtigoPessoa> ArtigoPessoas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doado> Doadoes { get; set; }
    }
}
