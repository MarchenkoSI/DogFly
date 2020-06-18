using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void click_Start()
    {
        SceneManager.LoadScene(1);
    }
}
