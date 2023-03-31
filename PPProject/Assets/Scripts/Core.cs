using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core
{
    [System.Serializable]
    public enum ItemType
    {
        Pen,
        Pencil,
        Notebook,
        Backpack,
        Bottle
    }

    [System.Serializable]
    public enum Colors
    {
        Black,
        White,
        Red,
        Green,
        Blue,
        Yellow,
        Orange,
        Purple,
        Pink,
        Brown
    }

    [System.Serializable]
    public enum Shifts
    {
        Morning, Afternoon, Night
    }

    [System.Serializable]
    public enum Courses
    {
        Info, EBM, PJD
    }

    [System.Serializable]
    public enum Period
    {
        First, Second, Third, Fourth
    }

    [System.Serializable]
    public class Item
    {
        [SerializeField] ItemType itemType;
        [SerializeField] Colors itemColor;
        [SerializeField] Shifts shift;
        [SerializeField] Courses course;
        [SerializeField] Period period;

        #region Getters
        public ItemType ItemType => itemType;
        public Colors ItemColor => itemColor;
        public Shifts Shift => shift;
        public Courses Course => course;
        public Period Period => period;
        #endregion

        public void Setup(ItemType _itemType, Colors _itemColor, Shifts _shift, Courses _course, Period _period)
        {
            itemType = _itemType;
            itemColor = _itemColor;
            shift = _shift;
            course = _course;
            period = _period;
        }
    }

    [System.Serializable]
    record MyItem
    {
        public ItemType item;
        public Colors color;
    }

    [System.Serializable]
    public class Registration
    {
        [SerializeField] string registry;

        #region Getters
        public string Registry => registry;
        #endregion

        public void CreateRegistry(Shifts _shift, Courses _course, Period _period)
        {
            string shiftChunk = $"{(int)_shift + 1}";
            string courseChunk = $"0{(int)_course + 1}";
            string registryNumber = $"0{(Random.Range(0, 40) + 1).ToString("00")}";
            //registry = string.Concat(periodChunk, courseChunk, shiftChunk, registryNumber);
            registry = $"{System.DateTime.Now.Year - (int)_period}{courseChunk}{shiftChunk}{registryNumber}";
        }
    }
}