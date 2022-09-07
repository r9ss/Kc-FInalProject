using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Quit!");
    }

    IEnumerator wait()
    {
         Cursor.lockState = CursorLockMode.Locked;
 Cursor.visible = false;
       yield return new WaitForSeconds(0.5f);

       PlayGame();
    }

    public void PlayButton()
    {
        StartCoroutine(wait());
    }
 
}
