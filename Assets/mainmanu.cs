using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
