using UnityEngine;

public class Deneme : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake çalıştı");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable çalıştı");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable çalıştı");
    }
    void Start()
    {
        Debug.Log("Start Çalıştı!! Merhaba Dünya nasılsın???");
        YaziYaz();
    }
    void YaziYaz()
    {
        Debug.Log("Start fonsiyonu içinde çalıştı!!!");
    }
}
