using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTransitionScript : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;

    // Update is called once per frame
    void Update ()
    {
      if (Input.GetMouseButtonDown(0)) //This is the trigger to transition to fade out and next scene
        {
            FadeToNextLevel();
        }
    }

    public void FadeToNextLevel ()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
