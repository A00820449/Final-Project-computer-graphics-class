using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPause : MonoBehaviour
{
    AudioSource bgm;
    TurnAround marioScript;
    bool playing = true;
    // Start is called before the first frame update
    void Start()
    {
        // Getting components
        bgm = GetComponent<AudioSource>();
        marioScript = GameObject.FindWithTag("Player").GetComponent<TurnAround>();
    }

    // Update is called once per frame
    void Update()
    {
        // If Mario is turned around pause the music
        if (marioScript.TURNED_AROUND)
        {
            if (playing)
            {
                bgm.Pause();
                playing = false;
            }
        }
        // If Mario turns back, resume
        else
        {
            if (!playing)
            {
                bgm.UnPause();
                playing = true;
            }
        }
    }
}
