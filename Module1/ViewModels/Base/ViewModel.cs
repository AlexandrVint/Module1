using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Module1.Annotations;

namespace Module1.ViewModels.Base
{
    public abstract class ViewModel : INotifyPropertyChanged
    {

        #region Реализация интерфейса INotifyPropertyChanged минимально необходимое

        /// <summary>
        /// реализация интерфейса INotifyPropertyChanged минимально необходимое
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Регистрация изменений цепочки свойств

        // регистрация изменения свойст по цепочке 

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        #endregion

        //

    }

          

}
