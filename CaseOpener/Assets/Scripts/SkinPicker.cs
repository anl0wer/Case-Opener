using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinPicker : MonoBehaviour
{
    [Header("Skins")]
    [SerializeField] private Sprite[] allSkins;

    [Header("Slots")]
    [SerializeField] private Image[] allSlots= new Image[20];

    void Start()
    {
        RandomSkinPlacement();
        RandomWinner();
    }

    void RandomSkinPlacement()
    {
        for (int i = 0; i < allSlots.Length - 1; i++)
        {
            int randomSkin = Random.Range(0, 3);
            switch (randomSkin)
            {
                case 1:
                    allSlots[i].sprite = allSkins[0];
                    break;

                case 2:
                    allSlots[i].sprite = allSkins[1];
                    break;
            }
        }
    }

    void RandomWinner()
    {
        int randomWinner = Random.Range(0, 101);

        if (randomWinner > 99)
        {
            allSlots[20].sprite = allSkins[3]; // Knife %1
        }
        else if (randomWinner > 90)
        {
            allSlots[20].sprite = allSkins[2]; // EXAMPLE %10
        }
        else if (randomWinner > 80)
        {
            allSlots[20].sprite = allSkins[1]; // EXAMPLE %20
        }
        else if (randomWinner > 70)
        {
            allSlots[20].sprite = allSkins[0]; // EXAMPLE %30
        }
        else if (randomWinner > 60)
        {
            allSlots[20].sprite = allSkins[0]; // EXAMPLE %40
        }
        else if (randomWinner > 50)
        {
            allSlots[20].sprite = allSkins[0]; // EXAMPLE %50
        }
        else if (randomWinner > 40)
        {
            allSlots[20].sprite = allSkins[0]; // EXAMPLE %60
        }
        else if (randomWinner > 30)
        {
            allSlots[20].sprite = allSkins[0]; // EXAMPLE %70
        }
    }
}
