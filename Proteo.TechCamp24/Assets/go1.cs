using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.Alpha0))
            {
                SceneManager.LoadScene("go-1");
            }
        }
    }
}
