using Microsoft.Toolkit.Uwp.Helpers;
using ServiceLayer;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MemelordAssistant
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private IEnumerable<IProviderAdapter> m_Providers;
        private string m_TEsto;

        public string Testo
        {
            get
            {
                return m_TEsto;
            }
            set
            {
                m_TEsto = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<ResultItemModel> Result { get; set; }

        public MainPageViewModel()
        {
            m_Providers = ProviderAdapterFactory.GetAllProviderAdapters();
            Task.Factory.StartNew(async () =>
            {
                var results = await m_Providers.First().GetItems(1);
                Result = new ObservableCollection<ResultItemModel>(results);
                await DispatcherHelper.ExecuteOnUIThreadAsync(() => NotifyPropertyChanged(nameof(Result)));
                //foreach (var result in results)
                //{
                //    Result.Add(result);
                //}
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName]string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
