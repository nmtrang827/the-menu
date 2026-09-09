using UnityEngine;

public class CloseCredits : MonoBehaviour
{
    public GameObject creditsCanvas;

    public void Close()
    {
        Destroy(creditsCanvas);
    }
}