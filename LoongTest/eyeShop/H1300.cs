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
    
    public partial class H1300
    {
        public string job_no { get; set; }
        public string item_no { get; set; }
        public string distribute_code { get; set; }
        public string file_no { get; set; }
        public int seq_no { get; set; }
        public decimal qty { get; set; }
        public decimal qty_f { get; set; }
        public Nullable<decimal> qty_bal { get; set; }
        public bool distribute_flag { get; set; }
        public string sfile_no { get; set; }
        public int status_code { get; set; }
        public System.DateTime require_date { get; set; }
        public Nullable<System.DateTime> repl_date { get; set; }
        public bool approve { get; set; }
        public decimal part_per { get; set; }
        public string myuser { get; set; }
        public System.DateTime mydate { get; set; }
        public long AutoId { get; set; }
        public Nullable<bool> Loc { get; set; }
        public Nullable<int> LocUseSeq { get; set; }
        public bool lockmat { get; set; }
        public string Cust_Code { get; set; }
        public string Cust_Po { get; set; }
        public Nullable<System.DateTime> So_Ftd { get; set; }
        public string OurModel { get; set; }
        public string YourModel { get; set; }
        public string So_No { get; set; }
    }
}