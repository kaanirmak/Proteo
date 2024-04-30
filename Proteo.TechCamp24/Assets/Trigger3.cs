using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger3 : MonoBehaviour
{
    private int opt;
    void Update()
    {
        if (opt == 1)
        {
            SceneManager.LoadScene("map-4.2");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger-4")
        {
            opt = 1;
        }
    }
}
