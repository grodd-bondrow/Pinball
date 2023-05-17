using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D left, right;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            left.AddTorque(25f);
        }
        else
        {
            left.AddTorque(-20f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            right.AddTorque(-25f);
        }
        else
        {
            right.AddTorque(20f);
        }
    }
}
