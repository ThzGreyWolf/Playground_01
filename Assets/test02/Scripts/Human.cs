using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct Age {
    int years, days;
}

public class Human : Creature
{
    private string m_name;
    private Age m_age;
    private Status m_status;
}
