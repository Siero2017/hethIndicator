using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace Assets.Scripts.General.UI.universal_board.Extensions
{
    static class EventSystemExtensions
    {
        public static T GetFirstComponentUnderPoint<T>(this EventSystem system, PointerEventData eventData) where T : class
        {
            var result = new List<RaycastResult>();
            system.RaycastAll(eventData, result);

            foreach(var raycast in result)
            {
                if (raycast.gameObject.TryGetComponent<T>(out T component))
                    return component;
            }

            return null;
        }
    }
}
