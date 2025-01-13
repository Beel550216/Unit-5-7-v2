using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{

    public static VolumeSettings instance;


    public const string Mixer_Music = "MusicVolume";
    public const string Mixer_SFX = "SFXVolume";


    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    void Awake()
    {

        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);

    }

    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MusicKey, 1f);
        sfxSlider.value = PlayerPrefs.GetFloat(AudioManager.SFXKey, 1f);
    }


    void OnDisable()
    {
        
        /*PlayerPrefs.SetFloat(AudioManager.MusicKey, musicSlider.value);
        PlayerPrefs.SetFloat(AudioManager.SFXKey, sfxSlider.value);
        PlayerPrefs.Save();*/
    }


    public void SetMusicVolume(float value)
    {
        mixer.SetFloat(Mixer_Music, Mathf.Log10(value)*20);
        PlayerPrefs.SetFloat(AudioManager.MusicKey, musicSlider.value);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float value)
    {
        mixer.SetFloat(Mixer_SFX, Mathf.Log10(value)*20);
        PlayerPrefs.SetFloat(AudioManager.SFXKey, sfxSlider.value);
        PlayerPrefs.Save();
    }
}
