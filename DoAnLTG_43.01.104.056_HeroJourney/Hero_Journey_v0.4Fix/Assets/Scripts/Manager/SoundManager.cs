using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    
    public Sound[] sounds;
    //public AudioMixer mixer;
    public Slider soundEffectSlider, musicSlider;

    // Start is called before the first frame update
    void Awake()
    {
        
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            //string OutputMixer = "Master";

            //s.source.outputAudioMixerGroup = mixer.FindMatchingGroups(OutputMixer)[0];
        }
    }

    void Start()
    {
        soundEffectSlider.value = PlayerPrefs.GetFloat("SoundEffect");
        musicSlider.value = PlayerPrefs.GetFloat("Music");
        Play("Theme");
    }

    void Update()
    {
        foreach (Sound s in sounds)
        {
            if (s.isSoundEffect)
            {
                PlayerPrefs.SetFloat("SoundEffect", s.volume);
                s.volume = soundEffectSlider.value;
                s.source.volume = s.volume;
            }
            else
            {
                PlayerPrefs.SetFloat("Music", s.volume);
                s.volume = musicSlider.value;
                s.source.volume = s.volume;
            }
            
        }
    }


    
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        /*if(s.isSoundEffect)
            PlayerPrefs.SetFloat("SoundEffect", s.volume);
        else
            PlayerPrefs.SetFloat("Music", s.volume);*/

        s.source.Play();

    }

}
