using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public Canvas canvas;
    public RectTransform canvasRect;
    public Transform attach;
    private Vector3 offset;

    public TextMeshProUGUI tmp;
    private RectTransform rect;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        var screenPos = Camera.main.WorldToScreenPoint(attach.position + offset);

        Vector2 anchoredPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            screenPos,
            canvas.worldCamera,
            out anchoredPosition
        );

        rect.anchoredPosition = anchoredPosition;
    }

    public void Show(string str, Transform t, Vector3 o)
    {
        gameObject.SetActive(true);
        tmp.SetText(str);
        attach = t;
        offset = o;
    }
}
