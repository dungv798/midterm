
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
    
public partial class Khachhang
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Khachhang()
    {

        this.Donhangs = new HashSet<Donhang>();

    }


    public int Makh { get; set; }

    public string Tenkh { get; set; }

    public string Dienthoai { get; set; }

    public string Taikhoan { get; set; }

    public string Matkhau { get; set; }

    public string Email { get; set; }

    public string Diachi { get; set; }

    public string Gioitinh { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Donhang> Donhangs { get; set; }

}

}
