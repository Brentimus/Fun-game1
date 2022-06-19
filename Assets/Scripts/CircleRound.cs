using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRound : MonoBehaviour
{
    private float holdDownStartTime;
    [SerializeField]
    private float raiseSpeedFloat = 0f;
    [SerializeField]
    private float maxSpeed = 2.6f;

    [SerializeField] AudioSource blust;

    public Transform firePoint;
    public GameObject bulletPref;
    public Rigidbody2D rb;
    public CameraController cameraController;

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            holdDownStartTime = Time.time;
        }

        if (Input.GetMouseButton(0))
        {
            float holdDownTime = (Time.time - holdDownStartTime) + 1.1f;
            if (Mathf.Abs(raiseSpeedFloat - holdDownTime ) > 0f)
                gameObject.transform.Rotate(0f, 0f, raiseSpeedFloat - holdDownTime);
            else
                gameObject.transform.Rotate(0f, 0f, 0f);

        } else
            gameObject.transform.Rotate(0f, 0f, RaiseSpeed());

        if (Input.GetMouseButtonUp(0))
        {
            blust.Play();
            //float holdDownTime = Time.time - holdDownStartTime + 1f;
            //gameObject.transform.Rotate(0f, 0f, -holdDownTime);
            raiseSpeedFloat = -0.3f;
            Destroy(Instantiate(bulletPref, firePoint.position, firePoint.rotation), 2f);
            cameraController.ShakeCamera();
        }
    }

    private float RaiseSpeed()
    {
        if (raiseSpeedFloat <= maxSpeed)
            raiseSpeedFloat += 1.4f * Time.deltaTime;

        return raiseSpeedFloat;
    }
}
