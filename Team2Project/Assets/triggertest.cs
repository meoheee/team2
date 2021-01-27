using UnityEngine;

public class triggertest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collider other)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay(Collider other)
    {

    }
    private void OnCollisionExit(Collider other)
    {

    }
}
   