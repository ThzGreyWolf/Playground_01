// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

enum CreatureType {
    human, liveStock, pet
}

enum Status {
    dead, free, working, undead, enraged
}
public class Creature {
    public double health, stamina, speed;
    private Status m_status;

    public void updateStatus() {
        
    }
}
