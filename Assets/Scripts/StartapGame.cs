using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartapGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }
}
