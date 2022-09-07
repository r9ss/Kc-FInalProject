using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthP : MonoBehaviour
{
    [SerializeField] private Animator Demogorgan;
    public float health = 100f;
    public bool loseHealth = false;
    
    [SerializeField] public TextMeshProUGUI healtht;
    // Start is called before the first frame update
    void Start()
    {
        healtht.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {

      if (Demogorgan.GetBool("isAttacking"))
        { // if animation isAttacking is true damage = 0.7f
            loseHealth = true;
            StartCoroutine(wait());
        }
    
    if(health <0)
    {
        health =0f;
        healtht.text = health.ToString();
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
     if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(3);
        }
    
     if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(0);
        }
   
    }

    IEnumerator wait()
    {
        if(loseHealth == true)
        {
            loseHealth=false;
        yield return new WaitForSeconds(0.7f);
        health -=45;
        healtht.text = health.ToString();
        }


    }
}
