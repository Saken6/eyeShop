//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace eyeShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_basepolicy
    {
        public int myid { get; set; }
        public Nullable<bool> automatch { get; set; }
        public string wt_in_type { get; set; }
        public Nullable<decimal> wt_in_hour { get; set; }
        public string wt_out_type { get; set; }
        public Nullable<decimal> wt_out_hour { get; set; }
        public string ot_in_type { get; set; }
        public Nullable<decimal> ot_in_hour { get; set; }
        public string ot_out_type { get; set; }
        public Nullable<decimal> ot_out_hour { get; set; }
        public Nullable<bool> late_to_ot { get; set; }
        public Nullable<decimal> late_hour { get; set; }
        public Nullable<bool> early_to_ot { get; set; }
        public Nullable<decimal> early_hour { get; set; }
        public string myuser { get; set; }
        public Nullable<System.DateTime> mydate { get; set; }
    }
}
