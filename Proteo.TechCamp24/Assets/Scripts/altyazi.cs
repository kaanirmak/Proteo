using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class altyazi : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI altyaz�;

    private void Start()
    {
        StartCoroutine(subs());
    }

    IEnumerator subs()
    {
        altyaz�.text = "KKSFKLSDFKMSDLKMFSLFSLFMSLMDLFKM";
        yield return null;
    }
}