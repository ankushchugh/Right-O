//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RightO
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkLocationsMaster
    {
        public WorkLocationsMaster()
        {
            this.ProUserWorkLocationMappings = new HashSet<ProUserWorkLocationMapping>();
        }
    
        public int WorkLocationMasterID { get; set; }
        public string WorkLocation { get; set; }
    
        public virtual ICollection<ProUserWorkLocationMapping> ProUserWorkLocationMappings { get; set; }
    }
}