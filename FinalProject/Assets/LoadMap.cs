using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMap1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMap1()
    {
        yield return new WaitForSeconds(25.23f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
