using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BasketApp.Model
{
    public class BasketModel
    {
        public IEnumerable<BasketItemModel> Items { get; set; }
        public BasketModel()
        {
            this.Items = new Collection<BasketItemModel>();
        }
    }
}
