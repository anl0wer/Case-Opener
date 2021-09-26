using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinPicker : MonoBehaviour
{
    [Header("Skins")]
    [SerializeField] private Sprite[] allSkins;

    [Header("Slots")]
    [SerializeField] private Image[] allSlots= new Image[21];

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
        if (randomWinner > 95)
        {
            allSlots[20].sprite = allSkins[2]; // Knife %5
            print("BIÇAK GELDÝ"+randomWinner);
        }
        else if (randomWinner>75)
        {
            allSlots[20].sprite = allSkins[1]; // EX %25
            print("SMG GELDÝ"+randomWinner);

        }
        else if (randomWinner > 50 || randomWinner<50)
        {
            allSlots[20].sprite = allSkins[0]; // EX %50
            print("GLOCK GELDÝ"+randomWinner);

        }
    }
}
