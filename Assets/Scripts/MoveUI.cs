using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUI : MonoBehaviour
{
    private void OnGUI()
    {
        Vector2 src = new Vector2(Screen.width / 16, Screen.height / 9);
        //GUI.Box(new Rect(src.x, src.y, src.x, src.y), "");

        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; x < 16; y++)
            {
                GUI.Box(new Rect(x, y, src.x, src.y), "");
            }
        }
    }
}
