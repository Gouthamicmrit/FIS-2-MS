//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class sample
    {        
        public int Eid { get; set; }
       
        public string ename { get; set; }
        public string eaddress { get; set; }
        public string email { get; set; }
        public string ephone { get; set; }
        public Nullable<double> esalary { get; set; }
    }
}
