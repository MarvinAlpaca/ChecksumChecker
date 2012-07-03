using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ChecksumChecker.ViewModel;

namespace ChecksumChecker.Command
{
    public class ComputeChecksumCommand : ICommand
    {
        private ChecksumDetailsViewModel checksumDetailsVM;

        public ComputeChecksumCommand(ChecksumDetailsViewModel checksumDetailsVM)
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
            if (parameter != null && parameter is string)
            {
                try
                {
                    var computeChecksum = new ComputeChecksum();

                    var fileContent = FileHelpers.ReadFileToEnd(parameter as string);

                    checksumDetailsVM.ActualChecksum = computeChecksum.CheckChecksum(checksumDetailsVM.ChecksumModel.ChecksumType, fileContent);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}