﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save
{
    //怪物数据
    public List<int> livingTargetPositions = new List<int>();
    public List<int> livingMonsterTypes = new List<int>();

    public int shootNum = 0;
    public int score = 0;
}
