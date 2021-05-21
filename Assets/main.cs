using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_ANDROID
using UnityEngine.Android;
#endif

public class  main: MonoBehaviour

{
    public void LoadVIBMenu()
    {
        SceneManager.LoadScene(0);
        Quit();
    }

    public void LoadARMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadBankArea()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadViewBalance()
    {
        SceneManager.LoadScene(3);

        BackToARMenu();
    }

    public void openGoogleMap()
    {
        #if UNITY_ANDROID
            Application.OpenURL("google.navigation:q=VIB");
        #elif UNITY_IOS
            Application.OpenURL("http://maps.apple.com/maps?saddr=Current+Location&daddr=VIB");
        #else
            Application.OpenURL("http://maps.google.com/maps?saddr=My+Location&daddr=VIB");
        #endif

    }

    public void BackToARMenu()
    {
        #if UNITY_ANDROID
        if (Application.platform == RuntimePlatform.Android) {

            if (Input.GetKeyUp(KeyCode.Escape)) {
               LoadARMenu();
               return;
           }
        }
        #endif

    }

    public void Quit () {
        #if UNITY_ANDROID
        if (Application.platform == RuntimePlatform.Android) {

            if (Input.GetKeyUp(KeyCode.Escape)) {
               Application.Quit();
               return;
           }
        }
        #endif
    }

}
