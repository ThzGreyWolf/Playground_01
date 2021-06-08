using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] cubes;
    [SerializeField]
    private Material[] mats;
    [SerializeField]
    private float speedDivider;
    
    private int selectedCubeIndex = -1;
    private float mouseStartPos;
    void Start() {
        for(int w = 0; w < cubes.Length; w++) {
            cubes[w].position = new Vector3(cubes[w].position.x, Random.Range(-1f, 1f), 0);
        }    
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50f)) {
                if(hit.collider.tag == "Cube") {
                    hit.collider.GetComponent<MeshRenderer>().material = mats[1];
                    for(int w = 0; w < cubes.Length; w++) {
                        if(cubes[w].gameObject != hit.collider.gameObject) {
                            cubes[w].gameObject.GetComponent<MeshRenderer>().material = mats[0];
                        } else {
                            selectedCubeIndex = w;
                        }
                    }

                    mouseStartPos = Input.mousePosition.y; 
                }
            }
        } else if(Input.GetMouseButtonUp(0)) {
            if(selectedCubeIndex != -1) {
                cubes[selectedCubeIndex].gameObject.GetComponent<MeshRenderer>().material = mats[0];
                selectedCubeIndex = -1;
            }
        }
    }

    void FixedUpdate() {
        if(selectedCubeIndex != -1) {
            float oriYPos = cubes[selectedCubeIndex].position.y;

            cubes[selectedCubeIndex].position = new Vector3(cubes[selectedCubeIndex].position.x, cubes[selectedCubeIndex].position.y - ((mouseStartPos - Input.mousePosition.y)/speedDivider), 0);
            mouseStartPos = Input.mousePosition.y;

            float valToMove = (oriYPos - cubes[selectedCubeIndex].position.y) / 6;

            for(int w = 0; w < cubes.Length; w++) {
                if(w != selectedCubeIndex) {
                    cubes[w].position = new Vector3(cubes[w].position.x, cubes[w].position.y + valToMove, 0);
                }
            }
        }
    }
}