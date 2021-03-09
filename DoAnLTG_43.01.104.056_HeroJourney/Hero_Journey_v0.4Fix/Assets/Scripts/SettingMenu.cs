using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    //public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;
    public Toggle fullScreen;

    Resolution[] resolutions;

    void Start()
    {
        if (PlayerPrefs.GetInt("isFullScreen") == 1) fullScreen.isOn = true;
        else if (PlayerPrefs.GetInt("isFullScreen") == 0) fullScreen.isOn = false;

        if(resolutionDropdown != null)
        {
            resolutions = Screen.resolutions;
            resolutionDropdown.ClearOptions();

            List<string> options = new List<string>();

            int currentResolutionIndex = 0;

            for (int i = 0; i < resolutions.Length; i++)
            {
                string option = resolutions[i].width + " x " + resolutions[i].height;
                options.Add(option);

                if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
                {
                    currentResolutionIndex = i;
                }
            }
            resolutionDropdown.AddOptions(options);
            resolutionDropdown.value = currentResolutionIndex;
            resolutionDropdown.RefreshShownValue();
        }
    }


    public void setResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


  /*  public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    } */

    public void setQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
    public void setFullScreen(bool isFullScreen)
    {
        if (isFullScreen == true) PlayerPrefs.SetInt("isFullScreen", 1);
        else PlayerPrefs.SetInt("isFullScreen", 0);
        Screen.fullScreen = isFullScreen;
        
    }
}
