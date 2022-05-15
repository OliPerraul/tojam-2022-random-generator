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
using Cirrus.Unity.Numerics;

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

        public Action<Deco> OnShopItemBoughtEvent;
       

		public override void Awake()
		{
            _shopButton.onClick.AddListener(_OnShopButtonClicked);
		}

		public override void Start()
		{
            base.Start();

            //_decos.Sort(Comparer. x => x.Price);
            _decos.Sort((a, b) => a.Price.CompareTo(b.Price));

            foreach (var deco in _decos)
            {
                int quantity = deco.ShopQuantity.Random();
                for (int i = 0; i < quantity; i++)
                {
                    var shopItem = _shopItemPrefab.Instantiate(_shopItemTransform);
                    shopItem.Name = deco.Name;
                    shopItem.Price = deco.Price;
                    shopItem.Deco = deco;
                    shopItem.OnBuyShopItemEvent += _OnShopItemBought;
                }
            }
		}

        private void _OnShopItemBought(ShopUiItem item)
        {
            if (Player.Instance.Money >= item.Deco.Price)
            {
                item.BuyShopItem();
                Player.Instance.UpdateMoney(-item.Deco.Price);
                OnShopItemBoughtEvent?.Invoke(item.Deco);
            }
        }

		public void _OnShopButtonClicked()
        {
            _shopTransform.gameObject.SetActive(!_shopTransform.gameObject.activeInHierarchy);
        }
	}
}
