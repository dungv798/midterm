
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Midterm_205052061.Ictshop.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Hedieuhanh
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Hedieuhanh()
    {

        this.Sanphams = new HashSet<Sanpham>();

    }


    public int Mahdh { get; set; }

    public string Tenhdh { get; set; }

    public string Mota { get; set; }



    public virtual Hedieuhanh Hedieuhanh1 { get; set; }

    public virtual Hedieuhanh Hedieuhanh2 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sanpham> Sanphams { get; set; }

}

}
