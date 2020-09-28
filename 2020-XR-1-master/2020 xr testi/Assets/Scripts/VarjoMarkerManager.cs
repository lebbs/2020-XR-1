using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;

public class VarjoMarkerManager : MonoBehaviour
{



    [Serializable]
    public struct TrackedObject
    {
        public long id;
        public GameObject gameObject;
    }
    // Array kaikille seuratuille objekteille
    public TrackedObject[] trackedObjects = new TrackedObject[1];
    
    //Lista l�ydetyille markkereille
    private List<VarjoMarker> markers = new List<VarjoMarker>();

    //Lista poistettujen markkereiden id
    private List<long> removedMarkerIds = new List<long>();


    private void OnEnable()
    {
        VarjoMarkers.EnableVarjoMarkers(true);
    }

    private void OnDisable()
    {
        VarjoMarkers.EnableVarjoMarkers(false);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (VarjoMarkers.IsVarjoMarkersEnabled())
        {
            VarjoMarkers.GetVarjoMarkers(out markers);

            foreach(var marker in markers)
            {
                for ( var i = 0; i < trackedObjects.Length; i++)
                {
                    if(trackedObjects[i].id == marker.id)
                    {
                        trackedObjects[i].gameObject.SetActive(true);
                        trackedObjects[i].gameObject.transform.localPosition = marker.pose.position;
                        trackedObjects[i].gameObject.transform.localRotation = marker.pose.rotation;
                    }
                }
            }
            VarjoMarkers.GetRemovedVarjoMarkerIds(out removedMarkerIds);

            foreach (var id in removedMarkerIds)
            {
                for (var i = 0; i < trackedObjects.Length; i++)
                {
                    if (trackedObjects[i].id == id)
                    {
                        trackedObjects[i].gameObject.SetActive(false);
                    }
                }
            }
        }   
    }
}