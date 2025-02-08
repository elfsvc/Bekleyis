using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDetector : MonoBehaviour
{
    public Popup popup;

    public Transform cemTransform;
    public Transform keremTransform;

    //public RectTransform cemRect;
    //public RectTransform keremRect;

    public RectTransform bubbleRect;

    public static bool start = false;

    IEnumerator Start()
    {
        yield return new WaitUntil(() => start);

        popup.Show("Merhaba, ben Can", cemTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);
        popup.Show("Merhaba, ben Kerem", keremTransform, Vector3.up * 0.13f);
        yield return new WaitForSeconds(2.0f);
        bubbleRect.gameObject.SetActive(true);
    }

    public void OnButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
