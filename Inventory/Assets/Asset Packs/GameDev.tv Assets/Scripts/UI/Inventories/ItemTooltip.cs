﻿using UnityEngine;
using TMPro;

namespace GameDevTV.Core.UI.Tooltips
{
    public class ItemTooltip : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI titleText;
        [SerializeField] TextMeshProUGUI bodyText;

        public string title
        {
            set
            {
                titleText.text = value;
            }
            get
            {
                return titleText.text;
            }
        }

        public string body
        {
            set
            {
                bodyText.text = value;
            }
            get
            {
                return bodyText.text;
            }
        }
    }
}