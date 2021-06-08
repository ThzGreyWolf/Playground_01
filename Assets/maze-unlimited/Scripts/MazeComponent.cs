using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeComponent : MonoBehaviour {
    public GameObject[] walls;

    public void removeWall(int index) {
        walls[index].SetActive(false);
    }
}
