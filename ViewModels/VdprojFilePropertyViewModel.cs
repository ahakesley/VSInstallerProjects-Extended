namespace SetupProjectHelper.ViewModels
{
    public class VdprojFilePropertyViewModel : NotificationObject
    {
        private FileEntryViewModel _fileEntryViewModel;
        public FileEntryViewModel FileEntryViewModel
        {
            get
            {
                return _fileEntryViewModel;
            }

            set
            {
                SetField(ref _fileEntryViewModel, value);
            }
        }

        public VdprojFilePropertyViewModel()
        {
        }

        public VdprojFilePropertyViewModel(FileEntryViewModel fileEntryViewModel)
        {
            FileEntryViewModel = fileEntryViewModel;
        }
    }
}
