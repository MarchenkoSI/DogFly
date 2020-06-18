using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windChanger : MonoBehaviour
{
    public int rand;
    public GameObject wind;
    public float timer = 5;

    void Update()
    {
        if (timer > 0) timer -= Time.deltaTime;
        if (timer < 0) changer();
    }

    public void changer()
    {
        rand = Random.Range(0, 3);
        timer = 5;
        switch (rand)
        {
            case 0:
                Instantiate(wind, new Vector3(-1.5f, -3.64f, -0.5f), Quaternion.identity);
                Destroy(gameObject);
                PlayerStats.windzone = 1;
                break;
            case 1:
                Instantiate(wind, new Vector3(0, -3.64f, -0.5f), Quaternion.identity);
                Destroy(gameObject);
                PlayerStats.windzone = 2;
                break;
            case 2:
                Instantiate(wind, new Vector3(1.5f, -3.64f, -0.5f), Quaternion.identity);
                Destroy(gameObject);
                PlayerStats.windzone = 3;
                break;
        }       
    }
}
