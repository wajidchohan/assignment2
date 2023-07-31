using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnClick_Start()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClick_Exit()
    {
        Application.Quit();
    }
    public void OnClick_Back()
    {
        SceneManager.LoadScene(0);

    }
}
