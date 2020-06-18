using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindOfChange : MonoBehaviour
{
    public string objname;
    public int fly;
    public int pos;
    public int flyzone;


    private void Update()
    {
        positionchecker();
        if (flyzone == pos)
        {
            this.GetComponent<Rigidbody2D>().gravityScale = -0.11f;
        }
        else
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 0.05f;
        }
    }
    public void positionchecker()
    {
        if (transform.position.x < -1) pos = 1;
        if ( -1 < transform.position.x && transform.position.x  < 1) pos = 2;
        if (transform.position.x > 1) pos = 3;
        flyzone = PlayerStats.windzone;
    }
}
