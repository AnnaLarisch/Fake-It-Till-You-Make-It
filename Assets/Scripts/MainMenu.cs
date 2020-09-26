using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void LoadBaselineConditionParameter()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadBaselineCondition()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadCustomizationConditionParameter()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadCustomizationConditionMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadDynamicAdjustmentConditionParameter()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadDynamicAdjustmentCondition()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadExperimentFinish()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadQuid()
    {
        Application.Quit();
    }
}
