namespace ManiaUtilities.Models;

public class Preset
{
    public string Name { get; set; } = string.Empty;
    public bool FlnConversionEnabled  { get; set; }
    public int FlnGapMs { get; set; }
    public bool RemoveLnsEnabled { get; set; }
}