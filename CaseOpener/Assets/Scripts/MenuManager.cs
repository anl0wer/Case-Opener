using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private CanvasGroup menuPanel;
    [SerializeField] private CanvasGroup caseOpeningPanel;

    [Header("Classes")]
    [SerializeField] private SkinPicker skinPicker;

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

    public void OpenCase()
    {
        skinPicker.OpenCase();
    }
}
