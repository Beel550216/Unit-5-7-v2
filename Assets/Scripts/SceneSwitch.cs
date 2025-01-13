
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{

    public  void Switch()
    {
        SceneManager.LoadScene(sceneName: "Game");
    }

    public void SwitchBack()
    {
        SceneManager.LoadScene(sceneName: "Menu");
    }
}
