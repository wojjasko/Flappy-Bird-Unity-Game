using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorMonet : MonoBehaviour
{

    public GameObject coin;
    public float odstep = 12;
    public GameObject moneta;
    private void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            UtworzMonete();
        }
    }
    public void UtworzMonete()
    {
        moneta = Instantiate(coin, new Vector3(odstep, Random.Range(6f, -3f), 10.15f), Quaternion.Euler(0, 0, 0));
        odstep += 8;
    }
    public void UsunMonete()
    {
        Destroy(moneta);
        //coin.SetActive(false); TO DZIALA BTW
    }
}