using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		if (PauseMenu.GameIsPaused == true)
		{
            m_MyAudioSource.Stop();
        }
        else if (PauseMenu.GameIsPaused == false)
        {
            m_MyAudioSource.Play();
        }
    }
}
