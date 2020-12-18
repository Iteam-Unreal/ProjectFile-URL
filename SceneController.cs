using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
