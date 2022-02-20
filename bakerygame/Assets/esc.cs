using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
    public bool IsPaused;
    public GameObject Canvas;

    void Update ()
    {
        if (IsPaused)
        {
            Canvas.SetActive(true);

        }
        else
            Canvas.SetActive(false);
        if (Input.GetKeyDown(KeyCode.Escape))
        { IsPaused = !IsPaused;
        }
        
    }
}
  