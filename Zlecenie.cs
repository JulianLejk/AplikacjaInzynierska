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
    
    public partial class Zlecenie
    {
        public decimal ID_KZ { get; set; }
        public decimal ID_Zlecenia { get; set; }
        public decimal ID_Pracownika { get; set; }
        public string Nazwa_Zlecenia { get; set; }
        public Nullable<System.DateTime> Data_Rozpoczecia { get; set; }
        public Nullable<System.DateTime> Data_Zakonczenia { get; set; }
    
        public virtual Kontrahent_Zleceniodawca Kontrahent_Zleceniodawca { get; set; }
        public virtual Pracownik Pracownik { get; set; }
    }
}