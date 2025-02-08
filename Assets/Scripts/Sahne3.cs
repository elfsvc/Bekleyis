using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne3 : MonoBehaviour
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

        popup.Show("Şimdi önümüzde 40 kişi var! Ne zaman sıra bize gelecek? Çok susadım, gazoz almak istiyorum! 🥤", cemTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);
        popup.Show("\"Kozmik Böcek\" her turda 10 kişiyi taşıyormuş ve bir turu tam 5 dakikada tamamlıyormuş. Hadi şimdi süreyi hesaplayalım!\r\n", keremTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);
        bubbleRect.gameObject.SetActive(true);

        yield return new WaitUntil(() => answered);
        bubbleRect.gameObject.SetActive(false);
        popup.Show("Harika! 🎉 O zaman gazoz almak için bolca vaktim var. 🍹 Ama dikkat et, sıramı kimseye verme! Hemen bize gazoz alıp geliyorum! 🚀\r\n", cemTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(5.0f);
        popup.Show("Tamam, Can! Ben sırayı tutarım. Kozmik Böcek dönmeye devam ediyor, acele et!\r\n", keremTransform, Vector3.up * 0.13f);
     
        nextSceneButton.SetActive(true);
    }

    public void OnButtonClicked()
    {
        answered = true;
    }
}
