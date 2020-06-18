using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class applemove : MonoBehaviour
{

    public float speed = 2f;
    public GameObject apple;
    private float x;

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -7)
        {
            x = Random.Range(-2.0f, 2.0f);
            Instantiate(apple, new Vector3(x, 6, -0.5f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
