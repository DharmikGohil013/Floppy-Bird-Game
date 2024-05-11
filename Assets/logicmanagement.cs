using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicmanagement : MonoBehaviour
{
    public int playerscore;
    public Text socore;
    public GameObject gameoverscree;
    [ContextMenu("increse score")]  
    public void aaddscore()
    {
        playerscore = playerscore + 1;
        socore.text=playerscore.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscree.SetActive(true);
    }

}
