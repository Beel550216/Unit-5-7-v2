using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] AudioMixer mixer;
    [SerializeField] AudioSource buttonSource;
    [SerializeField] AudioSource musicSource;
    [SerializeField] List<AudioClip> buttonClips = new List<AudioClip>();

    public const string MusicKey = "MusicVolume";
    public const string SFXKey = "SFXVolume";

   // public int round = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        VolumeLoad();

    }



    public void VolumeLoad()
    {

        float musicVolume = PlayerPrefs.GetFloat(MusicKey, 1f);
        float sfxVolume = PlayerPrefs.GetFloat(SFXKey, 1f);

        mixer.SetFloat(VolumeSettings.Mixer_Music, Mathf.Log10(musicVolume)*20); 
        mixer.SetFloat(VolumeSettings.Mixer_SFX, Mathf.Log10(sfxVolume)*20); 

    }

    


    public void buttonSFX()
    {
        AudioClip clip = buttonClips[Random.Range(0, buttonClips.Count)];
        buttonSource.PlayOneShot(clip);
    }
    
}