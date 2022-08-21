using UnityEngine;
using UnityEngine.SceneManagement;

public class CotrolMainmenu : MonoBehaviour
{
    public void StartGamePingpong()
    {
        SceneManager.LoadScene("Pingpong");
    }

    public void StartGameBoxing()
    {
        SceneManager.LoadScene("Boxing");
    }
}
