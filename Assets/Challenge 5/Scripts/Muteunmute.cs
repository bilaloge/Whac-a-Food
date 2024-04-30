using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muteunmute : MonoBehaviour
{
    [SerializeField] AudioSource m_AudioSource;

    private bool muted;
    // Start is called before the first frame update
    public void MuteCondition()
    {
        switch (muted)
        {
            case false:
                {
                    m_AudioSource.mute = false;
                    muted = true;
                    break;
                }
            case true:
                {
                    m_AudioSource.mute = true;
                    muted = false;
                    break;
                }
        }


    }
}
