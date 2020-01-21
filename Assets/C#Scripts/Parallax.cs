using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Transform cam;
    Vector3 previousCamPos;
    public float parallaxScaleX;
    public float parallaxScaleY;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
        previousCamPos = cam.position;
    }

    // Update is called once per frame
    void Update()
    {
        float parallaxX = (previousCamPos.x - cam.position.x) * parallaxScaleX;
        float parallaxY = (previousCamPos.y - cam.position.y) * parallaxScaleY;
        Vector3 pos = transform.position;
        pos.x += parallaxX;
        pos.y += parallaxY;
        transform.position = pos;
        previousCamPos = cam.position;
    }
}
