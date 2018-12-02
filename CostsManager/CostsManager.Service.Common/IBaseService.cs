using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Service.Common
{
    public interface IBaseSerivce<TModel, TFilter>
    {
        IEnumerable<TModel> GetAll();

        IEnumerable<TModel> Find(TFilter filter);

        TModel Insert(TModel item);

        TModel Update(TModel item);

        bool delete(Guid itemId);
    }
}
