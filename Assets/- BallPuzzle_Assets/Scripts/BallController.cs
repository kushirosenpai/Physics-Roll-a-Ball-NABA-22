using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 5; // The force added to the ball to move it.
        [SerializeField] private bool m_UseTorque = true; // Whether or not to use torque to move the ball.
        [SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.
        [SerializeField] private float m_JumpPower = 2; // The force added to the ball when it jumps.
        [SerializeField] private float m_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.
        [SerializeField] private bool m_CanDash = false;
        [SerializeField] private KeyCode m_DashKey;
        [SerializeField] private float m_DashForce = 1;
        
        private Rigidbody m_Rigidbody;

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            // Set the maximum angular velocity.
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }

        private void Update()
        {
            Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));

            Jump();

            Dash();
        }

        public void Move(Vector3 moveDirection)
        {
            // If using torque to rotate the ball...
            if (m_UseTorque)
            {
                // ... add torque around the axis defined by the move direction.
                m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x) * m_MovePower);
            }
            else
            {
                // Otherwise add force in the move direction.
                m_Rigidbody.AddForce(moveDirection * m_MovePower);
            }
        }

        public void Jump()
        {
            // If on the ground and jump is pressed...
            if (Input.GetButtonDown("Jump") && Physics.Raycast(transform.position, -Vector3.up, m_GroundRayLength))
            {
                // ... add force in upwards.
                m_Rigidbody.AddForce(Vector3.up * m_JumpPower, ForceMode.Impulse);

            }
        }

        public void Dash()
        {
            if (Input.GetKeyDown(m_DashKey) && m_CanDash)
            {
                m_Rigidbody.AddForce(m_Rigidbody.velocity * m_DashForce, ForceMode.Impulse);
            }
        }

    }
}