using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
