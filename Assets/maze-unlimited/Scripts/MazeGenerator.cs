using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour {
    public GameObject MazeComponent;
    private List<MazeComponent> mazeComponents = new List<MazeComponent>();
    void Awake() {
        // TODO: Generate with SimplePool
        GenerateMaze(); // TODO: remove
    }    
    public void GenerateMaze(int size = 5) {
        LayMazeFoundation(size);
        foreach(MazeComponent mc in mazeComponents) {
            
        }
    }

    private void LayMazeFoundation(int size) {
        for(int i = 0; i < size; i++) {
            for(int j = 0; j < size; j++) {
                mazeComponents.Add((GameObject.Instantiate(MazeComponent, new Vector3(i, 0, j), Quaternion.identity) as GameObject).GetComponent<MazeComponent>());
            }
        }
    }
}
