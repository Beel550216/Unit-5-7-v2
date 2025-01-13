using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Button : MonoBehaviour
{

    public Button music;
    public TMP_Text musicText;


    public void OnOff()
    {
        musicText = music.GetComponentInChildren<TextMeshProUGUI>();

        musicText = GetComponent<TMP_Text>();


        if (musicText.text == "On")
        {
            musicText.text = "Off";
        }
        if (musicText.text == "Off")
        {
            musicText.text = "On";
        }

        
    }

    public void Sfx()
    {
        AudioManager.instance.buttonSFX();
    }

    private void Update()
    {
       if (gameObject.tag == "slider")
        {
            Vector3 temp = new Vector3(9f, 5f);
            AudioManager.instance.buttonSFX();
        }
    }
    

}
