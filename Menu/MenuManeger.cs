using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManeger : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

  
    public void ExitGame()
    {
        Application.Quit();
    }
}
