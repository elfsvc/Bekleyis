using UnityEngine;
using UnityEngine.SceneManagement;

public class OnBecomeVisible : MonoBehaviour
{
    // Enable this script when the GameObject moves into the camera's view
    void OnBecameVisible()
    {
        int index = SceneManager.GetActiveScene().buildIndex;

        if (index == 1)
            ClickDetector.start = true;
        else if (index == 2)
            Sahne2.start = true;
        else if (index == 3)
            Sahne3.start = true;
        else if (index == 4)
            Sahne4.start = true;
    }
}