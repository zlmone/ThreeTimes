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
    
    public partial class QuestionClass_T
    {
        public QuestionClass_T()
        {
            this.Question_T = new HashSet<Question_T>();
        }
    
        public int QuestionClass_Id { get; set; }
        public string QusetionClass_ClassName { get; set; }
    
        public virtual ICollection<Question_T> Question_T { get; set; }
    }
}
