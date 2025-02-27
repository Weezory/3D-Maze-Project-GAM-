using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 10;
    
    private Vector3 offset;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //calculates how far the camera is from the target (Player)
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if Player exists
        if (target == null)
        {
            enabled = false;
            return;
        }
        
        //Where cam should go
        //Lerp - Linear Interpolation (Smoothens movement?)
        //Move Towards
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, transitionSpeed * Time.deltaTime);

    }
}
