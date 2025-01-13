using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip musicClip;
    public AudioClip musicClip2;


    void Awake()
    {
        if (gameObject.tag == "Audio1")
        {
            //AudioClip clip = musicClips[0];
            musicSource.PlayOneShot(musicClip);
        }

        /*if (gameObject.tag == "Audio2")
        {
            //AudioClip clip = musicClips[0];
            musicSource.PlayOneShot(musicClip2);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
