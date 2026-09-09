using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public GameObject creditsPrefab;

    public void ShowCredits()
    {
        Instantiate(creditsPrefab);
    }
}