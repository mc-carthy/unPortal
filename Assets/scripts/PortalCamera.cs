using UnityEngine;

public class PortalCamera : MonoBehaviour 
{

    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    private void Update() 
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDiffBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDiffBetweenPortalRotations, Vector3.up);
        Vector3 newCamDir = portalRotationalDifference * playerCamera.forward;

        transform.rotation = Quaternion.LookRotation(newCamDir, Vector3.up);
    }
    
}
