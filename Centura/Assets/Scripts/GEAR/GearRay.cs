using UnityEngine;

public class ClockRay : MonoBehaviour
{
    public int degreesPerSecond = 90;
    private LayerMask layerMask;

    void Awake()
    {
        layerMask = LayerMask.GetMask("Targets");
    }

    void Start()
    {
        Debug.Log(LayerMask.GetMask("Targets"));
    }

    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void Update()
    {

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            if (hit.collider.TryGetComponent<ActionScript>(out ActionScript actionScript))
            {
                actionScript.TakeActionFunction();
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                //Debug.Log("Did Hit " + hit.collider);
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);


    }
}