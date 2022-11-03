using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CarController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backLeftTransform;
    [SerializeField] Transform backRighTransform;



    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 5f;

    private float curretAcceleration = 0f;
    private float currentBreakForce = 0f;

    private float currentTurnAngle = 0f;    


    private void FixedUpdate()
    {
        curretAcceleration = acceleration * Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;
        // Applying acceleration on Front Wheel
        frontRight.motorTorque = curretAcceleration;
        frontLeft.motorTorque = curretAcceleration;
        backRight.motorTorque = curretAcceleration;
        backLeft.motorTorque = curretAcceleration;
        //Applying Break force to all wheel
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;


        // Take care of the steering

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal"); ;
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;



        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(backLeft, backLeftTransform);
        UpdateWheel(backRight, backRighTransform);






        void UpdateWheel(WheelCollider col, Transform trans)
        {
            // Home wheel Collider State
            Vector3 position;
            Quaternion rotation;
            col.GetWorldPose(out position, out rotation);



            //Set wheel transform state.

            trans.position = position;
            trans.rotation = rotation;
        }





    }
}
















/*
        float motorT = Input.GetAxis("Vertical") * maxSpeed;
        float steerA = Input.GetAxis("Horizontal") * maxSteer;

        front_wheels[0].motorTorque = motorT;
        front_wheels[1].motorTorque = motorT;

        front_wheels[0].steerAngle = steerA;
        front_wheels[1].steerAngle = steerA;

        if (Mathf.Abs(Input.GetAxis("Vertical"))>0.01)
        {
            front_wheels[0].brakeTorque = 0;
            front_wheels[1].brakeTorque = 0;

        }
        else
        {
            front_wheels[0].brakeTorque = 220;
            front_wheels[1].brakeTorque = 220;
        }*/


    // Start is called before the first frame update
  

