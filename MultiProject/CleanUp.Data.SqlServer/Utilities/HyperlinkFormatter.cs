using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp.Data.SqlServer.Utilities
{
    public static class HyperLinkFormatter
    {
        public static string FormatTrackingHyperLink(string carrier, string trackingNumber)
        {
            string url = trackingNumber;
            //if (carrier == ShippingCarrierConstants.Usps)
            //{
            //    url = $"https://tools.usps.com/go/TrackConfirmAction?qtc_tLabels1={trackingNumber}";
            //}
            //else if (carrier == ShippingCarrierConstants.FedEx)
            //{
            //    url = $"https://www.fedex.com/fedextrack/no-results-found?trknbr={trackingNumber}";
            //}
            //else if (carrier == ShippingCarrierConstants.Ups)
            //{
            //    url = $"https://www.ups.com/track?loc=null&tracknum={trackingNumber}&requester=WT/trackdetails";
            //}
            return url;
        }

        public static string FormatPackageHyperLink(string host, string packageId)
        {
            var url = host == null
                ? $"/PackageSearch?packageId={packageId}"
                : $"https://{host}/PackageSearch?packageId={packageId}";
            return url;
        }
    }
}
