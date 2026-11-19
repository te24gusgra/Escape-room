using UnityEngine;

public class WinManagement : MonoBehaviour
{
    public bool hasWon = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hasWon = true;
    }
}
