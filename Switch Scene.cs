﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swtich_Scene_Login_to_Register : MonoBehaviour {
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);

    }
}
