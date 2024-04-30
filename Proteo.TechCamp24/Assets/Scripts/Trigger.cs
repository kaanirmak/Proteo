using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private int opt;
    void Update()
    {
        if (opt == 1)
        {
            SceneManager.LoadScene("map-2.1");
        }
        else if (opt == 2)
        {
            SceneManager.LoadScene("map-2.2");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger-1")
        {
            opt = 1;
        }
        else if (other.gameObject.tag == "Trigger-2")
        {
            opt = 2;
        }
    }
}
