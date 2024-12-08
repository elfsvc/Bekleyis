using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baslatma_Sacript : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void OnButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Add your button functionality here
    }


}
