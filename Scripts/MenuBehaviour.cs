using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    public void OnButtonOneClicked()
    {
        GameManager.Instance.UpdateSignageState(GameManager.SignageState.PlayContentOne);
    }

    public void OnButtonTwoClicked()
    {
        GameManager.Instance.UpdateSignageState(GameManager.SignageState.PlayContentTwo);
    }

    public void OnButtonThreeClicked()
    {
        GameManager.Instance.UpdateSignageState(GameManager.SignageState.PlayContentThree);
    }

    public void OnButtonFourClicked()
    {
        GameManager.Instance.UpdateSignageState(GameManager.SignageState.PlayContentFour);
    }

    public void OnButtonFiveClicked()
    {
        GameManager.Instance.UpdateSignageState(GameManager.SignageState.PlayContentFive);
    }

    public void OnButtonResetClicked()
    {
        GameManager.Instance.UpdateSignageState(GameManager.SignageState.PlayWelcomeLoop);
    }
}
