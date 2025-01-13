using System;
using UnityEngine;


public class CameraSwitch : MonoBehaviour
{

    Vector3[] cameraPos;
    Vector3[] cameraRot;

    private void Start()
    {

        cameraPos = new[]
        {
            new Vector3(7.09f, 29.27f, -17.45f), // camera 0 pos
            new Vector3(6.42f, 25.19f, -17.57f),  // camera 1 pos
            new Vector3(6.95f, 15f, -11.25f),  // camera 2 pos
            new Vector3(16.43f, 20.02f, -9.88f)  // camera 3 pos
        };

        cameraRot = new[]
        {
            new Vector3(46.81f, -0.3f, 0.8f), //camera 0 rot
            new Vector3(53.95f, 0f, 0f),
            new Vector3(15.914f, -8.945f, -2.667f),
            new Vector3(29.138f, 36.66f, 0.17f)
        };
        
       
    }
    
    public void MoveCamera(int index)
    {   
        Camera cam = Camera.main;
        cam.transform.position = cameraPos[0];
        cam.transform.rotation = Quaternion.Euler(cameraRot[index].x, cameraRot[index].y, cameraRot[index].z);
        print("Setting camera to index " + index);
    }






    //Camera cam = GetComponent<Camera>();

    /*currentCam = 0;

           for (int i = 1; i<cameras.Length; i++)
           {
               //cameras[i].enabled = false;
               cameras[i].gameObject.SetActive(false);
           }

           if (cameras.Length > 0)
           {
               cameras[0].gameObject.SetActive(true);
           }*/
    //idk if this is supposerd to be public...
    /*public void NextCamera()
    {
        currentCam++;
        print("Camera has been switched to" + currentCam);

        if (currentCam < cameras.Length)
        {
            cameras[currentCam-1].gameObject.SetActive(false);
            cameras[currentCam].gameObject.SetActive(true);
        }
        else
        {
            cameras[currentCam - 1].gameObject.SetActive(false);
            currentCam = 0;
            cameras[currentCam].gameObject.SetActive(true);
        }
    }*/

}
