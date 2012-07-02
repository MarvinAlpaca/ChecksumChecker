using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using ChecksumChecker.Infrastructure;

namespace ChecksumChecker
{
    public class ChecksumDetailsViewModel : ObservableObject
    {
        public string FileName
        {
            get;
            set;
        }

        public ICommand FileBrowserCommand
        {
            get { return new RelayCommand(FileBrowseExecute); }
        }

        private void FileBrowseExecute()
        {
            string selectedFolder = string.Empty;
            FolderBrowserDialog selectFolderDialog = new FolderBrowserDialog();
            selectFolderDialog.ShowNewFolderButton = true;
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = selectFolderDialog.SelectedPath;
                FileName = selectedFolder;
            }
        }
    }
}