//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDemotivator
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demotivator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Demotivator()
        {
            this.tag_to_dem = new HashSet<tag_to_dem>();
            this.rates = new HashSet<rate>();
        }
    
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public string Url_Img { get; set; }
        public string Url_Img_Origin { get; set; }
        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public string Rate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tag_to_dem> tag_to_dem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate> rates { get; set; }
    }
}
