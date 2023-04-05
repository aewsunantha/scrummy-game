using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sprint1 : MonoBehaviour
{
    public GameObject video1, video2;
    public void gotointro()
    {
        SceneManager.LoadScene("1DayPart1");
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("gotointro", 5.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
