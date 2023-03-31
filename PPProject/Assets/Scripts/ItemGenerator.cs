using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.GameSystem
{
    using Core;
    public class ItemGenerator : MonoBehaviour
    {
        [ContextMenuItem("Generate Item", nameof(GenerateItem))]
        [SerializeField] Item item;
        [ContextMenuItem("Generate Registration", nameof(GenerateRegistration))]
        [SerializeField] Registration registration;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void GenerateItem()
        {
            ItemType newItemType = (ItemType)Random.Range(0, System.Enum.GetNames(typeof(ItemType)).Length);
            Colors newItemColor = (Colors)Random.Range(0, System.Enum.GetNames(typeof(Colors)).Length);
            Shifts newItemShift = (Shifts)Random.Range(0, System.Enum.GetNames(typeof(Shifts)).Length);
            Courses newItemCourse = (Courses)Random.Range(0, System.Enum.GetNames(typeof(Courses)).Length);
            Period newItemPeriod = (Period)Random.Range(0, System.Enum.GetNames(typeof(Period)).Length);
            item.Setup(newItemType, newItemColor, newItemShift, newItemCourse, newItemPeriod);
            GenerateRegistration();
        }

        void GenerateRegistration()
        {
            registration.CreateRegistry(item.Shift, item.Course, item.Period);
        }
    }
}