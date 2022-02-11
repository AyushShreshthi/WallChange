using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiHandler : MonoBehaviour
{
    private void Start()
    {
        Invoke("ShowAd", 2.5f);
        
    }
   
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ExitBtn()
    {
        SceneManager.LoadScene(0);
    }
    private void ShowAd()
    {
        AdsController.VideoAd();
    }
}
