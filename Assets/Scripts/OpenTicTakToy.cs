using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenTicTakToy : MonoBehaviour
{
    public void OpenGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
}