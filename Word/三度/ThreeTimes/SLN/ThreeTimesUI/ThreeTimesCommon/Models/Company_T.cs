//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeTimesCommon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company_T
    {
        public Company_T()
        {
            this.Aamin_T = new HashSet<Admin_T>();
            this.Questionnarire_T = new HashSet<Questionnarire_T>();
            this.User_T = new HashSet<User_T>();
        }
    
        public long Company_Id { get; set; }
        public string Company_Name { get; set; }
        public int Company_Level { get; set; }
        public string Company_Industry { get; set; }
        public string Company_Province { get; set; }
        public long Company_OwerId { get; set; }
        public int Company_State { get; set; }
    
        public virtual ICollection<Admin_T> Aamin_T { get; set; }
        public virtual ICollection<Questionnarire_T> Questionnarire_T { get; set; }
        public virtual ICollection<User_T> User_T { get; set; }
    }
}
