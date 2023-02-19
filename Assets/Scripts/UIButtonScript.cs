using UnityEngine;
using UnityEngine.UI;
using Oculus.Platform;
using Oculus.Platform.Models;

public class UIButtonScript : MonoBehaviour
{
    public Button resumeButton;
    public Button quitButton;
    public Button spawnButton;
    public GameObject pauseMenu;  //UI
    public GameObject cubePrefab; // Assign the cube prefab in the inspector
    public Vector3 spawnPosition= new Vector3((float)-2.83699989, (float)0.891797364, (float)-3.64299989); // Assign the spawn position in the inspector
    private void Start()
    {
        // Add listener for when the resume button is clicked
        resumeButton.onClick.AddListener(Resume);

        //Add listener for when the Cube button is clicked

        spawnButton.onClick.AddListener(Spawn);
        // Add listener for when the quit button is clicked
        quitButton.onClick.AddListener(Quit);
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start)&& !pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(true);
        }
        if (OVRInput.GetDown(OVRInput.Button.Start) && pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }


    }


    private void Resume()
    {
        // Unpause the game
        Time.timeScale = 1;
    }

    private void Quit()
    {
        // Code to quit the game goes here
        UnityEngine.Application.Quit();
    }
    private void Spawn()
    {
        // Instantiate the cube at the specified position
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }

}
