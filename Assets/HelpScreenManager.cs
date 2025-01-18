using UnityEngine;

public class HelpScreenManager : MonoBehaviour
{
    public GameObject helpPanel; // Reference to the Help Panel GameObject
    private bool isHelpActive = false; // Track if the Help screen is active or not

    void Start()
    {
        // Ensure the Help Panel is hidden when the game starts
        if (helpPanel != null)
        {
            helpPanel.SetActive(false); // Hide the Help Panel at the start
            Debug.Log("Help Panel hidden at start.");
        }
        else
        {
            Debug.LogError("Help Panel is not assigned in the Inspector!");
        }
    }

    void Update()
    {
        // Listen for the "H" key press to toggle the Help screen
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H key pressed! Toggling Help Screen.");
            ToggleHelpScreen();
        }
    }

    private void ToggleHelpScreen()
    {
        if (helpPanel != null)
        {
            // Toggle the active state of the helpPanel
            isHelpActive = !isHelpActive;
            helpPanel.SetActive(isHelpActive); // Show or hide the Help Panel

            // Pause or resume the game
            Time.timeScale = isHelpActive ? 0 : 1; // Pause if Help screen is active, else resume
            Debug.Log("Help Panel visibility: " + (isHelpActive ? "Visible" : "Hidden"));
        }
        else
        {
            Debug.LogWarning("Help Panel is not assigned in the Inspector!");
        }
    }
}
