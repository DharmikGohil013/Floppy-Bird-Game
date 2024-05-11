using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void stopgame()
    {
        Application.Quit();
    }
   
}
