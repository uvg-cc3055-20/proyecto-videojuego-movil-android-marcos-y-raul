using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene_No_1");
    }
}
