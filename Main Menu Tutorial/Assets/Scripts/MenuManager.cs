using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider sensSlider, audioSlider;

    public GameObject MainPanel, SettingsPanel;

    public void Play()
    {
        Debug.Log("Playing...");
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        Debug.Log("Going to settings...");
        MainPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }

    private void Update()
    {
        GameManager.sensitvity = sensSlider.value;
        GameManager.audioVol = audioSlider.value;
    }

    public void Back()
    {
        MainPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
}
