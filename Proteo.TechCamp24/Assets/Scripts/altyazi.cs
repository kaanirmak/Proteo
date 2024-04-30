using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class altyazi : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI altyazý;

    private void Start()
    {
        StartCoroutine(subs());
    }

    IEnumerator subs()
    {
        altyazý.text = "KKSFKLSDFKMSDLKMFSLFSLFMSLMDLFKM";
        yield return null;
    }
}