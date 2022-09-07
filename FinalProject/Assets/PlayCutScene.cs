using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayCutScene : MonoBehaviour
{


   

    void OnTriggerStay(Collider target)
    {
     if(target.tag == "Player")
        {
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
