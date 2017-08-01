using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class Menu : MonoBehaviour
    {

        public GameObject screen;

        void Start()
        {
            Activate("Festivals");
        }

        public void Activate(string name)
        {
            foreach (Transform transform in screen.transform)
            {
                GameObject gameObject = transform.gameObject;
                gameObject.SetActive(gameObject.name == name);
            }
        }
    }
}