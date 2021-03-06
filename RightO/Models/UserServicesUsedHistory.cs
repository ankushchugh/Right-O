//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RightO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserServicesUsedHistory
    {
        public UserServicesUsedHistory()
        {
            this.FeedBackHistories = new HashSet<FeedBackHistory>();
            this.UserServiceInfoes = new HashSet<UserServiceInfo>();
        }
    
        public int UserServicesUsedHistoryID { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public System.DateTime ServiceDateTime { get; set; }
        public int SubCategoryID { get; set; }
        public int CustomerUserID { get; set; }
    
        public virtual CustomerUserMaster CustomerUserMaster { get; set; }
        public virtual ICollection<FeedBackHistory> FeedBackHistories { get; set; }
        public virtual SubCategoryMaster SubCategoryMaster { get; set; }
        public virtual ICollection<UserServiceInfo> UserServiceInfoes { get; set; }
    }
}
