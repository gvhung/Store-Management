//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace storeManager.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class LabelSetting
    {
        public int id { get; set; }
        public Nullable<int> ListStart { get; set; }
        public Nullable<int> ListEnd { get; set; }
        public Nullable<int> LabelLenghth { get; set; }
        public Nullable<int> QtyToPrint { get; set; }
        public string BarcodeType { get; set; }
        public string BorderType { get; set; }
        public string FontFamily { get; set; }
        public string ForeColor { get; set; }
        public Nullable<int> BarHeight { get; set; }
        public Nullable<int> FontSize { get; set; }
        public Nullable<bool> ShowTest { get; set; }
        public Nullable<bool> ShowBorder { get; set; }
        public Nullable<bool> ShowCheckSum { get; set; }
    }
}
