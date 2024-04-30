using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerfinal : MonoBehaviour
{

    private int opt;
    void Update()
    {
        if (opt == 3)
        {
            SceneManager.LoadScene("final");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "final")
        {
            opt = 3;
        }
    }
}
