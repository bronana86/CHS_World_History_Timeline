using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Input;

public class CameraControl : MonoBehaviour
{
    /*
     * This script handles the camera controls for navigating the timeline.
     * Here's what I need from this script:
     * Ability to hold right click and drag the view around.
     * Ability to use WASD and the arrow keys to move the camera around.
     * Ability to use the scroll wheel to zoom in and out.
     * Bounds for camera movement to X and Y, as well as for the zoom.
    */

    //Some important values.
    public float zoomMax;
    public float zoomMin;
    public float zoomSpeed;

    public float xBound;
    public float yBound;

    //Checks for any interaction to indicate movement.
    void Update()
    {

    }
}
