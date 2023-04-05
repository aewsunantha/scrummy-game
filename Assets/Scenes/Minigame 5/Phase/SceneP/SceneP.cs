using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneP : MonoBehaviour
{
    public GameObject click, next;
    

    public void clickRequire()
    {
        SceneManager.LoadScene("Howto 5");

    }
    public void EndRequire()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("oneday");

    }

    public void clickDev()
    {
        SceneManager.LoadScene("Development");

    }
    public void EndDev()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("End Sprint");

    }

    public void Clickdesign()
    {

        SceneManager.LoadScene("Design");

    }
    public void EndDesign()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("oneday2");

    }

    public void ClickTest()
    {
        SceneManager.LoadScene("Testing");

    }
    public void EndTest()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("Score");

    }

    public void nextskip()
    {
        next.SetActive(true);

    }

    void Start()
    {

        Invoke("nextskip", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
