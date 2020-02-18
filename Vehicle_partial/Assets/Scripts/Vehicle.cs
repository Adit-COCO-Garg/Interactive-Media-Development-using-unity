using UnityEngine;

public class Vehicle : MonoBehaviour
{
    
    public float speed;                         // Speed of the vehicle
    public Vector3 vehiclePosition;             // Local vector for calculation
    public Vector3 direction;                   // Way the vehicle should move
    public Vector3 velocity;                    // Change in X and Y
    float maxSpeed = 1f;

	// Use this for initialization
	void Start ()
    {
        vehiclePosition = new Vector3(0, 0, 0);     // Or you could say Vector3.zero
        direction = new Vector3(0, 0, 0);           // Facing right
        velocity = new Vector3(0, 0, 0);            // Starting still (no movement)
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            speed+= (float)1;
            direction = new Vector3(0, 0.01f, 0);
        }
            
        else if (Input.GetKey(KeyCode.DownArrow)) 
        {
            speed -= (float)0.01;
        }
                
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Rotate(Vector3.forward);
        }
                    
        else if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.Rotate(Vector3.back);
        }
        else
        {
            if (speed > (float)0) 
            {
                speed -= (float)0.01;
            }
            
        }

        // Velocity is direction with speed
        velocity = direction * speed;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        // Add velocity to vehicle's position
        vehiclePosition += velocity;

        // Set the transform position
        transform.position = vehiclePosition;
    }
}
