using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Win32;
using SetupProjectHelper.VdprojLibrary;
using SetupProjectHelper.VdprojLibrary.Models;
using SetupProjectHelper.VdprojLibrary.Models.Deployable;
using SetupProjectHelper.VdprojLibrary.Models.Deployable.Folder;
using SetupProjectHelper.Views;

namespace SetupProjectHelper.ViewModels;

public class ViewModel : NotificationObject 
{
    private string _vdprojFilePath = string.Empty;
    private ObservableCollection<FileEntryViewModel> _assemblyFiles = new();

    public ViewModel()
    {
        // for quick testing
        // remove once happy with parsing/mapping
        ReadProjectFile();

        BrowseProjectFilePathCommand = new DelegateCommand(BrowseProjectFilePath);
        OpenFileEntryPropertiesCommand = new DelegateCommand(OpenFileEntryProperties);
    }

    public DelegateCommand OpenFileEntryPropertiesCommand { get; set; }
    public DelegateCommand BrowseProjectFilePathCommand { get; private set; }

    public ObservableCollection<FileEntryViewModel> AssemblyFiles
    {
        get
        {
            return _assemblyFiles;
        }

        set
        {
            SetField(ref _assemblyFiles, value);
        }
    }

    public string VdprojFilePath
    {
        get
        {
            return _vdprojFilePath;
        }

        set
        {
            SetField(ref _vdprojFilePath, value);
        }
    }

    public string WindowHeader
    {
        get { return $"Setup project: {VdprojFilePath}"; }
    }

    private FileEntryViewModel? _selectedFileEntryViewModel;
    public FileEntryViewModel? SelectedFileEntryViewModel
    {
        get
        {
            return _selectedFileEntryViewModel;
        }

        set
        {
            SetField(ref _selectedFileEntryViewModel, value);
        }
    }
    
    public void OpenFileEntryProperties()
    {
        if (SelectedFileEntryViewModel is not null)
        {
            VdprojFilePropertyView window = new VdprojFilePropertyView
            {
                DataContext = new VdprojFilePropertyViewModel(SelectedFileEntryViewModel)
            };
            window.ShowDialog();
        }
    }

    private void BrowseProjectFilePath()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        bool? result = openFileDialog.ShowDialog();

        if (result == true)
        {
            VdprojFilePath = openFileDialog.FileName;
        }
    }

    private void ReadProjectFile()
    {
        VdprojFilePath =
            @"C:\Users\alexh\Downloads\GX3Server.vdproj";

        VdprojParser parser = new();
        string[] lines = File.ReadAllLines(VdprojFilePath);
        VdprojNode root = parser.Parse(lines);

        DeployProject test = VdprojMapper.MapNode<DeployProject>(root);
        VdprojMapper.ResolveAssemblyFileFolderNames(test.Deployable.Files.FileEntries, test.Deployable.Folders.Folders);

        IEnumerable<FileEntryViewModel> assemblyFiles = test.Deployable.Files.FileEntries.Select(file => new FileEntryViewModel(file));
        AssemblyFiles = new ObservableCollection<FileEntryViewModel>(assemblyFiles);
    }
}

public class FileEntryViewModelFactory
{
    private List<FolderEntry> _folders;
    
    public static FileEntryViewModel Create(FileEntry file)
    {
        return new FileEntryViewModel(file);
    }

    public FileEntryViewModelFactory(List<FolderEntry> folders)
    {
        _folders = folders;
    }

}