using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILogic : MonoBehaviour
{
    public void Lose()
    {
        SceneManager.LoadScene(0);
    } 
    public void Victory()
    {
        SceneManager.LoadScene(1);
    }
}
