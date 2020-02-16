using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CryptocurrencyAdressGenerator.ViewModel.Implementation
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Support set property

        protected virtual bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null, Func<T, T, bool> validateValue = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            if (validateValue != null && !validateValue(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            NotifyPropertyChanged(propertyName);
            return true;
        }

        #endregion

        #region Support alert
        
        internal event Func<string, Task> DoDisplayAlert;

        public Task DisplayAlertAsync(string message)
        {
            return DoDisplayAlert?.Invoke(message) ?? Task.CompletedTask;
        }

        #endregion

        #region Support notify property changed

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
   
     
    }
}