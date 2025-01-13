using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MuteAudio : MonoBehaviour
{
    public static MuteAudio instance;

    [SerializeField] AudioMixer mixer;
    public const string MasterKey = "MasterVolume";


    public void MusicOff(bool muted)
    {
       if(muted)
        {
            mixer.SetFloat (MasterKey, -80f);
        }
        else
        {

            mixer.SetFloat (MasterKey, 0f);
        }
    }
}
