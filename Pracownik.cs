//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikacjaInzynierska
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pracownik
    {
        public Pracownik()
        {
            this.Zlecenie = new HashSet<Zlecenie>();
        }
    
        public decimal ID_Pracownika { get; set; }
        public bool Czy_nasz { get; set; }
        public string Imie_Pracownika { get; set; }
        public string Nazwisko_Pracownika { get; set; }
        public decimal Stawka_h { get; set; }
    
        public virtual ICollection<Zlecenie> Zlecenie { get; set; }
    }
}
