//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPFB.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int Number_ID { get; set; }
        public int Operator_ID { get; set; }
        public double Answer1 { get; set; }
    
        public virtual Numbers Numbers { get; set; }
        public virtual Operators Operators { get; set; }
    }
}
