using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przeszkoda : MonoBehaviour
{
    GeneratorPrzeszkod odnosnikDoGeneratoraPrzeszkod;
    ZarzadzanieUI odnosnikDoZarzadzaniaUI;
    GeneratorMonet odnosnikDoGeneratoraMonet;
    public int pkt;

    private void Start()
    {
        odnosnikDoGeneratoraPrzeszkod = FindObjectOfType<GeneratorPrzeszkod>();
        odnosnikDoZarzadzaniaUI = FindObjectOfType<ZarzadzanieUI>();
        odnosnikDoGeneratoraMonet = FindObjectOfType<GeneratorMonet>();
    }
    private void OnTriggerEnter(Collider other)
    {
        odnosnikDoGeneratoraPrzeszkod.UtworzPrzeszkode();
        odnosnikDoZarzadzaniaUI.DodajPunkt();
        odnosnikDoGeneratoraMonet.UtworzMonete();
        //if (currentMoney == 0)
        //{
        //    odnosnikDoGeneratoraMonet.UtworzMonete();
        //}
        //odnosnikDoGeneratoraMonet.UsunMonete();
    }
}
