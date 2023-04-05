using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howto5 : MonoBehaviour
{
    public GameObject next;
    public void skip()
    {
        next.SetActive(true);
    }
    public void next1()
    {
        SceneManager.LoadScene("Requiement");
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1", 15f);
        Invoke("skip", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
