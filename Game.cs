using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment() {
        GameManager.swords += GameManager.multiplier;
    }

    public void buy(int num) {
        if(num == 1 && GameManager.swords >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.swords -= 25;
        }
        if(num == 2 && GameManager.swords >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.swords -= 125;
        }
        if(num == 3 && GameManager.swords >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.swords -= 1500;
        }
    }

    void Update() {
        ui.text = "Swords: " + GameManager.swords;
    }
}
