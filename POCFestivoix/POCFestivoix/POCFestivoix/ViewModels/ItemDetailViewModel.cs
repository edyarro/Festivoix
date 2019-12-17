using System.Collections.Generic;

namespace POCFestivoix.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public IEnumerable<string> Items { get; set; }

        public ItemDetailViewModel()
        {
        }
    }
}
