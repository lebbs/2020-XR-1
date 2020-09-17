using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CognitiveVR;

public class exitpoll : MonoBehaviour
{
    public ExitPollSet questionSet;
     void Start()
    {
        CognitiveVR.ExitPoll.NewExitPoll("testi").Begin();
    }

}
