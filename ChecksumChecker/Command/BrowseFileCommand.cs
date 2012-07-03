using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

using ChecksumChecker.ViewModel;

namespace ChecksumChecker.Command
{
    public class BrowseFileCommand : ICommand
    {
        private ChecksumDetailsViewModel checksumDetailsVM;

        public BrowseFileCommand(ChecksumDetailsViewModel checksumDetailsVM)
        {
            this.checksumDetailsVM = checksumDetailsVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            string selectedFolder = string.Empty;
            OpenFileDialog selectFileDialog = new OpenFileDialog();

            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = selectFileDialog.FileName;
                this.checksumDetailsVM.FileName = selectedFolder;
            }
        }
    }
}