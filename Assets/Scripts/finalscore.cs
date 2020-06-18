using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalscore : MonoBehaviour
{
    public Text scoretxt;
    void Start()
    {
        scoretxt.text = PlayerStats.finalscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
