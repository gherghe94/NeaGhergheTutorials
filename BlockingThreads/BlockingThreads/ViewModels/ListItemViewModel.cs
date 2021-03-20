using Prism.Mvvm;

namespace BlockingThreads.ViewModels
{
    public class ListItemViewModel : BindableBase
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} with: {Price}$";
        }
    }
}
