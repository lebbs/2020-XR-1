using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CognitiveVR;

public class exitpoll : MonoBehaviour
{
    //public ExitPollSet questionSet;
    // Start is called before the first frame updat    

    //public void QuestionSet()
    //{
    //    CognitiveVR.ExitPoll.NewExitPoll("xr_1_demo").Begin();

    //}

    private void Start()
    {
        CognitiveVR.ExitPoll.NewExitPoll("xr_1_demo").Begin();
    }

}
