using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    
    public float maxZoom;
    public float zoom = 6;
    private float minZoom = 6;
    private Color color = Color.black;
    private Camera cam;
    public Collider2D player;
    public bool inCarriage = false;
    private float changePerSecond = -1;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.orthographicSize = zoom;
    }

    void Update()
    {
        //cam.backgroundColor = color;
        if(inCarriage == false && zoom < maxZoom)
        {
            //cam.clearFlags = CameraClearFlags.Skybox;
            cam.orthographicSize = zoom += 10f * Time.deltaTime;
        }
        if(inCarriage == true && zoom > minZoom)
        {
            //cam.clearFlags = CameraClearFlags.SolidColor;
            cam.orthographicSize = zoom -= 10f * Time.deltaTime;
        }
    }
}
