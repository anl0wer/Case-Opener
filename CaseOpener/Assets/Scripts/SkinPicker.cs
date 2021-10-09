using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinPicker : MonoBehaviour
{
    [Header("Skins")]
    [SerializeField] private Sprite[] allSkins;

    /* 0 = AUG - BLUE
     * 1 = G3SG1 - BLUE
     * 2 = MP7 - BLUE
     * 3 = PP-BIZON - BLUE
     * 4 = USP-S - BLUE
     * 5 = MAG7 - PURPLE
     * 6 = FAMAS - PURPLE
     * 7 = FIVE SEVEN - PURPLE
     * 8 = M4A4 - PURPLE
     * 9 = MAC-10 - PINK
     * 10 = GLOCK-18 - PINK
     * 11 = SSG-08 - PINK
     * 12 = AK-47 - RED
     * 13 = DESERT EAGLE - RED
     * 14 = Butterfly - Yellow
     * */

    [Header("Slots")]
    [SerializeField] private Image[] allSlots;

    public void OpenCase()
    {
        RandomSkinPlacement();
        RandomWinner();
    }

    void RandomSkinPlacement()
    {
        for (int i = 0; i < allSlots.Length - 1; i++)
        {
            switch (Random.Range(0, 10))
            {
                case 1:
                    allSlots[i].sprite = allSkins[0]; // AUG - BLUE
                    break;

                case 2:
                    allSlots[i].sprite = allSkins[1]; // G3SG1 - BLUE
                    break;

                case 3:
                    allSlots[i].sprite = allSkins[2]; // MP7 - BLUE
                    break;

                case 4:
                    allSlots[i].sprite = allSkins[3]; // PP-BIZON - BLUE
                    break;

                case 5:
                    allSlots[i].sprite = allSkins[4]; // USP-S - BLUE
                    break;

                case 6:
                    allSlots[i].sprite = allSkins[5]; // MAG7 - PURPLE
                    break;

                case 7:
                    allSlots[i].sprite = allSkins[6]; // FAMAS - PURPLE
                    break;

                case 8:
                    allSlots[i].sprite = allSkins[7]; // FIVE SEVEN - PURPLE
                    break;

                case 9:
                    allSlots[i].sprite = allSkins[8]; // M4A4 - PURPLE
                    break;
            }
        }
    }

    void RandomWinner()
    {
        int randomWinner = Random.Range(0, 101);
        print(randomWinner);

        if (randomWinner > 97)  // %3 Chance
        {
            allSlots[23].sprite = allSkins[14];
        }

        else if (randomWinner > 90) // %10 Chance
        {
            switch (Random.Range(0, 3)) 
            {
                case 1:
                    allSlots[23].sprite = allSkins[13];
                    break;

                case 2:
                    allSlots[23].sprite = allSkins[12];
                    break;
            }
        }

        else if (randomWinner > 80) // %20 Chance
        {
            switch (Random.Range(0, 4))
            {
                case 1:
                    allSlots[23].sprite = allSkins[11];
                    break;

                case 2:
                    allSlots[23].sprite = allSkins[10];
                    break;

                case 3:
                    allSlots[23].sprite = allSkins[9];
                    break;
            }
        }

        else if (randomWinner > 60) // %40 Chance
        {
            switch (Random.Range(0, 5))
            {
                case 1:
                    allSlots[23].sprite = allSkins[8];
                    break;

                case 2:
                    allSlots[23].sprite = allSkins[7];
                    break;

                case 3:
                    allSlots[23].sprite = allSkins[6];
                    break;

                case 4:
                    allSlots[23].sprite = allSkins[5];
                    break;
            }
        }

        else // %100 Chance
        {
            switch (Random.Range(0, 6))
            {
                case 1:
                    allSlots[23].sprite = allSkins[4];
                    break;

                case 2:
                    allSlots[23].sprite = allSkins[3];
                    break;

                case 3:
                    allSlots[23].sprite = allSkins[2];
                    break;

                case 4:
                    allSlots[23].sprite = allSkins[1];
                    break;

                case 5:
                    allSlots[23].sprite = allSkins[0];
                    break;
            }
        }
    }
}
