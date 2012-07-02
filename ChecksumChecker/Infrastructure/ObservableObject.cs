///
/// This file was taken from the In the Box MVVM training extension
/// http://visualstudiogallery.msdn.microsoft.com/3ab5f02f-0c54-453c-b437-8e8d57eb9942/
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ChecksumChecker.Infrastructure
{
    [Serializable]
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpresssion)
        {
            var propertyName = PropertySupport.ExtractPropertyName(propertyExpresssion);
            this.RaisePropertyChanged(propertyName);
        }

        protected void RaisePropertyChanged(String propertyName)
        {
            VerifyPropertyName(propertyName);
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Warns the developer if this Object does not have a public property with
        /// the specified name. This method does not exist in a Release build.
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(String propertyName)
        {
            // verify that the property name matches a real,
            // public, instance property on this Object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                Debug.Fail("Invalid property name: " + propertyName);
            }
        }
    }
}