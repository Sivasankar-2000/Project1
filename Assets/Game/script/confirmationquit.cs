using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmationquit : MonoBehaviour
{
    [SerializeField] GameObject quitpanel;

    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Openareyousure()
    {
        quitpanel.SetActive(true);
    }

    public void Closeareyousure()
    {
        quitpanel.SetActive(false);
    }

}
