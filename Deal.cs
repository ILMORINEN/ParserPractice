using System;

namespace ParcerPractice
{
    public class Deal
    {
        public string SellerName { get; set; } = "";

        public string SellerInn { get; set; } = "";

        public string BuyerName { get; set; } = "";

        public string BuyerInn { get; set; } = "";

        public decimal WoodVolumeBuyer { get; set; } = default;

        public decimal WoodVolumeSeller { get; set; } = default;

        public DateTime DealDate { get; set; }

        public string DealNumber { get; set; } = "";

        internal bool IsValid()
        {
            if (SellerName.Length > 1000)
                return false;

            if (SellerInn.Length != 12 && SellerInn.Length != 10)
                return false;

            if (BuyerName.Length > 1000)
                return false;

            if (BuyerInn.Length != 12 && BuyerInn.Length != 10)
                return false;

            if (WoodVolumeBuyer < 0)
                return false;

            if (WoodVolumeSeller < 0)
                return false;

            if (DealDate == null || DealDate < new DateTime(1753, 1, 1, 0, 0, 0) || DealDate > new DateTime(9999, 12, 31, 23, 59, 59))
                return false;

            if (DealNumber == null || DealNumber.Length != 28)
                return false;

            return true;
        }
    }
}