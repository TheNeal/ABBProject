using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;


namespace MyAABExample.ViewModel
{
    public class ShellViewModel : BindableBase
    {
        private string _curresntTime;
        public string CurrentTime
        {
            get { return this._curresntTime;}
            set{SetProperty(ref this._curresntTime,value);}
        }

        public ShellViewModel()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.IsEnabled = true;
            UpdateTime();
            timer.Tick += (s, e) =>
            {
                UpdateTime();
            };
        }
        void UpdateTime()
        {
            CurrentTime = DateTime.Now.ToShortTimeString();
        }
    }
}
