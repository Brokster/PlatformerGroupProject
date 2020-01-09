using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threeshotblast : MonoBehaviour
{
    public GameObject prefab;
    public float numShots = 5;            // Number of shots fired (should be odd); 
    public float spreadAngle = 2.0f;       // Angle between shots
    public float timeBetweenShots = 0.5f;  // Minimum time between shots
    public float nextShot = 0.0f;
    void Start()
    {
        if (numShots / 2 * 2 == numShots) numShots++; // Need an odd number of shots
        if (numShots < 3) numShots = 3;  // At least 3 shots for a fan
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextShot)
        {

            nextShot = Time.time + timeBetweenShots;
            var qAngle = Quaternion.AngleAxis(-numShots / 2.0f * spreadAngle, transform.up) * transform.rotation;
            var qDelta = Quaternion.AngleAxis(spreadAngle, transform.up);
            for (var i = 0; i < numShots; i++)
            {
                var go = (GameObject)Instantiate(prefab, transform.position, qAngle);
                go.rigidbody.AddForce(go.transform.forward * 1000.0);
                qAngle = qDelta * qAngle;
            }
        }
    }
}
