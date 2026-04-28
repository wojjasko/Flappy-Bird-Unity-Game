using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZarzadzanieUI : MonoBehaviour
{
    public GameObject panelKoncaGry;
    public GameObject panelStartuGry;
    public GameObject punktyObiekt;
    public GameObject monetyObiekt;
    public GameObject wynikObiekt;
    public GameObject monetyPodpowiedzObiekt;
    public TextMeshProUGUI punktyWGrzeTekst;
    public TextMeshProUGUI punktyKoniec;
    public TextMeshProUGUI monetyWGrzeTekst;
    public TextMeshProUGUI monetyKoniec;
    public TextMeshProUGUI wynikKoniec;
    Gracz odnosikDoGracza;
    float punkty = 0;
    float monety;
    private void Start()
    {
        Time.timeScale = 0f;
        odnosikDoGracza = FindObjectOfType<Gracz>();
    }
    public void Play()
    {
        panelStartuGry.SetActive(false);
        Time.timeScale = 1f;
        punktyObiekt.SetActive(true);
        monetyObiekt.SetActive(true);
        monetyPodpowiedzObiekt.SetActive(true);
        wynikObiekt.SetActive(true);
        punktyWGrzeTekst.text = "Punkty: " + punkty.ToString();
        monetyWGrzeTekst.text = "Monety: " + monety.ToString();
    }
    private void Update()
    {
        if(odnosikDoGracza.uderzyl == true)
        {
            panelKoncaGry.SetActive(true);
            punktyKoniec.text = "Punkty: " + punkty.ToString();
            monetyKoniec.text = "Monety: " + monety.ToString();
            float suma = punkty+(monety/2);
            wynikKoniec.text = "Wynik: " + suma.ToString();
            Time.timeScale = 0f;
        }
    }
    public void DodajPunkt()
    {
        punkty++;
        punktyWGrzeTekst.text = "Punkty: " + punkty.ToString();
    }
    public void DodajMonete()
    {
        monety++;
        monetyWGrzeTekst.text = "Monety: " + monety.ToString();
    }
    public void ZapiszMonety()
    {

    }
}
