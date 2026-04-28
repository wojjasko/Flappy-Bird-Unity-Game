using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPrzeszkod : MonoBehaviour
{
    public GameObject przeszkoda;
    public float odstep = 8;
    private void Start()
    {
        for(int i=0; i < 3; i++)
        {
            UtworzPrzeszkode();
        }
    }
    public void UtworzPrzeszkode()
    {
        Instantiate(przeszkoda, new Vector3(odstep, Random.Range(-2.5f, 2.5f), 12.6f), Quaternion.Euler(0,0,0));
        odstep += 8;
    }
}