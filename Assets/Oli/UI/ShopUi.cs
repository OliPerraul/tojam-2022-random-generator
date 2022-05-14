using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cirrus.Unity.Objects;

namespace Tojam2022
{
    public class ShopUi : SingletonComponentBase<ShopUi>
    {
        [SerializeField]
        private RectTransform _shopItemTransform;

        [SerializeField]
        private Button _shopButton;

        [SerializeField]
        private RectTransform _shopTransform;

        [SerializeField]
        private List<Deco> _decos;

        [SerializeField]
        private ShopUiItem _shopItemPrefab;

        //[SerializeField]
        //private ShopI

		public override void Awake()
		{
            _shopButton.onClick.AddListener(_OnShopButtonClicked);
		}

		public override void Start()
		{
            base.Start();

            foreach (var deco in _decos)
            {
                var shopItem = _shopItemPrefab.Instantiate(_shopItemTransform);
                shopItem.Name = deco.Name;
                shopItem.Price = deco.Price;
            }
		}

		public void _OnShopButtonClicked()
        {
            _shopTransform.gameObject.SetActive(!_shopTransform.gameObject.activeInHierarchy);
        }
	}
}
