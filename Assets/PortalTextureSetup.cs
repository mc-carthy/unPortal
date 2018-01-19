using UnityEngine;

public class PortalTextureSetup : MonoBehaviour 
{
    public Camera camB;
    public Material camMatB;

    private void Awake()
    {
        if (camB.targetTexture != null)
        {
            camB.targetTexture.Release();
        }
        camB.targetTexture = new RenderTexture(Screen.width, Screen.width, 24);
        camMatB.mainTexture = camB.targetTexture;
    }
}
