using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Beginning : MonoBehaviour
{
    bool playing;

    private void Update()
    {
        if (gameObject.GetComponent<VideoPlayer>().isPlaying == true)
        {
            playing = true;
        }

        if (playing)
        {
            if (gameObject.GetComponent<VideoPlayer>().isPlaying == false)
            {
                SceneManager.LoadScene("MasterScene");
            }
        }


    }

    //void Start()
    //{


    //    StartCoroutine(EndLevel());
    //}

    //IEnumerator EndLevel()
    //{
    //    yield return new WaitForSeconds(57);
    //    SceneManager.LoadScene("MasterScene");
    //}
}
