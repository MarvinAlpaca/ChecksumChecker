using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

using ChecksumChecker.Command;
using ChecksumChecker.Model;

namespace ChecksumChecker.ViewModel
{
    public class ChecksumDetailsViewModel : INotifyPropertyChanged
    {
        private string fileName;

        public ChecksumDetailsViewModel()
        {
            this.ChecksumModel = new ChecksumModel();

            FileBrowser = new BrowseFileCommand(this);
            ChecksumCheck = new ComputeChecksumCommand(this);
        }

        public ChecksumModel ChecksumModel { get; set; }

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                NotifyPropertyChange("FileName");
            }
        }

        public string ActualChecksum
        {
            get { return ChecksumModel.ActualChecksum; }
            set
            {
                this.ChecksumModel.ActualChecksum = value;
                NotifyPropertyChange("ActualChecksum");
                NotifyPropertyChange("ChecksumMatch");
            }
        }

        public string ExpectedChecksum
        {
            get { return ChecksumModel.ExpectedChecksum; }
            set
            {
                this.ChecksumModel.ExpectedChecksum = value;
                NotifyPropertyChange("ExpectedChecksum");
                NotifyPropertyChange("ChecksumMatch");
            }
        }

        public bool ChecksumMatch
        {
            get { return ChecksumModel.ChecksumMatch; }
        }

        public ICommand FileBrowser
        {
            get;
            set;
        }

        public ICommand ChecksumCheck
        {
            get;
            set;
        }

        private Boolean CanExecute()
        {
            return true;
        }

        private void FileBrowseExecute()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies listeners of the property change.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void NotifyPropertyChange(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}