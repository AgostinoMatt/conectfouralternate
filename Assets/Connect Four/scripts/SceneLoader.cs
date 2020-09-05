using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void load1player()
    {
        SceneManager.LoadScene("1vaigame");
    }

    public void load2player()
    {
        SceneManager.LoadScene("1v1game");
    }
}
