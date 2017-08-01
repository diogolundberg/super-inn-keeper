using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class Festivals : MonoBehaviour
    {
        public RectTransform festivals;
        public GameObject festivalRow;

        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject row = (GameObject)Instantiate(festivalRow);
                row.transform.SetParent(festivals, false);
                Button button = row.GetComponent<Button>();

                button.onClick.AddListener(() => Debug.Log("Button clicked"));
            }

        }
    }
}