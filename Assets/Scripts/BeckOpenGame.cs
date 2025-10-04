using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeckOpenGame : MonoBehaviour
{
    public void BecktoOpen()
    {
        SceneManager.LoadSceneAsync(1);
    }
}