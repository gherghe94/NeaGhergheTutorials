using BlockingThreads.Models;
using BlockingThreads.Services.Contracts;
using BlockingThreads.Services.Impl;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BlockingThreads.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IDbService _dbService = new DbService();
        private ObservableCollection<ListItemViewModel> _dbItems;
        private string _state;

        public string State { get => _state; set => SetProperty(ref _state, value); }

        public ICommand GetFromDbCommand { get; private set; }
        public ICommand GetFromDbCommandAsync { get; private set; }
        public ICommand SayHiCommand { get; private set; }

        public ObservableCollection<ListItemViewModel> DbItems
        {
            get => _dbItems;
            private set => SetProperty(ref _dbItems, value);
        }

        public MainViewModel()
        {
            GetFromDbCommand = new DelegateCommand(ExecuteSync);
            GetFromDbCommandAsync = new DelegateCommand(ExecuteAsync);
            SayHiCommand = new DelegateCommand(SayHi);

            DbItems = new ObservableCollection<ListItemViewModel>();
        }

        private void SayHi()
        {
            MessageBox.Show("Hello user!");
        }

        private void ExecuteAsync()
        {
            DbItems = null;
            State = "Loading Async ... ";

            Task.Factory.StartNew(async () =>
            {
                var dbItems = await _dbService.GetAllAsync();
                DbItems = new ObservableCollection<ListItemViewModel>(dbItems.Select(CreateViewModel));
                State = "Finished Async";
            });

            Console.WriteLine("SE INTAMPLA INSTANT");
        }

        private void ExecuteSync()
        {
            DbItems = null;
            State = "Loading Sync ... ";

            var dbItems = _dbService.GetAll();
            DbItems = new ObservableCollection<ListItemViewModel>(dbItems.Select(CreateViewModel));

            State = "Finished Sync";
        }

        private ListItemViewModel CreateViewModel(DbItem arg)
        {
            return new ListItemViewModel
            {
                Name = arg.Name,
                Price = arg.Price
            };
        }
    }
}
