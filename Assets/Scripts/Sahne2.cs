using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne2 : MonoBehaviour
{
    public Popup popup;

    public Transform cemTransform;
    public Transform keremTransform;

    public RectTransform bubbleRect;
    public GameObject nextSceneButton;

    public static bool start = false;

    private bool answered = false;

    void Awake()
    {
        start = false;
    }

    IEnumerator Start()
    {
        yield return new WaitUntil(() => start);

        popup.Show("Olamaz! Çok uzun bir sıra var! Önümüzde yüzlerce insan olmalı\r\n", cemTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);
        popup.Show("Hadi birlikte sayalım Can!\r\nHer sırada 10 kişi var ve 6 sıra varmış. Peki, önümüzde tahmini toplam kaç kişi var?\r\nHadi bir çarpma yapalım", keremTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);
        bubbleRect.gameObject.SetActive(true);

        yield return new WaitUntil(() => answered);
        bubbleRect.gameObject.SetActive(false);
        popup.Show("Ben yüzlerce diyorum sen 60 diyorsun! Gidip sayacağım, Sırayı baştan sona iki kez saydım ve 62 çıktı gerçekten 60 iyi bir tahmindi Kerem", cemTransform, Vector3.up * 0.13f);

        nextSceneButton.SetActive(true);
        yield return new WaitForSeconds(5.0f);
    }

    public void OnButtonClicked()
    {
        answered = true;
    }
}
