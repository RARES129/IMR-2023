using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectLandingDistanceCalculator : MonoBehaviour
{
    private XRGrabInteractable interactable;
    private Vector3 initialPosition;
    private Vector3 landingPosition;

    private void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnSelectEnter);
        interactable.selectExited.AddListener(OnSelectExit);
        
}

    private void OnSelectEnter(SelectEnterEventArgs args)
    {
        initialPosition = transform.position;
    }

    private void OnSelectExit(SelectExitEventArgs args)
    {
        float distance = Vector3.Distance(initialPosition, transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.CompareTag("Ground"))
            {
                landingPosition = transform.position;
                float distance = Vector3.Distance(initialPosition, landingPosition);
                Debug.Log("Distanta fata de pozitia initiala: " + distance.ToString("F2") + " unitati de masura preferate");
            }
    }

    private void Update()
    {

    }
}
