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
    
    public partial class M_otrule
    {
        public string ot_grp { get; set; }
        public string ot_type { get; set; }
        public Nullable<bool> type_id { get; set; }
        public Nullable<decimal> ot_amt_h { get; set; }
        public string ot_amt_cal { get; set; }
        public string otid { get; set; }
        public string myuser { get; set; }
        public Nullable<System.DateTime> mydate { get; set; }
    
        public virtual M_otgrp M_otgrp { get; set; }
        public virtual M_ottype M_ottype { get; set; }
    }
}