﻿namespace InvoiceQuery
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public int ItemType { get; set; }
        public string QuickBooksID { get; set; }
        public string EditSequence { get; set; }
    }
}