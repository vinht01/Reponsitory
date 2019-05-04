using System;
using System.Collections.Generic;
using System.Text;
using ShopOnline.Data.Enums;

namespace ShopOnline.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
