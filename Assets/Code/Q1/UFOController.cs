using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Q1
{
    public class UFOController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Move Up
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 0.02f, 0);
            }

            // Move Down
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += new Vector3(0, -0.02f, 0);
            }

            // Move Up
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-0.02f, 0f, 0);
            }

            // Move Up
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(0.02f, 0, 0);
            }

        }
    }
}
