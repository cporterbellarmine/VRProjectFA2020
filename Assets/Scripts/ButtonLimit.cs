using UnityEngine;

public class ButtonLimit : MonoBehaviour
{

    [SerializeField]

    private GameObject buttonTrigger;
    private Vector3 originalPosition;
    private float minDistance;
    private float maxDistance;

    void Awake()
    {
        //calculates distance between the activator and the trigger
        minDistance = Vector3.Distance(buttonTrigger.transform.position, transform.position);

        maxDistance = buttonTrigger.transform.position.y;

        originalPosition = transform.position;

    }//end Awake

    // Update is called once per frame
    void Update()
    {
        //If the distance is less than the minimum distance, then the distance is moved back up to the original position.
        if(Vector3.Distance(buttonTrigger.transform.position, transform.position) >= minDistance)
        {
            transform.position = originalPosition;
        }//end if

        //If the button is pressed, then the activator is reset.
        if(transform.position.y <= maxDistance)
        {
            transform.position = new Vector3(transform.position.x, maxDistance, transform.position.z);
        }//end if
    }//end Update

}//end ButtonLimit
