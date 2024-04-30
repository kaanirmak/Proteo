using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger2 : MonoBehaviour
{
    private int opt;
    void Update()
    {
        if (opt == 3)
        {
            SceneManager.LoadScene("map-4.1");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger-3")
        {
            opt = 3;
        }
    }
}
