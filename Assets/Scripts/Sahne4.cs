using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne4 : MonoBehaviour
{
    public Popup popup;

    public Transform cemTransform;
    public Transform keremTransform;
    public Transform robotAdam;

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

        popup.Show("Aaaa! Bu benim en sevdiğim kahraman Robot Adam değil mi?! Hemen koşup imzasını alayım! Merhaba Robot Adam, bana imza verir misin? Hem benim için hem de arkadaşım Kerem için!\r\n", cemTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);


        popup.Show("Tabii ki! Al bakalım, bu senin için ve bu da Kerem için. Arkadaşına selam söyle!", robotAdam, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);

        popup.Show("Kerem, bak! Gazoz almaya giderken kime rastladım? En sevdiğimiz süperkahraman olan Robot Adam’a! Bizim için imza aldım! \r\n", cemTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);

        popup.Show("Can, sen harikasın! Çok teşekkür ederim, arkadaşım. Seni çok seviyorum! En iyi dostum sensin! Hadi Kozmik Böceğe Binelim Sıra Bizde!!!", keremTransform, Vector3.up * 0.13f);
     
        nextSceneButton.SetActive(true);
    }

    public void OnButtonClicked()
    {
        answered = true;
    }
}
