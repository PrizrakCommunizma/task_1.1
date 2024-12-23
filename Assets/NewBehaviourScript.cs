using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Sphere1;
    public int S;
    public void OnButtonDown()
    {
        S = Random.Range(-2, 2);
        Sphere1.transform.Translate(S, 0, 0);
    }
}
