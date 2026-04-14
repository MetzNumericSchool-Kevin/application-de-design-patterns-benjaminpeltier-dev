public class SettingsManager
{
    #region VARIABLES
    private static SettingsManager _instance;

    private Difficulty _difficulty = Difficulty.Normal;
    private language _language = language.French;
    private int _volumeMusic = 80;
    private int _volumeSFX = 70;
    private string _screenResolution = "1920x1080";
    private GraphicsQuality _graphicsQuality = GraphicsQuality.High;

    public static SettingsManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SettingsManager();
            }
            return _instance;
        }
    }
    #endregion

    #region ACCESSORS
    public Difficulty GameDifficulty
    {
        get { return _difficulty; }
        set { _difficulty = value; }
    }

    public language GameLanguage
    {
        get { return _language; }
        set { _language = value; }
    }

    public int VolumeMusic
    {
        get { return _volumeMusic; }
        set { _volumeMusic = value; }
    }

    public int VolumeSFX 
    {
        get { return _volumeSFX; }
        set { _volumeSFX = value; }
    }

    public string ScreenResolution 
    {
        get { return _screenResolution; }
        set { _screenResolution = value; }
    }

    public GraphicsQuality GameGraphicsQuality
    {
        get { return _graphicsQuality; }
        set { _graphicsQuality = value; }
    }
    #endregion

    #region ENUMS
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }

    public enum language
    {
        English,
        Spanish,
        French
    }

    public enum GraphicsQuality
    {
        Low,
        Medium,
        High,
        Ultra
    }
    #endregion
}