using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public static SceneLoader Instance { get { return instance; } }

    public bool TwoPlayer = false;

    void Start()
    {
        if (instance != null || instance == this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public void load1player()
    {
        SceneManager.LoadScene("1vaigame");
    }

    public void load2player()
    {
        SceneManager.LoadScene("1v1game");
        TwoPlayer = true;
    }
}
