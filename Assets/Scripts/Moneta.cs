using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour
{
    public GameObject coin;
    ZarzadzanieUI odnosnikDoZarzadzaniaUI;
    GeneratorMonet odnosnikDoGeneratoraMonet;
    public int pkt;

    private void Start()
    {
        odnosnikDoZarzadzaniaUI = FindObjectOfType<ZarzadzanieUI>();
        odnosnikDoGeneratoraMonet = FindObjectOfType<GeneratorMonet>();
    }
    private void OnTriggerEnter(Collider other)
    {
        odnosnikDoZarzadzaniaUI.DodajMonete();
        odnosnikDoGeneratoraMonet.UsunMonete();
        //odnosnikDoGeneratoraMonet.UtworzMonete();
    }
}
