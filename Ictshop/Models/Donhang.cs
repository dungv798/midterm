
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
    
public partial class Donhang
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Donhang()
    {

        this.Chitietdonhangs = new HashSet<Chitietdonhang>();

    }


    public int Madon { get; set; }

    public Nullable<System.DateTime> Ngaydat { get; set; }

    public Nullable<int> Tinhtrang { get; set; }

    public Nullable<int> Makh { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }

    public virtual Khachhang Khachhang { get; set; }

}

}
