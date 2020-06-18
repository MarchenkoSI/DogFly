using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MoveObj : MonoBehaviour
{
    public float speed = 2f;
    public GameObject cloud;
    public GameObject thunder;
    private float x;
    private float random;

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -7) {
            x = Random.Range(-2, 2);
            if (x >= 0.75f)
            {
                x = 1.5f;
            }else if (x <= -0.75f)
            {
                x = -1.5f;
            }else {
                x = 0; 
            }
            random = Random.Range(0, 10);
            if (random >= 8)
            {
                Instantiate(thunder, new Vector3(x, 6, 0), Quaternion.identity);
            }else if (random < 8)
            {
                Instantiate(cloud, new Vector3(x, 6, 0), Quaternion.identity);
            }            
            Destroy(gameObject);
        }
    }
}
