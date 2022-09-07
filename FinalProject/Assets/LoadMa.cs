using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMa : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F key was pressed.");
            SceneManager.LoadScene(3);
        }
    }
    
    public void load()
    {
     
        SceneManager.LoadScene(3);
    }
}
