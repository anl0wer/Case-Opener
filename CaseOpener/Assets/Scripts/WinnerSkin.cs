using UnityEngine;

public class WinnerSkin : MonoBehaviour
{
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

    public MenuManager menu;

    private Color pinkColor, purpleColor, blueColor;

    public void ShowWinnerSkin()
    {
        ColorUtility.TryParseHtmlString("#de00ff", out pinkColor);
        ColorUtility.TryParseHtmlString("#913ee1", out purpleColor);
        ColorUtility.TryParseHtmlString("#325bdb", out blueColor);

        switch (SkinPicker.instance.winnerSkinIndex)
        {
            case 14: 
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[14];
                SkinPicker.instance.winnerSkinText.color = Color.yellow;
                SkinPicker.instance.winnerSkinText.text = "Butterfly - Doppler";
                break;

            case 13:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[13];
                SkinPicker.instance.winnerSkinText.color = Color.red;
                SkinPicker.instance.winnerSkinText.text = "Desert Eagle - Ocean Drive";
                break;

            case 12:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[12];
                SkinPicker.instance.winnerSkinText.color = Color.red;
                SkinPicker.instance.winnerSkinText.text = "AK47 - Leet Museo";
                break;

            case 11:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[11];
                SkinPicker.instance.winnerSkinText.color = pinkColor;
                SkinPicker.instance.winnerSkinText.text = "SSG08 - Turbo Peek";
                break;

            case 10:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[10];
                SkinPicker.instance.winnerSkinText.color = pinkColor;
                SkinPicker.instance.winnerSkinText.text = "GLOCK18 - Snack Attack";
                break;

            case 9:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[9];
                SkinPicker.instance.winnerSkinText.color = pinkColor;
                SkinPicker.instance.winnerSkinText.text = "MAC10 - Toybox";
                break;

            case 8:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[8];
                SkinPicker.instance.winnerSkinText.color = purpleColor;
                SkinPicker.instance.winnerSkinText.text = "M4A4 - Spider Lily";
                break;

            case 7:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[7];
                SkinPicker.instance.winnerSkinText.color = purpleColor;
                SkinPicker.instance.winnerSkinText.text = "FIVE SEVEN - Boost Protocol";
                break;

            case 6:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[6];
                SkinPicker.instance.winnerSkinText.color = purpleColor;
                SkinPicker.instance.winnerSkinText.text = "FAMAS - ZX Spectron";
                break;

            case 5:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[5];
                SkinPicker.instance.winnerSkinText.color = purpleColor;
                SkinPicker.instance.winnerSkinText.text = "MAG7 - BI83 Spectrum";
                break;

            case 4:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[4];
                SkinPicker.instance.winnerSkinText.color = blueColor;
                SkinPicker.instance.winnerSkinText.text = "USP-S - Black Lotus";
                break;

            case 3:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[3];
                SkinPicker.instance.winnerSkinText.color = blueColor;
                SkinPicker.instance.winnerSkinText.text = "PP-BIZON - Lumen Case";
                break;

            case 2:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[2];
                SkinPicker.instance.winnerSkinText.color = blueColor;
                SkinPicker.instance.winnerSkinText.text = "MP7 - Guerilla Incase";
                break;

            case 1:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[1];
                SkinPicker.instance.winnerSkinText.color = blueColor;
                SkinPicker.instance.winnerSkinText.text = "G3SG1 - Keeping Tabs";
                break;

            case 0:
                SkinPicker.instance.winnerSkinImage.sprite = SkinPicker.instance.allSkins[0];
                SkinPicker.instance.winnerSkinText.color = blueColor;
                SkinPicker.instance.winnerSkinText.text = "AUG - Plague";
                break;
        }

        SkinPicker.instance.caseAnimation.Rebind();
        SkinPicker.instance.caseAnimation.Update(0f);

        menu.OpenWinnerSkinPanel();
        
    }
}
