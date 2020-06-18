using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stayOnScreen : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f),
            Mathf.Clamp(transform.position.y, -6f, 5.5f), transform.position.z);
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(2);
        }
    }
}
