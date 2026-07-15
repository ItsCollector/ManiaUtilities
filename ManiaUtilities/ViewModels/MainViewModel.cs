using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ManiaUtilities.Models;

namespace ManiaUtilities.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<Preset> presets = 
    [
        new Preset { Name = "Preset 1", FlnConversionEnabled = true, FlnGapMs = 80 },
        new Preset { Name = "Preset 2", RemoveLnsEnabled = true }
    ];

    [ObservableProperty] 
    private ObservableCollection<string> moduleOptions =
    [
        "Convert to FLN",
        "Remove All LN",
        "Remove Only Short LN",
        "Remove SV",
        "Rate Change",
        "Column Swap"
    ];
    
    [ObservableProperty] private string mapTitle = "Placeholder Title";
    [ObservableProperty] private string mapAuthor = "Placeholder Author";
    [ObservableProperty] private string mapVersion = "Placeholder Version";
    
    [ObservableProperty] private Preset? selectedPreset;
    [ObservableProperty] private string? selectedModuleOption;

    // FLN Module
    [ObservableProperty] private bool flnConversionEnabled = false;
    [ObservableProperty] private bool flnGapMs = false;
    
    // 
    [ObservableProperty] private bool removeLnEnabled = false;
    [ObservableProperty] private bool removeShortLnEnabled = false;
    [ObservableProperty] private bool removeSvEnabled = false;
    [ObservableProperty] private bool rateChangeEnabled = false;
    [ObservableProperty] private bool columnSwapEnabled = false;

    [ObservableProperty]
    private ObservableCollection<ModuleViewModel> operationStack = new()
    {
        new FlnConversionViewModel(),
    };
    
    partial void OnSelectedPresetChanged(Preset? value)
    {
        if (value is null) return;
        
        selectedPreset = value;
    }

    partial void OnSelectedModuleOptionChanged(string? value)
    {
        if (value is null) return;
        
        selectedModuleOption = value;
    }
}