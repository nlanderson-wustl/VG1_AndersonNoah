using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Q2
{
    public class RotatingShipController : MonoBehaviour
    {
        //Outlets
        Rigidbody2D _rb;
        
        //Configuration
        
        public float speed;
        public float rotationSpeed;
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();

        }

        // Update is called once per frame
        void Update()
        {
            //Turn Left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rb.AddTorque(rotationSpeed * Time.deltaTime);
            }
            
            //Turn Left
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _rb.AddTorque(-rotationSpeed * Time.deltaTime);
            }
            
            //Turn Left
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rb.AddRelativeForce(Vector2.right * speed * Time.deltaTime);
            }

        }
    }
}
