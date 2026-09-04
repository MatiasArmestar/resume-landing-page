namespace resume_landing_page.Services;

public class LanguageService
{
    public string CurrentLanguage { get; private set; } = "es";

    public event Action? OnLanguageChanged;

    public void ToggleLanguage()
    {
        CurrentLanguage = CurrentLanguage == "es" ? "en" : "es";

        OnLanguageChanged?.Invoke();
    }
}