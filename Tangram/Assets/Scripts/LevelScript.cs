using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public static int actualLevel=1;
    public static int numPieces = 7;

    public void level1() { actualLevel = 1; numPieces = 7; }
    public void level2() { actualLevel = 2; numPieces = 7; }
    public void level3() { actualLevel = 3; numPieces = 7; }
    public void level4() { actualLevel = 4; numPieces = 7; }
    public void level5() { actualLevel = 5; numPieces = 7; }
    public void level6() { actualLevel = 6; numPieces = 7; }
    public void level7() { actualLevel = 7; numPieces = 7; }
    public void level8() { actualLevel = 8; numPieces = 6; }
    public void level9() { actualLevel = 9; numPieces = 6; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
