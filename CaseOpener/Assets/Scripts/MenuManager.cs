using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private CanvasGroup menuPanel;
    [SerializeField] private CanvasGroup caseOpeningPanel;
    [SerializeField] private CanvasGroup winnerSkinPanel;

    public void OpenCasePanel()
    {
        menuPanel.alpha = 0;
        menuPanel.interactable = false;
        menuPanel.blocksRaycasts = false;

        caseOpeningPanel.alpha = 1;
        caseOpeningPanel.interactable = true;
        caseOpeningPanel.blocksRaycasts = true;
    }

    public void CloseCasePanel()
    {
        menuPanel.alpha = 1;
        menuPanel.interactable = true;
        menuPanel.blocksRaycasts = true;

        caseOpeningPanel.alpha = 0;
        caseOpeningPanel.interactable = false;
        caseOpeningPanel.blocksRaycasts = false;
    }

    public void OpenWinnerSkinPanel()
    {
        winnerSkinPanel.alpha = 1;
        winnerSkinPanel.interactable = true;
        winnerSkinPanel.blocksRaycasts = true;
    }

    public void CloseWinnerSkinPanel()
    {
        winnerSkinPanel.alpha = 0;
        winnerSkinPanel.interactable = false;
        winnerSkinPanel.blocksRaycasts = false;

        CloseCasePanel();
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Quitted");
    }

    public void OpenCase()
    {
        SkinPicker.instance.OpenCase();
    }
}
